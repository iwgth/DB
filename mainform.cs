using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace winf
{
    partial class mainform : Form
    {
        private LinkedList<User> _UserList { get; set; }
        private List<User> UserDictionary { get; set; }

        public mainform()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            _UserList = DBank.DeserializeUsers();

            UserDictionary = new List<User>();

            foreach (User user in _UserList)
            {
                table.Items.Add(user.stringToShowMainform());
                UserDictionary.Add(user);
            }

            minStat.ReadOnly = true;
            avrgStat.ReadOnly = true;
            maxStat.ReadOnly = true;

        }

        private void mainform_Load(object sender, EventArgs e)
        {
        
        }

        private void table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.table.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                this.Hide();
                accounts accounts = new accounts();
                accounts.account = UserDictionary[index];
                accounts.Show();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (table.SelectedIndex < table.Items.Count && table.SelectedIndex >= 0)
            {
                _UserList.Remove(table.SelectedIndex);
                UserDictionary.RemoveAt(table.SelectedIndex);
                table.Items.RemoveAt(table.SelectedIndex);

                DBank.SerializeUsers(_UserList);
            }
            else
            {
                MessageBox.Show("You have not selected an employee", "Error allert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register = new register();
            register.Show();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            var criteria = searchInput.Text;

            LinkedList<User> foundUsers = new LinkedList<User>();

            foreach (User user in _UserList)
            {
                int salaryValue = Convert.ToInt32(user.salary);
                int minSalaryValue = minSalary.Text != "" ? Convert.ToInt32(minSalary.Text) : -1;
                int maxSalaryValue = maxSalary.Text != "" ? Convert.ToInt32(maxSalary.Text) : -1;

                //int minSalaryValue = 0;

                //if (minSalary.Text != "")
                //    minSalaryValue = Convert.ToInt32(minSalary.Text);
                //else
                //    minSalaryValue = -1;

                if (user.ID.Contains(criteria) ||
                    user.name.Contains(criteria) ||
                    user.surname.Contains(criteria) ||
                    user.patronymic.Contains(criteria) ||
                    user.phone.Contains(criteria) ||
                    user.email.Contains(criteria) ||
                    user.position.Contains(criteria) ||
                    user.departament.Contains(criteria) ||
                    user.salary.Contains(criteria) ||
                    user.avatar.Contains(criteria))
                {
                    if (minSalaryValue == -1 && maxSalaryValue == -1)
                    {
                        foundUsers.Push(user);
                    }
                    else if (minSalaryValue == -1)
                    {
                        if (salaryValue <= maxSalaryValue)
                        {
                            foundUsers.Push(user);
                        }
                    }
                    else if (maxSalaryValue == -1)
                    {
                        if (salaryValue >= minSalaryValue)
                        {
                            foundUsers.Push(user);
                        }
                    }
                    else if (minSalaryValue != -1 && maxSalaryValue != -1)
                    {
                        if (salaryValue >= minSalaryValue && salaryValue <= maxSalaryValue)
                        {
                            foundUsers.Push(user);
                        }
                    }
                }
            }

            table.Items.Clear();
            UserDictionary.Clear();


            int sum = 0;
            int min = foundUsers.Count != 0 ? Convert.ToInt32(foundUsers[0].salary) : -1;
            int max = foundUsers.Count != 0 ? Convert.ToInt32(foundUsers[0].salary) : -1;

            if (foundUsers.Count != 0)
            {
                foreach (User user in foundUsers)
                {
                    table.Items.Add(user.stringToShowMainform());
                    UserDictionary.Add(user);

                    int userSalary = Convert.ToInt32(user.salary);
                    sum += userSalary;

                    if (min < userSalary)
                        min = userSalary;

                    if (max > userSalary)
                        max = userSalary;
                }
            }


            int avrg = foundUsers.Count != 0 ? sum / foundUsers.Count : -1;

            minStat.Text = min != -1 ? min.ToString() : "";
            maxStat.Text = max != -1 ? max.ToString() : "";
            avrgStat.Text = avrg != -1 ? avrg.ToString() : "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchInput_TextChanged(this, new EventArgs());
        }

        private void maxSalary_TextChanged(object sender, EventArgs e)
        {
            searchInput_TextChanged(this, new EventArgs());
        }

        private void minSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
              char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void maxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maxStat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
