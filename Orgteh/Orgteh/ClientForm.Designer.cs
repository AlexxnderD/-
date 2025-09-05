namespace Practice
{
    partial class ClientForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            buttonAccount = new Button();
            dataGridViewRequests = new DataGridView();
            buttonNewRequest = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = Color.FromArgb(0, 109, 119);
            buttonAccount.FlatAppearance.BorderColor = Color.White;
            buttonAccount.ForeColor = Color.White;
            buttonAccount.Location = new Point(136, -2);
            buttonAccount.Margin = new Padding(4, 3, 4, 3);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(86, 26);
            buttonAccount.TabIndex = 0;
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
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRequests.Location = new Point(8, 25);
            dataGridViewRequests.Margin = new Padding(4, 3, 4, 3);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.ReadOnly = true;
            dataGridViewRequests.Size = new Size(1098, 501);
            dataGridViewRequests.TabIndex = 2;
            // 
            // buttonNewRequest
            // 
            buttonNewRequest.BackColor = Color.FromArgb(149, 143, 143);
            buttonNewRequest.FlatAppearance.BorderSize = 0;
            buttonNewRequest.FlatStyle = FlatStyle.Flat;
            buttonNewRequest.Font = new Font("Garamond", 14F);
            buttonNewRequest.Location = new Point(15, 537);
            buttonNewRequest.Margin = new Padding(4, 3, 4, 3);
            buttonNewRequest.Name = "buttonNewRequest";
            buttonNewRequest.Size = new Size(174, 52);
            buttonNewRequest.TabIndex = 3;
            buttonNewRequest.Text = "Оставить заявку";
            buttonNewRequest.UseVisualStyleBackColor = false;
            buttonNewRequest.Click += buttonNewRequest_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(149, 143, 143);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Garamond", 14F);
            buttonEdit.Location = new Point(384, 537);
            buttonEdit.Margin = new Padding(4, 3, 4, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(259, 52);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Редактировать заявку";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(149, 143, 143);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Garamond", 14F);
            buttonDelete.Location = new Point(206, 537);
            buttonDelete.Margin = new Padding(4, 3, 4, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(160, 52);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Удалить заявку";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 18);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(992, 2);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 7;
            label2.Text = "Вернуться назад";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(1113, 600);
            Controls.Add(label2);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonNewRequest);
            Controls.Add(dataGridViewRequests);
            Controls.Add(label1);
            Controls.Add(buttonAccount);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ClientForm";
            Text = "Учет заявок";
            FormClosed += MainClient_FormClosed;
            this.Load += new System.EventHandler(this.MainClient_Load);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button buttonNewRequest;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private Label label1;
        private Label label2;
    }
}