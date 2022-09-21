using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace winf
{
    public partial class Form1 : Form
    {
        //private LinkedList<User> _UserList { get; set; }

        //public Form1()
        //{
        //    InitializeComponent();

        //    StartPosition = FormStartPosition.CenterScreen;

        //    this.password.AutoSize = false;
        //    this.password.Size = new Size(this.password.Size.Width, 37);
        //    login.Text = "Write your email";


        //    if (File.Exists("UserBank.json"))
        //    {
        //        _UserList = DBank.DeserializeUsers();
        //    }
        //    else
        //    {
        //        StreamWriter sw = File.CreateText("UserBank.json");
        //    }

        //    _UserList = new LinkedList<User>();
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    ClientSize = new Size(818, 497);
        //    this.Text = "mail";
        //    pictureBox1.Image = Properties.Resources.mail;
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void login_Enter(object sender, EventArgs e)
        //{
        //    if (login.Text == "Write your email")
        //    {
        //        login.Text = "";
        //        login.ForeColor = Color.Black;
        //    }
        //}

        //private void login_Leave(object sender, EventArgs e)
        //{
        //    if (login.Text == "")
        //    {
        //        login.Text = "Write your email";
        //        login.ForeColor = Color.DimGray;
        //    }
        //}

        //private void registerlabel_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    register register = new register();
        //    register.Show();
        //}

        //private void login_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    _UserList = DBank.DeserializeUsers();

        //    if (login.Text == "Write your email" || password.Text == "")
        //    {
        //        MessageBox.Show("You haven`t filled any boxes. Please, check again.", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        int index = 0;
        //        foreach (User user in _UserList)
        //        {
        //            if (user.email == login.Text && user.password == password.Text)
        //            {
                        
        //                this.Hide();
        //                mainform mainform = new mainform();
        //                mainform.loginedUser = _UserList[index];
        //                mainform.Show();

        //                return;
        //            }
        //            index++;
        //        }

        //        MessageBox.Show("Incorrect login or password", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        password.Clear();
        //    }
        //}

        //private void checkpass_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkpass.Checked == true)
        //    {
        //        password.UseSystemPasswordChar = false;
        //    }
        //    else if (checkpass.Checked == false)
        //    {
        //        password.UseSystemPasswordChar = true;
        //    }
        //}
    }
}
