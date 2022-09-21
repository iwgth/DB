using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace winf
{
    public partial class register : Form
    {
        private LinkedList<User> _UserList { get; set; }

        public register()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            
            departament.BringToFront();

            _UserList = DBank.DeserializeUsers();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = emailRegex.Match(email.Text);

            if (name.Text == "" || surname.Text == "" || patronymic.Text == "" || phone.Text == "" ||
                email.Text == "" || position.Text == "" || departament.Text == "" || salary.Text == "")
            {
                MessageBox.Show("You haven`t filled any boxes. Please, check again.", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!match.Success)
            {
                MessageBox.Show("Email is incorect", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User newUser = new User();

                newUser.name = name.Text;
                newUser.surname = surname.Text;
                newUser.patronymic = patronymic.Text;
                newUser.phone = phone.Text;
                newUser.email = email.Text;
                newUser.departament = departament.Text;
                newUser.position = position.Text;
                newUser.salary = salary.Text;
                newUser.avatar = "";

                var md5 = MD5.Create();
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(newUser.email));
                newUser.ID = Convert.ToBase64String(hash);

                foreach (User user in _UserList)
                {
                   if (newUser.email == user.email)
                    {
                        MessageBox.Show("This user has been already registered!", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        email.Clear();

                        return; 
                    }
                }

                _UserList.Push(newUser);
                DBank.SerializeUsers(_UserList);
                
                MessageBox.Show("New employee have been registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                mainform mainform = new mainform();
                mainform.Show();
            }
        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mainform = new mainform();
            mainform.Show();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 43 && number != 40 && number != 41) 
            {
                e.Handled = true;
            }
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;

        }

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void patronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void position_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void departament2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
