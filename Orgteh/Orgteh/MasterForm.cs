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
    public partial class MasterForm : Form
    {
        DataBase dataBase = new DataBase();
        public MasterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetDataToTable("3", dataGridViewRequests);
        }

        private void MainTechnician_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            PersonalAccount account = new PersonalAccount();
            account.ShowDialog();
        }
        private void SetDataToTable(string status, DataGridView dataGridView)
        {
            dataBase.OpenConnection();
            string query = @"SELECT Requests.requestID, startDate, modelName, problemDescryption, fio, phone 
                FROM Requests
                INNER JOIN TechModels ON Requests.computerTechModel = TechModels.modelID
                INNER JOIN RequestStatuses ON Requests.requestStatus = RequestStatuses.statusID
                INNER JOIN Users ON userID = clientID " +
                $"WHERE requestStatus = {status} AND masterID = {LogIn.userID.ToString()}";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            foreach (DataColumn column in dt.Columns)
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn
                {
                    Name = column.ColumnName,
                    HeaderText = GetCustomHeaderText(column.ColumnName)
                };
                dataGridView.Columns.Add(dataGridViewColumn);
            }
            foreach (DataRow row in dt.Rows)
            {
                dataGridView.Rows.Add(row.ItemArray);
            }
            dataBase.CloseConnection();
        }
        private string GetCustomHeaderText(string columnName)
        {
            switch (columnName)
            {
                case "requestID":
                    return "Код заявки";
                case "startDate":
                    return "Дата создания";
                case "modelName":
                    return "Техника";
                case "problemDescryption":
                    return "Описание проблемы";
                case "fio":
                    return "ФИО клиента";
                case "phone":
                    return "Телефон клиента";
                default:
                    return columnName;
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewRequests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequests.Rows[selectedRowIndex];
                string requestID = selectedRow.Cells[0].Value.ToString();
                ReportRequest reportRequest = new ReportRequest(requestID);
                if (reportRequest.ShowDialog() == DialogResult.Cancel)
                {
                    SetDataToTable("3", dataGridViewRequests);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите завяку из таюлицы для создания отчета.");
            }
        }
    }
}
