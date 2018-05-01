using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CLASSFingerPrint
{
    public partial class Form1 : Form
    {
        Bitmap bitmap1, bitmap2;

        // MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=fingerprint_kisii;password=;");
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");

        public object False { get; private set; }

        // private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Registration().Show();
           //this.Hide();
        }

        private void Reg_f_Click(object sender, EventArgs e)
        {

        }

        private void Attend_bt_Click(object sender, EventArgs e)
        {
            object Data = null;
            //Sqlconnection con = new Sqlconnection("Data Source = DESKTOP - QF4TR8O; Initial Catalog = KISII; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
           // con.Open();
           // SqlCommand cmd = new SqlCommand("",con);

           // con.Close();
            string insertQuery = "INSERT INTO classfingerprint.attendance(id,name,regnumber,cunit,Time)VALES('"+name_f.Text+ "','" + textBox2.Text + "''" + comboBox1.Text + "','" + unit_f.Text + "')";
           
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Data inserted");
                }
                else
                {
                    MessageBox.Show("Data not inserted");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            name_f.Text = "";
            textBox2.Clear();
            name_f.Focus();
            unit_f.Text = "";
            comboBox1.Text="";
            unit_f.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openflg.FileName;
                bitmap2 = new Bitmap(openflg.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool compare = ImageCompareString(bitmap1, bitmap2);
            if(compare == true)
            {
                MessageBox.Show("MATCH");
            }
            else
            {
                MessageBox.Show("NO MATCH");
            }
        }

        private bool ImageCompareString(Bitmap bitmap11, Bitmap bitmap21)
        {
            // throw new NotImplementedException();
            MemoryStream ms = new MemoryStream();
            bitmap11.Save(ms, ImageFormat.Png);
            String firstbitmap = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;
            bitmap21.Save(ms, ImageFormat.Png);
            String secondbitmap = Convert.ToBase64String(ms.ToArray());
            if (firstbitmap.Equals(secondbitmap))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if(openflg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openflg.FileName;
                bitmap1 = new Bitmap(openflg.FileName);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
