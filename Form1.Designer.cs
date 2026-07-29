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
            ((System.ComponentModel.ISupportInitialize)(this.rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseYear)).BeginInit();
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
            this.installCheck.Location = new System.Drawing.Point(120, 232);
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
            this.addbtn.Location = new System.Drawing.Point(121, 276);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(119, 28);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(973, 267);
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
            this.updatebtn.Location = new System.Drawing.Point(830, 267);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 332);
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
            ((System.ComponentModel.ISupportInitialize)(this.rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseYear)).EndInit();
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
    }
}

