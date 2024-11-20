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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            Avt.BackColor = Color.Transparent;
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = Login.Text;
            String password = Password.Text;

            DBsql dBsql = new DBsql();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Staff` WHERE `login`=@lU AND `pass`=@p", dBsql.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                MessageBox.Show("Авторизация прошла успешна!");
            else
                MessageBox.Show("Неправильно введ логин или пароль!");
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
        }

        private void NaRegbutton_Click(object sender, EventArgs e)
        {

        }

        private void AccNo_Click(object sender, EventArgs e)
        {
            AccNo.BackColor = Color.Transparent;
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
