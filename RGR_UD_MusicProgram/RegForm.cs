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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            LoginField.Text = "Логин";
            LoginField.ForeColor = Color.Gray;
            
            PassField.Text = "Пароль";
            PassField.ForeColor = Color.Gray;
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
                String name = LoginField.Text;
                String pass = PassField.Text;

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Customer` (`Name`, `Password`) VALUES (@name, @pass)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

                db.openConnection();

                command.ExecuteNonQuery();

                db.closeConnection();

                this.Hide();
                LoginForm lf = new LoginForm();
                lf.Show();
            }
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

        private void EmailField_Enter(object sender, EventArgs e)
        {
            
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            
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
    }
}
