namespace Practice
{
    partial class NewRequest
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
            comboBoxTechModels = new ComboBox();
            label1 = new Label();
            textBoxProblemDescryption = new TextBox();
            label2 = new Label();
            buttonNewRequest = new Button();
            SuspendLayout();
            // 
            // comboBoxTechModels
            // 
            comboBoxTechModels.BackColor = Color.FromArgb(149, 143, 143);
            comboBoxTechModels.FlatStyle = FlatStyle.Flat;
            comboBoxTechModels.Font = new Font("Garamond", 14.25F);
            comboBoxTechModels.FormattingEnabled = true;
            comboBoxTechModels.Location = new Point(144, 35);
            comboBoxTechModels.Margin = new Padding(4, 3, 4, 3);
            comboBoxTechModels.Name = "comboBoxTechModels";
            comboBoxTechModels.Size = new Size(170, 29);
            comboBoxTechModels.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F);
            label1.Location = new Point(126, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 18);
            label1.TabIndex = 1;
            label1.Text = "1. Выберите модель техники:";
            // 
            // textBoxProblemDescryption
            // 
            textBoxProblemDescryption.BackColor = Color.FromArgb(149, 143, 143);
            textBoxProblemDescryption.Font = new Font("Garamond", 14.25F);
            textBoxProblemDescryption.Location = new Point(9, 97);
            textBoxProblemDescryption.Margin = new Padding(4, 3, 4, 3);
            textBoxProblemDescryption.MaxLength = 99;
            textBoxProblemDescryption.Multiline = true;
            textBoxProblemDescryption.Name = "textBoxProblemDescryption";
            textBoxProblemDescryption.Size = new Size(430, 140);
            textBoxProblemDescryption.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F);
            label2.Location = new Point(74, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(312, 18);
            label2.TabIndex = 3;
            label2.Text = "2. Опишите как можно подробнее проблему:";
            // 
            // buttonNewRequest
            // 
            buttonNewRequest.BackColor = Color.FromArgb(149, 143, 143);
            buttonNewRequest.FlatAppearance.BorderSize = 0;
            buttonNewRequest.FlatStyle = FlatStyle.Flat;
            buttonNewRequest.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNewRequest.ForeColor = Color.Black;
            buttonNewRequest.Location = new Point(145, 250);
            buttonNewRequest.Margin = new Padding(4, 3, 4, 3);
            buttonNewRequest.Name = "buttonNewRequest";
            buttonNewRequest.Size = new Size(169, 49);
            buttonNewRequest.TabIndex = 5;
            buttonNewRequest.Text = "Оставить заявку";
            buttonNewRequest.UseVisualStyleBackColor = false;
            buttonNewRequest.Click += buttonNewRequest_Click;
            // 
            // NewRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(447, 312);
            Controls.Add(buttonNewRequest);
            Controls.Add(label2);
            Controls.Add(textBoxProblemDescryption);
            Controls.Add(label1);
            Controls.Add(comboBoxTechModels);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewRequest";
            Text = "Учет заявок";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTechModels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProblemDescryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewRequest;
    }
}