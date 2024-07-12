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

namespace RGR_UD_MusicProgram.Dispatcher
{
    public partial class OrdersAdd : Form
    {
        public OrdersAdd()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DB db = new DB();

            db.openConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT idOrders, idShip, idCustomer, idCargo, idPath FROM `Orders`", db.getConnection());

            MySqlDataReader reader = command1.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); ;
            int ship = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            int customer = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            int cargo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            int path = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `Orders` SET `idShip` = @ship, `idCustomer` = @cust, `idCargo` = @cargo, `idPath` = @path WHERE `idOrders` = @index", db.getConnection());

            db.openConnection();

            command.Parameters.AddWithValue("@index", index);
            command.Parameters.AddWithValue("@ship", ship);
            command.Parameters.AddWithValue("@cust", customer);
            command.Parameters.AddWithValue("@cargo", cargo);
            command.Parameters.AddWithValue("@path", path);

            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); ;
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);

            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM `Orders` WHERE `idOrders` = @index", db.getConnection());
            command.Parameters.AddWithValue("@index", index);
            command.ExecuteNonQuery();

            db.closeConnection();
        }
    }
}
