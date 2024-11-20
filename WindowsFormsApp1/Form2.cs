using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Avt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBsql dBsql = new DBsql();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Staff`(`id`, `login`, `Number`, `pass`) VALUES ('[value-1]','[value-2]','[value-3]')");

            command.Parameters.Add("[value-1]", MySqlDbType.VarChar).Value = RegFio;
            command.Parameters.Add("[value-2]", MySqlDbType.VarChar).Value = RegPas1;
            command.Parameters.Add("[value-3]", MySqlDbType.VarChar).Value = RegNumber;


            dBsql.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан успешно");
            else
                MessageBox.Show("Аккаунт не удалось создать");

            dBsql.closeConnection();


            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
