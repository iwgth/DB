using System;
using System.Drawing;
using System.Windows.Forms;

namespace winf
{
    partial class accounts : Form
    {
        private LinkedList<User> _UserList { get; set; }

        public accounts()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            departament.BringToFront();

            _UserList = DBank.DeserializeUsers();
        }

        private void accounts_Load(object sender, EventArgs e)
        {
            name.Text = account.name;
            surname.Text = account.surname;
            patronymic.Text = account.patronymic;
            phone.Text = account.phone;
            email.Text = account.email;
            departament.Text = account.departament;
            position.Text = account.position;
            salary.Text = account.salary;
            picman.Text = account.avatar;

            email.ReadOnly = true;

            if (account.avatar == "")
            {
                picture.ImageLocation = "https://cdn4.iconfinder.com/data/icons/small-n-flat/24/user-alt-256.png";
            }
            else
            {
                picture.ImageLocation = account.avatar;
            }
        }
        public User account { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (picman.Text == "") // Write your URL picture path
            {
                MessageBox.Show("Write your path!", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            picture.ImageLocation = picman.Text;

            return;

        }

        private void save_Click(object sender, EventArgs e)
        {
            int changeUserIndex = 0;

            foreach (User user in _UserList)
            {
                if (account.email != user.email)
                {
                    changeUserIndex++;
                }

                if (account.email == user.email)
                {               
                    break;
                }
            }

            _UserList[changeUserIndex].name = name.Text;
            _UserList[changeUserIndex].surname = surname.Text;
            _UserList[changeUserIndex].patronymic = patronymic.Text;
            _UserList[changeUserIndex].phone = phone.Text;
            _UserList[changeUserIndex].departament = departament.Text;
            _UserList[changeUserIndex].position = position.Text;
            _UserList[changeUserIndex].salary = salary.Text;
            _UserList[changeUserIndex].avatar = picman.Text;

            if (name.Text == "" || surname.Text == "" || patronymic.Text == "" || phone.Text == "" ||
                email.Text == "" || position.Text == "" || salary.Text == "")
            {
                MessageBox.Show("You haven`t filled any boxes. Please, check again.", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DBank.SerializeUsers(_UserList);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mainform = new mainform();
            mainform.Show();
        }

        private void accounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picman_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            picman.SelectAll();
        }

        private void departament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 43 && number != 40 && number != 41)
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
    }
}
