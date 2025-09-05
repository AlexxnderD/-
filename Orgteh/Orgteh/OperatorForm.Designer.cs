namespace Practice
{
    partial class OperatorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.dataGridViewNewRequests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProcessRequests = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonDeny = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Location = new System.Drawing.Point(682, 12);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(106, 44);
            this.buttonAccount.TabIndex = 1;
            this.buttonAccount.Text = "Личный кабинет";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // dataGridViewNewRequests
            // 
            this.dataGridViewNewRequests.AllowUserToAddRows = false;
            this.dataGridViewNewRequests.AllowUserToDeleteRows = false;
            this.dataGridViewNewRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNewRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNewRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.dataGridViewNewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNewRequests.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewNewRequests.Location = new System.Drawing.Point(39, 54);
            this.dataGridViewNewRequests.Name = "dataGridViewNewRequests";
            this.dataGridViewNewRequests.ReadOnly = true;
            this.dataGridViewNewRequests.Size = new System.Drawing.Size(592, 190);
            this.dataGridViewNewRequests.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Новые заявки";
            // 
            // dataGridViewProcessRequests
            // 
            this.dataGridViewProcessRequests.AllowUserToAddRows = false;
            this.dataGridViewProcessRequests.AllowUserToDeleteRows = false;
            this.dataGridViewProcessRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProcessRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProcessRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.dataGridViewProcessRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProcessRequests.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProcessRequests.Location = new System.Drawing.Point(39, 290);
            this.dataGridViewProcessRequests.Name = "dataGridViewProcessRequests";
            this.dataGridViewProcessRequests.ReadOnly = true;
            this.dataGridViewProcessRequests.Size = new System.Drawing.Size(592, 210);
            this.dataGridViewProcessRequests.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заявки в обработке";
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.buttonAccept.Location = new System.Drawing.Point(682, 92);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 37);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "Принять заявку";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonDeny
            // 
            this.buttonDeny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.buttonDeny.Location = new System.Drawing.Point(682, 149);
            this.buttonDeny.Name = "buttonDeny";
            this.buttonDeny.Size = new System.Drawing.Size(75, 37);
            this.buttonDeny.TabIndex = 8;
            this.buttonDeny.Text = "Отклонить заявку";
            this.buttonDeny.UseVisualStyleBackColor = false;
            this.buttonDeny.Click += new System.EventHandler(this.buttonDeny_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.buttonProcess.Location = new System.Drawing.Point(682, 376);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 42);
            this.buttonProcess.TabIndex = 9;
            this.buttonProcess.Text = "Обработать заявку";
            this.buttonProcess.UseVisualStyleBackColor = false;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // MainOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonDeny);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProcessRequests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNewRequests);
            this.Controls.Add(this.buttonAccount);
            this.Name = "MainOperator";
            this.Text = "Учет заявок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainOperator_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.DataGridView dataGridViewNewRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProcessRequests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonDeny;
        private System.Windows.Forms.Button buttonProcess;
    }
}