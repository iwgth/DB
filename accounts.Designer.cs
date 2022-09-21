
namespace winf
{
    partial class accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picman = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.departament = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 104);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "User information ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(326, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 18;
            // 
            // picman
            // 
            this.picman.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picman.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.picman.Location = new System.Drawing.Point(127, 530);
            this.picman.Multiline = true;
            this.picman.Name = "picman";
            this.picman.Size = new System.Drawing.Size(309, 37);
            this.picman.TabIndex = 21;
            this.picman.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picman_MouseDoubleClick);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.DimGray;
            this.picture.Location = new System.Drawing.Point(518, 114);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(426, 350);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 22;
            this.picture.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(481, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Get image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.Color.DimGray;
            this.save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.save.Location = new System.Drawing.Point(769, 529);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(243, 38);
            this.save.TabIndex = 24;
            this.save.Text = "Save information";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.ForeColor = System.Drawing.Color.DimGray;
            this.Back.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Back.Location = new System.Drawing.Point(978, 110);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(63, 37);
            this.Back.TabIndex = 25;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(13, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 37);
            this.label7.TabIndex = 35;
            this.label7.Text = "Picture link:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(13, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "Position:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(13, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(13, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 37);
            this.label4.TabIndex = 32;
            this.label4.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(13, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 37);
            this.label8.TabIndex = 31;
            this.label8.Text = "Patronymic:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(13, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 37);
            this.label9.TabIndex = 30;
            this.label9.Text = "Surname:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(13, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 37);
            this.label10.TabIndex = 29;
            this.label10.Text = "Name:";
            // 
            // position
            // 
            this.position.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.position.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.position.Location = new System.Drawing.Point(94, 427);
            this.position.Multiline = true;
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(342, 37);
            this.position.TabIndex = 42;
            this.position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.position_KeyPress);
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(82, 272);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(354, 37);
            this.phone.TabIndex = 41;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salary.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary.Location = new System.Drawing.Point(80, 479);
            this.salary.Multiline = true;
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(356, 37);
            this.salary.TabIndex = 40;
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            // 
            // patronymic
            // 
            this.patronymic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.patronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patronymic.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patronymic.Location = new System.Drawing.Point(121, 219);
            this.patronymic.Multiline = true;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(315, 37);
            this.patronymic.TabIndex = 39;
            this.patronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patronymic_KeyPress);
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surname.Location = new System.Drawing.Point(101, 166);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(335, 37);
            this.surname.TabIndex = 38;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_KeyPress);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(76, 114);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(360, 37);
            this.name.TabIndex = 37;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(73, 324);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(363, 37);
            this.email.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(13, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 37);
            this.label11.TabIndex = 43;
            this.label11.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(13, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 37);
            this.label3.TabIndex = 44;
            this.label3.Text = "Departament:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(133, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 37);
            this.label12.TabIndex = 46;
            // 
            // departament
            // 
            this.departament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departament.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departament.FormattingEnabled = true;
            this.departament.Items.AddRange(new object[] {
            "Strategic Alignment",
            "Business Engagement ",
            "It Projects",
            "IT Maintenance",
            "IT Operation",
            "IT Management"});
            this.departament.Location = new System.Drawing.Point(133, 375);
            this.departament.Name = "departament";
            this.departament.Size = new System.Drawing.Size(303, 36);
            this.departament.TabIndex = 45;
            this.departament.SelectedIndexChanged += new System.EventHandler(this.departament_SelectedIndexChanged);
            // 
            // accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1041, 612);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.departament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.position);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.picman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "accounts";
            this.Text = "accounts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.accounts_FormClosed);
            this.Load += new System.EventHandler(this.accounts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox picman;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox departament;
    }
}