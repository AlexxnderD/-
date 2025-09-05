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
    public partial class ClientForm : Form
    {
        DataBase dataBase = new DataBase();
        private string userID = LogIn.userID.ToString();
        public ClientForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            PersonalAccount account = new PersonalAccount();
            account.ShowDialog();
        }

        private void MainClient_Load(object sender, EventArgs e)
        {
            SetDataToTable();
        }
        private void SetDataToTable()
        {
            dataBase.OpenConnection();
            string query = @"SELECT Requests.requestID, startDate, techName, problemDescryption, statusName, message 
                FROM Requests
                INNER JOIN TechModels ON Requests.computerTechModel = TechModels.modelID
                INNER JOIN TechTypes ON TechModels.techID = TechTypes.techID
                INNER JOIN RequestStatuses ON Requests.requestStatus = RequestStatuses.statusID
                LEFT JOIN Comments ON Comments.requestID = Requests.requestID
                WHERE Requests.clientID = '" + userID + "'";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewRequests.Columns.Clear();
            dataGridViewRequests.Rows.Clear();
            foreach (DataColumn column in dt.Columns)
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn
                {
                    Name = column.ColumnName,
                    HeaderText = GetCustomHeaderText(column.ColumnName)
                };
                dataGridViewRequests.Columns.Add(dataGridViewColumn);
            }
            foreach (DataRow row in dt.Rows)
            {
                dataGridViewRequests.Rows.Add(row.ItemArray);
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
                case "techName":
                    return "Техника";
                case "problemDescryption":
                    return "Описание проблемы";
                case "statusName":
                    return "Статус";
                case "message":
                    return "Комментарий";
                default:
                    return columnName;
            }
        }

        private void buttonNewRequest_Click(object sender, EventArgs e)
        {
            NewRequest newRequest = new NewRequest();
            if (newRequest.ShowDialog() == DialogResult.Cancel)
            {
                SetDataToTable();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewRequests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequests.Rows[selectedRowIndex];
                if (selectedRow.Cells[4].Value.ToString() != "Новая заявка")
                {
                    MessageBox.Show("Вы можете редактировать заявки только со статусом 'Новая заявка'!");
                    return;
                }
                string requestID = selectedRow.Cells[0].Value.ToString();
                EditRequest editRequest = new EditRequest(requestID);
                if (editRequest.ShowDialog() == DialogResult.Cancel)
                {
                    SetDataToTable();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите завяку из таблицы для обработки.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewRequests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequests.Rows[selectedRowIndex];
                if (selectedRow.Cells[4].Value.ToString() != "Новая заявка")
                {
                    MessageBox.Show("Вы можете удалять заявки только со статусом 'Новая заявка'!");
                    return;
                }
                string requestID = selectedRow.Cells[0].Value.ToString();
                dataBase.OpenConnection();
                string query = $"DELETE FROM Requests WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                MessageBox.Show("Заявка успешно удалена.");
                SetDataToTable();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите завяку из таблицы для обработки.");
            }
        }
    }
}