namespace Practice
{
    partial class MasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            buttonAccount = new Button();
            dataGridViewRequests = new DataGridView();
            label1 = new Label();
            buttonReport = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = Color.FromArgb(0, 109, 119);
            buttonAccount.ForeColor = Color.White;
            buttonAccount.Location = new Point(137, -1);
            buttonAccount.Margin = new Padding(4, 3, 4, 3);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(102, 22);
            buttonAccount.TabIndex = 1;
            buttonAccount.Text = "Личный кабинет";
            buttonAccount.UseVisualStyleBackColor = false;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.AllowUserToAddRows = false;
            dataGridViewRequests.AllowUserToDeleteRows = false;
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRequests.BackgroundColor = Color.FromArgb(149, 143, 143);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Cursor = Cursors.No;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRequests.GridColor = Color.Black;
            dataGridViewRequests.Location = new Point(8, 25);
            dataGridViewRequests.Margin = new Padding(4, 3, 4, 3);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(149, 143, 143);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewRequests.Size = new Size(1096, 456);
            dataGridViewRequests.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 18);
            label1.TabIndex = 4;
            label1.Text = "Добро пожаловать!";
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(149, 143, 143);
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReport.Location = new Point(329, 489);
            buttonReport.Margin = new Padding(4, 3, 4, 3);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(453, 42);
            buttonReport.TabIndex = 5;
            buttonReport.Text = "Сформировать отчёт о выполняемых работ";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(990, 3);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 6;
            label2.Text = "Вернуться назад";

            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(1111, 538);
            Controls.Add(label2);
            Controls.Add(buttonReport);
            Controls.Add(label1);
            Controls.Add(dataGridViewRequests);
            Controls.Add(buttonAccount);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MasterForm";
            Text = "Учет заявок";
            FormClosed += MainTechnician_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReport;
        private Label label2;
    }
}