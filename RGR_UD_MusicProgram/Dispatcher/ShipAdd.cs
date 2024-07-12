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
    public partial class ShipAdd : Form
    {
        String PlaylistName, MusCompName;
        long PlaylistID, MusCompID;
        public ShipAdd()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            DB db = new DB();

            String name = Data.Value;


            db.openConnection();

            MySqlCommand command = new MySqlCommand("Select ShipName, Capacity from `Ship` WHERE 1", db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (MusNameField.Text == "" || PlaylistNameField.Text == "")
            {
                MessageBox.Show(
                    "Вы не заполнили одно из полей.",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            else
            {
                String Name = MusNameField.Text;
                String Capacity = PlaylistNameField.Text;

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Ship` (`ShipName`, `Capacity`) VALUES (@name, @cpct)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name;
                command.Parameters.Add("@cpct", MySqlDbType.Int64).Value = Capacity;

                db.openConnection();

                command.ExecuteNonQuery();

                db.closeConnection();

            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex + 1;
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);

            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM `Ship` WHERE idShip = @index", db.getConnection());
            command.Parameters.AddWithValue("@index", index);
            command.ExecuteNonQuery();

            db.closeConnection();
        }

        
    }
}
