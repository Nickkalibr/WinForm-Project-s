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
    
    public partial class PathAdd : Form
    {
         long ExecID, AlbumID;
        public PathAdd()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DB db = new DB();
            
            db.openConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT idPath, PathStart, PathEnd FROM `Path`", db.getConnection());
            command1.Parameters.AddWithValue("@id", ExecID);

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
            if (AlbumNameField.Text == "" || MusicLengthField.Text == "")
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
                String start = AlbumNameField.Text;
                String end = MusicLengthField.Text;

                DB db = new DB();

                MySqlCommand command1 = new MySqlCommand("INSERT INTO `Path` (`PathStart`, `PathEnd`) VALUES (@start, @end)", db.getConnection());

                command1.Parameters.Add("@start", MySqlDbType.VarChar).Value = start;
                command1.Parameters.Add("@end", MySqlDbType.VarChar).Value = end;

                db.openConnection();

                command1.ExecuteNonQuery();

                db.closeConnection();

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex + 1;
            String start = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String end = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `Path` SET `PathStart` = @start, `PathEnd` = @end WHERE `Path`.`idPath` = @index", db.getConnection());

            command.Parameters.AddWithValue("@index", index);
            command.Parameters.AddWithValue("@start", start);
            command.Parameters.AddWithValue("@end", end);

            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex + 1;
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);

            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM `Path` WHERE `idPath` = @index", db.getConnection());
            command.Parameters.AddWithValue("@index", index);
            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void MusicLengthField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
