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
    public partial class EditRequest : Form
    {
        DataBase dataBase = new DataBase();
        private string requestID;
        public EditRequest(string requestID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.requestID = requestID;
            SetDataToTextBoxes();
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
        private void SetDataToTextBoxes()
        {
            try
            {
                dataBase.OpenConnection();
                string query = $"SELECT modelName, problemDescryption FROM Requests " +
                    $"INNER JOIN TechModels ON computerTechModel = modelID" +
                    $" WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    comboBoxTechModels.Text = reader[0].ToString();
                    textBoxProblemDescryption.Text = reader[1].ToString();
                }
                reader.Close();
                dataBase.CloseConnection();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTechModels.Text == "" || textBoxProblemDescryption.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                dataBase.OpenConnection();

                string query = $"UPDATE Requests SET computerTechModel = {GetTechModelID()}, " +
                    $"problemDescryption = '{textBoxProblemDescryption.Text}' WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                MessageBox.Show("Заявка успешно обновлена.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
