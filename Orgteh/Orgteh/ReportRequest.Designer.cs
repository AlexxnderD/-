namespace Practice
{
    partial class ReportRequest
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
            textBoxRepairParts = new TextBox();
            buttonReport = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(44, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(313, 18);
            label2.TabIndex = 1;
            label2.Text = "Укажите какие запчасти были использованы:";
            // 
            // textBoxRepairParts
            // 
            textBoxRepairParts.BackColor = Color.FromArgb(149, 143, 143);
            textBoxRepairParts.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRepairParts.Location = new Point(10, 36);
            textBoxRepairParts.Margin = new Padding(4, 3, 4, 3);
            textBoxRepairParts.MaxLength = 99;
            textBoxRepairParts.Multiline = true;
            textBoxRepairParts.Name = "textBoxRepairParts";
            textBoxRepairParts.Size = new Size(364, 116);
            textBoxRepairParts.TabIndex = 2;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(149, 143, 143);
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReport.ForeColor = Color.Black;
            buttonReport.Location = new Point(96, 164);
            buttonReport.Margin = new Padding(4, 3, 4, 3);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(191, 51);
            buttonReport.TabIndex = 3;
            buttonReport.Text = "Подтвердить отчёт";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // ReportRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(383, 227);
            Controls.Add(buttonReport);
            Controls.Add(textBoxRepairParts);
            Controls.Add(label2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReportRequest";
            Text = "Учет заявок";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRepairParts;
        private System.Windows.Forms.Button buttonReport;
    }
}