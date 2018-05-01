using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CLASSFingerPrint
{
    public partial class Registration : Form
    {
        Bitmap bitmap1, bitmap2;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;"); 


        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
          
        }

        private void Register_bt_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO classfingerprint.registration(name,regnumber) VALUES('"+ R_name.Text+ "','" + R_number.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery,connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA INSERTED");
                }
                else
                {
                    MessageBox.Show("DATA NOT INSERTED");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R_name.Text = "";
            R_number.Clear();
            R_name.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openflg.FileName;
                bitmap1 = new Bitmap(openflg.FileName);

            }
        }
    }
}
