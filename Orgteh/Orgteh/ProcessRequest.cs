using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class ProcessRequest : Form
    {
        DataBase dataBase = new DataBase();
        private string requestID;
        public ProcessRequest(string requestID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.requestID = requestID;
            try
            {
                dataBase.OpenConnection();

                string query = "SELECT fio FROM Users WHERE type = 'Техник'";

                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxMasters.Items.Add(reader[0].ToString());
                }
                reader.Close();
                dataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private string GetMesterID()
        {
            try
            {
                string query = $"SELECT userID FROM Users WHERE fio = '{comboBoxMasters.Text}'";
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

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (comboBoxMasters.Text == "")
            {
                MessageBox.Show("Выберите мастера для выполнения завяки!");
                return;
            }
            try
            {
                dataBase.OpenConnection();

                string query = $"UPDATE Requests SET masterID = {GetMesterID()}, requestStatus = 3 WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                CommentRequest();
                dataBase.CloseConnection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void CommentRequest()
        {
            string query = $"INSERT INTO Comments (message, masterID, requestID) " +
                $"VALUES ('{textBoxMessage.Text}', {LogIn.userID.ToString()}, {requestID})";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
        }
    }
}
