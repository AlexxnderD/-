using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practice
{
    public partial class NewRequest : Form
    {
        DataBase dataBase = new DataBase();
        public NewRequest()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                dataBase.OpenConnection();

                string query = "SELECT modelName FROM TechModels";

                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxTechModels.Items.Add(reader[0].ToString());
                }
                reader.Close();
                dataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonNewRequest_Click(object sender, EventArgs e)
        {
            if (comboBoxTechModels.Text == "" || textBoxProblemDescryption.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                dataBase.OpenConnection();

                string query = $"INSERT INTO Requests (computerTechModel, problemDescryption, requestStatus, clientID) " +
                    $"VALUES ({GetTechModelID()}, '{textBoxProblemDescryption.Text}', 1, '{LogIn.userID}')";

                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                int result = command.ExecuteNonQuery();
                dataBase.CloseConnection();

                if (result > 0)
                {
                    MessageBox.Show("Запись успешно создана!");
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении записи!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private string GetTechModelID()
        {
            try
            {
                string query = $"SELECT modelID FROM TechModels WHERE modelName = '{comboBoxTechModels.Text}'";

                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                string modelID = null;
                if (reader.Read())
                {
                    modelID = reader[0].ToString();
                }
                reader.Close();
                return modelID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return null;
            }
        }
    }
}
