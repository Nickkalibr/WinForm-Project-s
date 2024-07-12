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

namespace RGR_UD_MusicProgram.User
{
    public partial class OrdersAdd : Form
    {
        int idCustomer, idCargo, idPath;
        public OrdersAdd()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT idCustomer FROM `Customer` ORDER BY idCustomer DESC LIMIT 1;", db.getConnection());
            MySqlCommand command1 = new MySqlCommand("SELECT idCargo FROM `Cargo` ORDER BY idCargo DESC LIMIT 1;", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT idPath FROM `Path` ORDER BY idPath DESC LIMIT 1;", db.getConnection());

            db.openConnection();

            command.ExecuteNonQuery();
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();

            idCustomer = Convert.ToInt32(command.ExecuteScalar());
            idCargo = Convert.ToInt32(command1.ExecuteScalar());
            idPath = Convert.ToInt32(command2.ExecuteScalar());

            db.closeConnection();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (false)
            {

            } else
            {
                String name = CargoNameField.Text;
                int weight = Convert.ToInt32(CargoWeightField.Text);
                String start = PathStartField.Text;
                String end = PathEndField.Text;

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Cargo` (`CargoName`, `Weight`) VALUES (@name, @weight)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@weight", MySqlDbType.Int32).Value = weight;

                db.openConnection();

                command.ExecuteNonQuery();

                db.closeConnection();

                MySqlCommand command1 = new MySqlCommand("INSERT INTO `Path` (`PathStart`, `PathEnd`) VALUES (@start, @end)", db.getConnection());

                command1.Parameters.Add("@start", MySqlDbType.VarChar).Value = start;
                command1.Parameters.Add("@end", MySqlDbType.VarChar).Value = end;

                db.openConnection();

                command1.ExecuteNonQuery();

                db.closeConnection();

                LoadData();

                MySqlCommand command2 = new MySqlCommand("INSERT INTO `Orders` (`idCustomer`, `idCargo`, `idPath`) VALUES (@cust, @carg, @path)", db.getConnection());

                command2.Parameters.Add("@cust", MySqlDbType.Int32).Value = idCustomer;
                command2.Parameters.Add("@carg", MySqlDbType.Int32).Value = idCargo;
                command2.Parameters.Add("@path", MySqlDbType.Int32).Value = idPath;

                db.openConnection();

                command2.ExecuteNonQuery();

                db.closeConnection();
            }
        }
    }
}
