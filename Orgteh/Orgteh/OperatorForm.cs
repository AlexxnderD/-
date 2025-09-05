using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class OperatorForm : Form
    {
        DataBase dataBase = new DataBase();
        public OperatorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetDataToTable("1", dataGridViewNewRequests);
            SetDataToTable("2", dataGridViewProcessRequests);
        }
        private void SetDataToTable(string status, DataGridView dataGridView)
        {
            dataBase.OpenConnection();
            string query = @"SELECT Requests.requestID, startDate, modelName, problemDescryption, fio, phone 
                FROM Requests
                INNER JOIN TechModels ON Requests.computerTechModel = TechModels.modelID
                INNER JOIN RequestStatuses ON Requests.requestStatus = RequestStatuses.statusID
                INNER JOIN Users ON userID = clientID " +
                $"WHERE requestStatus = {status}";
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
        private void MainOperator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            PersonalAccount account = new PersonalAccount();
            account.ShowDialog();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (dataGridViewNewRequests.SelectedCells.Count > 0)
            {
                AcceptDenyRequest("2", dataGridViewNewRequests);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите завяку из таюлицы для принятия/отказа.");
            }
        }

        private void buttonDeny_Click(object sender, EventArgs e)
        {
            if (dataGridViewNewRequests.SelectedCells.Count > 0)
            {
                AcceptDenyRequest("5", dataGridViewNewRequests);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите завяку из таюлицы для принятия/отказа.");
            }
        }
        private void AcceptDenyRequest(string requestStatus, DataGridView dataGridView)
        {
            try
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[selectedRowIndex];
                string requestID = selectedRow.Cells[0].Value.ToString();
                dataBase.OpenConnection();
                string query = $"UPDATE Requests SET requestStatus = {requestStatus} WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                SetDataToTable("1", dataGridViewNewRequests);
                SetDataToTable("2", dataGridViewProcessRequests);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (dataGridViewProcessRequests.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewProcessRequests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewProcessRequests.Rows[selectedRowIndex];
                string requestID = selectedRow.Cells[0].Value.ToString();
                ProcessRequest processRequest = new ProcessRequest(requestID);
                if (processRequest.ShowDialog() == DialogResult.Cancel)
                {
                    SetDataToTable("2", dataGridViewProcessRequests);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите завяку из таюлицы для обработки.");
            }
        }
    }
}
