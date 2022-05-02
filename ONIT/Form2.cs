using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;



namespace Prackticka
{
    public partial class Form2 : Form
    {
       

        private SqlConnection sqlConnection1 = null;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection1.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM League_of_legends", sqlConnection1);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO[League_of_legends] (Name, Line, Rank, Point, Location, Number_of_games) VALUES (@Name, @Line, @Rank, @Point, @Location, @Number_of_games)", sqlConnection1);


                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Line", textBox2.Text);
                command.Parameters.AddWithValue("Rank", textBox3.Text);
                command.Parameters.AddWithValue("Point", textBox4.Text);
                command.Parameters.AddWithValue("Location", textBox5.Text);
                command.Parameters.AddWithValue("Number_of_games", textBox6.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено!");

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM League_of_legends", sqlConnection1);

                DataSet db = new DataSet();

                dataAdapter.Fill(db);
                dataGridView1.DataSource = db.Tables[0];


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand del = new SqlCommand("DELETE [League_of_legends] WHERE ID = @Id", sqlConnection1);

            del.Parameters.AddWithValue("@Id", textBox7.Text);

            del.ExecuteNonQuery();
            MessageBox.Show("Удалено");

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM League_of_legends", sqlConnection1);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wish = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    wish.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }    

            exApp.Visible = true;
        }
        static string sKey;
        private void button4_Click(object sender, EventArgs e)
        {
  
            sKey = textBox8.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string source = openFileDialog1.FileName;
                saveFileDialog1.Filter = "des files |*.des";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string destination = saveFileDialog1.FileName;
                    EncryptFile(source, destination, sKey);
                }
            }
        }
        private void EncryptFile(string source, string destination, string sKey)
        {
            FileStream fsInput = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(destination, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            try
            {
                DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                ICryptoTransform desencrypt = DES.CreateEncryptor();
                CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
                byte[] bytearrayinput = new byte[fsInput.Length - 0];
                fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
                return;
            }
            fsInput.Close();
            fsEncrypted.Close();
        }

        private void DecryptFile(string source, string destination, string sKey)
        {
            FileStream fsInput = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(destination, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            try
            {
                DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                ICryptoTransform desencrypt = DES.CreateDecryptor();
                CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
                byte[] bytearrayinput = new byte[fsInput.Length - 0];
                fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
                return;
            }
            fsInput.Close();
            fsEncrypted.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sKey = textBox8.Text;
            openFileDialog1.Filter = "des files |*.des";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string source = openFileDialog1.FileName;
                saveFileDialog1.Filter = "exel files |*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string destination = saveFileDialog1.FileName;
                    DecryptFile(source, destination, sKey);
                }
            }
        }

        public static ManualResetEvent connectDone = new ManualResetEvent(false);

       
        
    }       
}
