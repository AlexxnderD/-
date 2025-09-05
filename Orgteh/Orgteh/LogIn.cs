using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Practice
{
    public partial class LogIn : Form
    {
        DataBase dataBase = new DataBase();

        public static string name = null;
        public static string surname = null;
        public static string type = null;
        public static int userID;

        private bool eye = true;
        private bool restartApplication = false;
        private string textCaptcha = null;
        private int fails = 0;
        private int timeCounter = 180;
        public LogIn()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxLogin.MaxLength = 25;
            textBoxPassword.MaxLength = 25;
            this.StartPosition = FormStartPosition.CenterScreen;
            timerEnter.Interval = 1000;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (restartApplication)
            {
                Application.Restart();
            }
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string query = $"SELECT userID, fio, type FROM Users WHERE login = '{login}' and password = '{password}'";
            SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
            adapter.SelectCommand = sqlCommand;
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Нет подключения к БД!");
                return;
            }

            if (panelCaptcha.Visible == true)
            {
                if (textBoxCaptcha.Text != textCaptcha)
                {
                    MessageBox.Show("Неверная капча!");
                    return;
                }
            }
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!");
                SaveLoginData(login, "Успех");
                string[] arrFio = dt.Rows[0]["fio"].ToString().Split();
                name = arrFio[1];
                surname = arrFio[0];
                type = dt.Rows[0]["type"].ToString();
                userID = Convert.ToInt32(dt.Rows[0]["userID"]);
                Form MainForm = new Form();
                switch (type)
                {
                    case "Заказчик": MainForm = new ClientForm(); break;
                    case "Техник": MainForm = new MasterForm(); break;
                    case "Оператор": MainForm = new OperatorForm(); break;
                }
                this.Hide();
                MainForm.ShowDialog();
            }

            else
            {
                fails++;
                SaveLoginData(login, "Ошибка");
                FailedLogin();
            }
        }

        private void SaveLoginData(string login, string loginTry)
        {
            dataBase.OpenConnection();
            string query = $"INSERT INTO LoginHistory (userLogin, loginTry) " +
                    $"VALUES ('{login}', '{loginTry}')";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.CloseConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (eye)
            {
                textBoxPassword.PasswordChar = '*';
            }

            else
            {
                textBoxPassword.PasswordChar = '\0';
            }

            eye = !eye;
        }
        private void FailedLogin()
        {
            if (fails == 2)
            {
                timerEnter.Start();
                buttonLogin.Enabled = false;
            }
            else if (fails == 3)
            {
                restartApplication = true;
                buttonLogin.Text = "Перезапустите!";
            }

            MessageBox.Show("Неправильно введён логин или пароль!");
            textBoxLogin.Text = null;
            textBoxPassword.Text = null;
            panelCaptcha.Visible = true;
            pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, Width - 70);
            int Ypos = rnd.Next(0, Height - 15);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            Graphics g = Graphics.FromImage(result);

            g.Clear(Color.Gray);

            textCaptcha = null;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                textCaptcha += ALF[rnd.Next(ALF.Length)];

            g.DrawString(textCaptcha, new Font("Arial", 15), colors[rnd.Next(colors.Length)], new PointF(Xpos, Ypos));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black, new Point(0, Height - 1), new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void buttonNewCaptcha_Click(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }

        private void timerEnter_Tick(object sender, EventArgs e)
        {
            buttonLogin.Text = timeCounter.ToString();
            timeCounter--;
            if (timeCounter < 0)
            {
                timerEnter.Stop();
                buttonLogin.Enabled = true;
                buttonLogin.Text = "Вход";
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}