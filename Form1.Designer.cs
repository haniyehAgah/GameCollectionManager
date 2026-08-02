namespace gameCollectionManager
{
    partial class Form1
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
            this.genereCombo = new System.Windows.Forms.ComboBox();
            this.GameNameTXT = new System.Windows.Forms.TextBox();
            this.platformCombo = new System.Windows.Forms.ComboBox();
            this.installCheck = new System.Windows.Forms.CheckBox();
            this.rating = new System.Windows.Forms.NumericUpDown();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatebtn = new System.Windows.Forms.Button();
            this.releaseYear = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTXT = new System.Windows.Forms.TextBox();
            this.genreFilterCombo = new System.Windows.Forms.ComboBox();
            this.sortCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.GroupBox();
            this.newestLbl = new System.Windows.Forms.Label();
            this.averegeLbl = new System.Windows.Forms.Label();
            this.installedLbl = new System.Windows.Forms.Label();
            this.tatalLbl = new System.Windows.Forms.Label();
            this.favoriteCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseYear)).BeginInit();
            this.Statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // genereCombo
            // 
            this.genereCombo.FormattingEnabled = true;
            this.genereCombo.Location = new System.Drawing.Point(120, 54);
            this.genereCombo.Name = "genereCombo";
            this.genereCombo.Size = new System.Drawing.Size(121, 24);
            this.genereCombo.TabIndex = 0;
            // 
            // GameNameTXT
            // 
            this.GameNameTXT.Location = new System.Drawing.Point(120, 12);
            this.GameNameTXT.Multiline = true;
            this.GameNameTXT.Name = "GameNameTXT";
            this.GameNameTXT.Size = new System.Drawing.Size(120, 22);
            this.GameNameTXT.TabIndex = 1;
            // 
            // platformCombo
            // 
            this.platformCombo.FormattingEnabled = true;
            this.platformCombo.Location = new System.Drawing.Point(120, 99);
            this.platformCombo.Name = "platformCombo";
            this.platformCombo.Size = new System.Drawing.Size(121, 24);
            this.platformCombo.TabIndex = 2;
            // 
            // installCheck
            // 
            this.installCheck.AutoSize = true;
            this.installCheck.Location = new System.Drawing.Point(120, 226);
            this.installCheck.Name = "installCheck";
            this.installCheck.Size = new System.Drawing.Size(82, 21);
            this.installCheck.TabIndex = 4;
            this.installCheck.Text = "Installed";
            this.installCheck.UseVisualStyleBackColor = true;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(120, 188);
            this.rating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(120, 22);
            this.rating.TabIndex = 5;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(120, 308);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(119, 28);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(973, 236);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(97, 37);
            this.deletebtn.TabIndex = 8;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Game Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gener";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Platform";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Release Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rating";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 141);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(835, 236);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(101, 37);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "updating";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // releaseYear
            // 
            this.releaseYear.Location = new System.Drawing.Point(121, 145);
            this.releaseYear.Maximum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.releaseYear.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(120, 22);
            this.releaseYear.TabIndex = 3;
            this.releaseYear.Tag = "";
            this.releaseYear.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(897, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Filter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Search Game";
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(434, 42);
            this.searchTXT.Multiline = true;
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(120, 22);
            this.searchTXT.TabIndex = 21;
            this.searchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // genreFilterCombo
            // 
            this.genreFilterCombo.FormattingEnabled = true;
            this.genreFilterCombo.Location = new System.Drawing.Point(942, 40);
            this.genreFilterCombo.Name = "genreFilterCombo";
            this.genreFilterCombo.Size = new System.Drawing.Size(121, 24);
            this.genreFilterCombo.TabIndex = 24;
            this.genreFilterCombo.SelectedIndexChanged += new System.EventHandler(this.GenreFilterCombo_SelectedIndexChanged);
            // 
            // sortCombo
            // 
            this.sortCombo.FormattingEnabled = true;
            this.sortCombo.Location = new System.Drawing.Point(434, 12);
            this.sortCombo.Name = "sortCombo";
            this.sortCombo.Size = new System.Drawing.Size(121, 24);
            this.sortCombo.TabIndex = 25;
            this.sortCombo.SelectedIndexChanged += new System.EventHandler(this.SortCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sort by";
            // 
            // Statistics
            // 
            this.Statistics.Controls.Add(this.newestLbl);
            this.Statistics.Controls.Add(this.averegeLbl);
            this.Statistics.Controls.Add(this.installedLbl);
            this.Statistics.Controls.Add(this.tatalLbl);
            this.Statistics.Location = new System.Drawing.Point(15, 344);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(371, 114);
            this.Statistics.TabIndex = 27;
            this.Statistics.TabStop = false;
            // 
            // newestLbl
            // 
            this.newestLbl.AutoSize = true;
            this.newestLbl.Location = new System.Drawing.Point(183, 78);
            this.newestLbl.Name = "newestLbl";
            this.newestLbl.Size = new System.Drawing.Size(113, 17);
            this.newestLbl.TabIndex = 3;
            this.newestLbl.Text = "Newest Game : -";
            // 
            // averegeLbl
            // 
            this.averegeLbl.AutoSize = true;
            this.averegeLbl.Location = new System.Drawing.Point(25, 78);
            this.averegeLbl.Name = "averegeLbl";
            this.averegeLbl.Size = new System.Drawing.Size(126, 17);
            this.averegeLbl.TabIndex = 2;
            this.averegeLbl.Text = "Averege Rating : 0";
            // 
            // installedLbl
            // 
            this.installedLbl.AutoSize = true;
            this.installedLbl.Location = new System.Drawing.Point(183, 31);
            this.installedLbl.Name = "installedLbl";
            this.installedLbl.Size = new System.Drawing.Size(80, 17);
            this.installedLbl.TabIndex = 1;
            this.installedLbl.Text = "Installed : 0";
            // 
            // tatalLbl
            // 
            this.tatalLbl.AutoSize = true;
            this.tatalLbl.Location = new System.Drawing.Point(25, 31);
            this.tatalLbl.Name = "tatalLbl";
            this.tatalLbl.Size = new System.Drawing.Size(109, 17);
            this.tatalLbl.TabIndex = 0;
            this.tatalLbl.Text = "Tatal Games : 0";
            // 
            // favoriteCheck
            // 
            this.favoriteCheck.AutoSize = true;
            this.favoriteCheck.Location = new System.Drawing.Point(120, 267);
            this.favoriteCheck.Name = "favoriteCheck";
            this.favoriteCheck.Size = new System.Drawing.Size(91, 21);
            this.favoriteCheck.TabIndex = 28;
            this.favoriteCheck.Text = "Is favorite";
            this.favoriteCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 470);
            this.Controls.Add(this.favoriteCheck);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sortCombo);
            this.Controls.Add(this.genreFilterCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchTXT);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.installCheck);
            this.Controls.Add(this.releaseYear);
            this.Controls.Add(this.platformCombo);
            this.Controls.Add(this.GameNameTXT);
            this.Controls.Add(this.genereCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseYear)).EndInit();
            this.Statistics.ResumeLayout(false);
            this.Statistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genereCombo;
        private System.Windows.Forms.TextBox GameNameTXT;
        private System.Windows.Forms.ComboBox platformCombo;
        private System.Windows.Forms.CheckBox installCheck;
        private System.Windows.Forms.NumericUpDown rating;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.NumericUpDown releaseYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTXT;
        private System.Windows.Forms.ComboBox genreFilterCombo;
        private System.Windows.Forms.ComboBox sortCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Statistics;
        private System.Windows.Forms.Label newestLbl;
        private System.Windows.Forms.Label averegeLbl;
        private System.Windows.Forms.Label installedLbl;
        private System.Windows.Forms.Label tatalLbl;
        private System.Windows.Forms.CheckBox favoriteCheck;
    }
}

