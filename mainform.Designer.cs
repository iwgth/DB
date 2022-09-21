
namespace winf
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maxSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.avrgStat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minStat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maxStat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 104);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main screen";
            // 
            // table
            // 
            this.table.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.table.FormattingEnabled = true;
            this.table.HorizontalScrollbar = true;
            this.table.ItemHeight = 28;
            this.table.Location = new System.Drawing.Point(12, 113);
            this.table.Name = "table";
            this.table.ScrollAlwaysVisible = true;
            this.table.Size = new System.Drawing.Size(566, 368);
            this.table.TabIndex = 9;
            this.table.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.table_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 10;
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteUser.ForeColor = System.Drawing.Color.DimGray;
            this.deleteUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.deleteUser.Location = new System.Drawing.Point(601, 252);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(156, 37);
            this.deleteUser.TabIndex = 27;
            this.deleteUser.Text = "Delete employee";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addUser.ForeColor = System.Drawing.Color.DimGray;
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addUser.Location = new System.Drawing.Point(735, 305);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(156, 37);
            this.addUser.TabIndex = 28;
            this.addUser.Text = "Add employee";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // searchInput
            // 
            this.searchInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchInput.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchInput.Location = new System.Drawing.Point(706, 113);
            this.searchInput.Multiline = true;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(187, 37);
            this.searchInput.TabIndex = 30;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(601, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "User search";
            // 
            // minSalary
            // 
            this.minSalary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.minSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minSalary.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minSalary.Location = new System.Drawing.Point(735, 156);
            this.minSalary.Multiline = true;
            this.minSalary.Name = "minSalary";
            this.minSalary.Size = new System.Drawing.Size(158, 37);
            this.minSalary.TabIndex = 38;
            this.minSalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.minSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minSalary_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(601, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 37);
            this.label7.TabIndex = 39;
            this.label7.Text = "Minimal salary:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(601, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 37);
            this.label8.TabIndex = 41;
            this.label8.Text = "Maximal salary:";
            // 
            // maxSalary
            // 
            this.maxSalary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxSalary.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxSalary.Location = new System.Drawing.Point(735, 202);
            this.maxSalary.Multiline = true;
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(158, 37);
            this.maxSalary.TabIndex = 40;
            this.maxSalary.TextChanged += new System.EventHandler(this.maxSalary_TextChanged);
            this.maxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxSalary_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(601, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 37);
            this.label4.TabIndex = 43;
            this.label4.Text = "Average salary:";
            // 
            // avrgStat
            // 
            this.avrgStat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.avrgStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avrgStat.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.avrgStat.Location = new System.Drawing.Point(735, 400);
            this.avrgStat.Multiline = true;
            this.avrgStat.Name = "avrgStat";
            this.avrgStat.Size = new System.Drawing.Size(158, 37);
            this.avrgStat.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(601, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 37);
            this.label5.TabIndex = 45;
            this.label5.Text = "Minimal salary:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // minStat
            // 
            this.minStat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.minStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minStat.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minStat.Location = new System.Drawing.Point(735, 443);
            this.minStat.Multiline = true;
            this.minStat.Name = "minStat";
            this.minStat.Size = new System.Drawing.Size(158, 37);
            this.minStat.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(601, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 37);
            this.label6.TabIndex = 47;
            this.label6.Text = "Maximal salary: ";
            // 
            // maxStat
            // 
            this.maxStat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxStat.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxStat.Location = new System.Drawing.Point(735, 357);
            this.maxStat.Multiline = true;
            this.maxStat.Name = "maxStat";
            this.maxStat.Size = new System.Drawing.Size(158, 37);
            this.maxStat.TabIndex = 46;
            this.maxStat.TextChanged += new System.EventHandler(this.maxStat_TextChanged);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(909, 501);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxStat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minStat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avrgStat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel1);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainform_FormClosed);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox avrgStat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minStat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxStat;
    }
}