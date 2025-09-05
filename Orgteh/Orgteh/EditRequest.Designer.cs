namespace Practice
{
    partial class EditRequest
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
            label2 = new Label();
            textBoxProblemDescryption = new TextBox();
            label3 = new Label();
            comboBoxTechModels = new ComboBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F);
            label2.Location = new Point(20, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 18);
            label2.TabIndex = 7;
            label2.Text = "Редактирование комментария:";
            // 
            // textBoxProblemDescryption
            // 
            textBoxProblemDescryption.BackColor = Color.FromArgb(149, 143, 143);
            textBoxProblemDescryption.Font = new Font("Garamond", 14F);
            textBoxProblemDescryption.Location = new Point(6, 90);
            textBoxProblemDescryption.Margin = new Padding(4, 3, 4, 3);
            textBoxProblemDescryption.MaxLength = 99;
            textBoxProblemDescryption.Multiline = true;
            textBoxProblemDescryption.Name = "textBoxProblemDescryption";
            textBoxProblemDescryption.Size = new Size(322, 125);
            textBoxProblemDescryption.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F);
            label3.Location = new Point(82, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 18);
            label3.TabIndex = 5;
            label3.Text = "Выберите модель техники:";
            // 
            // comboBoxTechModels
            // 
            comboBoxTechModels.BackColor = Color.FromArgb(149, 143, 143);
            comboBoxTechModels.Font = new Font("Garamond", 14F);
            comboBoxTechModels.FormattingEnabled = true;
            comboBoxTechModels.Location = new Point(84, 33);
            comboBoxTechModels.Margin = new Padding(4, 3, 4, 3);
            comboBoxTechModels.Name = "comboBoxTechModels";
            comboBoxTechModels.Size = new Size(181, 29);
            comboBoxTechModels.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(149, 143, 143);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Garamond", 14F);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(108, 223);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(127, 44);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // EditRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(334, 276);
            Controls.Add(buttonSave);
            Controls.Add(label2);
            Controls.Add(textBoxProblemDescryption);
            Controls.Add(label3);
            Controls.Add(comboBoxTechModels);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditRequest";
            Text = "Учет заявок";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProblemDescryption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTechModels;
        private System.Windows.Forms.Button buttonSave;
    }
}