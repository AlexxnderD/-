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
    public partial class ReportRequest : Form
    {
        DataBase dataBase = new DataBase();
        private string requestID;
        public ReportRequest(string requestID)
        {
            InitializeComponent();
            this.requestID = requestID;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (textBoxRepairParts.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                dataBase.OpenConnection();

                string query = $"UPDATE Requests SET requestStatus = 4, completionDate = SYSDATETIME(), repairParts = '{textBoxRepairParts.Text}' " +
                    $"WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                MessageBox.Show("Отчет успечшно создан.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
