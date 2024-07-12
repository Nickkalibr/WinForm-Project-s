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



namespace RGR_UD_MusicProgram.Executor
{
    public partial class CargoAdd : Form
    {
        long id;
        public CargoAdd()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DB db = new DB();
            
            db.openConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT idCargo, CargoName, Weight FROM `Cargo`", db.getConnection());
            
            MySqlDataReader reader = command1.ExecuteReader();
            List<string[]> data = new List<string[]>();
            
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        }

        

        private void Addbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Addbutton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex + 1;
            String name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String weight = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `Cargo` SET `CargoName` = @name, `Weight` = @weight WHERE idCargo = @index",db.getConnection());
            command.Parameters.AddWithValue("@index", index);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@weight", weight);

            command.ExecuteNonQuery();

            db.closeConnection();

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex + 1;
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);

            DB db = new DB();

            db.getConnection().Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `Cargo` WHERE `Cargo`.`idCargo` = @index", db.getConnection());
            command.Parameters.AddWithValue("@index", index);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
