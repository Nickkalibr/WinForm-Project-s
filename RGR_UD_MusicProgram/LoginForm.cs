using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_UD_MusicProgram
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            LoginField.Text = "Логин";
            LoginField.ForeColor = Color.Gray;

            PassField.Text = "Пароль";
            PassField.ForeColor = Color.Gray;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm rf = new RegForm();
            rf.Show();
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Логин")
            {
                LoginField.Text = String.Empty;
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == String.Empty)
            {
                LoginField.Text = "Логин";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Пароль")
            {
                PassField.Text = String.Empty;
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == String.Empty)
            {
                PassField.Text = "Пароль";
                PassField.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "Логин" || PassField.Text == "Пароль")
            {
                MessageBox.Show(
                    "Вы не заполнили одно из полей.",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            } else
            {
                if (LoginField.Text == "Admin" || PassField.Text == "Admin")
                {   
                    this.Hide();
                    Dispatcher.DispatcherMenu dm = new Dispatcher.DispatcherMenu();
                    dm.Show();
                    
                } 
                else
                {
                    Data.Value = LoginField.Text;
                    this.Hide();
                    User.OrdersAdd ca = new User.OrdersAdd();
                    ca.Show();
                }
            }
        }
    }
}
