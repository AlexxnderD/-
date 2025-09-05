using System.Drawing;

namespace Practice
{
    partial class LogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelAuthorization = new Label();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            timerEnter = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBoxCaptcha = new PictureBox();
            textBoxCaptcha = new TextBox();
            label1 = new Label();
            buttonNewCaptcha = new Button();
            panelCaptcha = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).BeginInit();
            panelCaptcha.SuspendLayout();
            SuspendLayout();
            // 
            // labelAuthorization
            // 
            labelAuthorization.AutoSize = true;
            labelAuthorization.Font = new Font("Garamond", 24F);
            labelAuthorization.Location = new Point(62, 20);
            labelAuthorization.Margin = new Padding(4, 0, 4, 0);
            labelAuthorization.Name = "labelAuthorization";
            labelAuthorization.Size = new Size(316, 36);
            labelAuthorization.TabIndex = 0;
            labelAuthorization.Text = "Авторизация в систему";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Garamond", 12F);
            labelLogin.Location = new Point(80, 106);
            labelLogin.Margin = new Padding(4, 0, 4, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(51, 18);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Garamond", 12F);
            labelPassword.Location = new Point(73, 139);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(58, 18);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(149, 143, 143);
            textBoxLogin.Font = new Font("Garamond", 12F);
            textBoxLogin.ForeColor = SystemColors.WindowText;
            textBoxLogin.Location = new Point(139, 103);
            textBoxLogin.Margin = new Padding(4, 3, 4, 3);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(123, 25);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(149, 143, 143);
            textBoxPassword.Font = new Font("Garamond", 12F);
            textBoxPassword.ForeColor = SystemColors.WindowText;
            textBoxPassword.Location = new Point(139, 136);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(123, 25);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(149, 143, 143);
            buttonLogin.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 109, 119);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Garamond", 14F);
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(130, 175);
            buttonLogin.Margin = new Padding(4, 3, 4, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(181, 30);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // timerEnter
            // 
            timerEnter.Tick += timerEnter_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.Location = new Point(269, 142);
            label2.Name = "label2";
            label2.Size = new Size(97, 14);
            label2.TabIndex = 13;
            label2.Text = "Показать пароль";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 14F);
            label3.Location = new Point(64, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(225, 21);
            label3.TabIndex = 14;
            label3.Text = "Пожалуйста, авторизуйтесь";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(8, 3);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 18);
            label4.TabIndex = 15;
            label4.Text = "Для продолжения пройдите капчу";
            // 
            // pictureBoxCaptcha
            // 
            pictureBoxCaptcha.Location = new Point(79, 58);
            pictureBoxCaptcha.Margin = new Padding(4, 3, 4, 3);
            pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            pictureBoxCaptcha.Size = new Size(110, 42);
            pictureBoxCaptcha.TabIndex = 7;
            pictureBoxCaptcha.TabStop = false;
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.BackColor = Color.FromArgb(149, 143, 143);
            textBoxCaptcha.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCaptcha.Location = new Point(58, 29);
            textBoxCaptcha.Margin = new Padding(4, 3, 4, 3);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(103, 25);
            textBoxCaptcha.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 10;
            label1.Text = "Ответ";
            // 
            // buttonNewCaptcha
            // 
            buttonNewCaptcha.BackColor = Color.FromArgb(149, 143, 143);
            buttonNewCaptcha.FlatAppearance.BorderSize = 0;
            buttonNewCaptcha.FlatStyle = FlatStyle.Flat;
            buttonNewCaptcha.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNewCaptcha.ForeColor = Color.Black;
            buttonNewCaptcha.Location = new Point(170, 29);
            buttonNewCaptcha.Margin = new Padding(4, 3, 4, 3);
            buttonNewCaptcha.Name = "buttonNewCaptcha";
            buttonNewCaptcha.Size = new Size(87, 23);
            buttonNewCaptcha.TabIndex = 8;
            buttonNewCaptcha.Text = "Обновить";
            buttonNewCaptcha.UseVisualStyleBackColor = false;
            buttonNewCaptcha.Click += buttonNewCaptcha_Click;
            // 
            // panelCaptcha
            // 
            panelCaptcha.Controls.Add(label4);
            panelCaptcha.Controls.Add(buttonNewCaptcha);
            panelCaptcha.Controls.Add(pictureBoxCaptcha);
            panelCaptcha.Controls.Add(label1);
            panelCaptcha.Controls.Add(textBoxCaptcha);
            panelCaptcha.Location = new Point(81, 221);
            panelCaptcha.Margin = new Padding(4, 3, 4, 3);
            panelCaptcha.Name = "panelCaptcha";
            panelCaptcha.Size = new Size(266, 107);
            panelCaptcha.TabIndex = 12;
            panelCaptcha.Visible = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(452, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(labelAuthorization);
            Controls.Add(panelCaptcha);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LogIn";
            Text = "Учет заявок";
            FormClosed += LogIn_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).EndInit();
            panelCaptcha.ResumeLayout(false);
            panelCaptcha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Timer timerEnter;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxCaptcha;
        private TextBox textBoxCaptcha;
        private Label label1;
        private Button buttonNewCaptcha;
        private Panel panelCaptcha;
    }
}

