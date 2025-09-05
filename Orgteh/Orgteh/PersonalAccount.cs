using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class PersonalAccount : Form
    {
        public PersonalAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PersonalAccount_Load(object sender, EventArgs e)
        {
            labelSurname.Text = LogIn.surname;
            labelName.Text = LogIn.name;
            labelType.Text = LogIn.type;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Hide();
            }
            logIn.ShowDialog();
        }
    }
}
