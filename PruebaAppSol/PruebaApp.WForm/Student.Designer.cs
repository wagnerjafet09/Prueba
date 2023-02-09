﻿namespace PruebaApp.WForm
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreationD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreatioU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeleted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttmNew = new System.Windows.Forms.Button();
            this.bttmEdit = new System.Windows.Forms.Button();
            this.bttmDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.bttmSearch = new System.Windows.Forms.Button();
            this.bttmClean = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 46);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(389, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Students";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(190, 86);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(190, 132);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // txtCreationD
            // 
            this.txtCreationD.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreationD.Location = new System.Drawing.Point(190, 176);
            this.txtCreationD.Name = "txtCreationD";
            this.txtCreationD.Size = new System.Drawing.Size(182, 26);
            this.txtCreationD.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Creation Date:";
            // 
            // txtCreatioU
            // 
            this.txtCreatioU.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatioU.Location = new System.Drawing.Point(548, 86);
            this.txtCreatioU.Name = "txtCreatioU";
            this.txtCreatioU.Size = new System.Drawing.Size(182, 26);
            this.txtCreatioU.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Creation User:";
            // 
            // txtDeleted
            // 
            this.txtDeleted.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleted.Location = new System.Drawing.Point(548, 134);
            this.txtDeleted.Name = "txtDeleted";
            this.txtDeleted.Size = new System.Drawing.Size(182, 26);
            this.txtDeleted.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Deleted:";
            // 
            // bttmNew
            // 
            this.bttmNew.BackColor = System.Drawing.Color.Green;
            this.bttmNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttmNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttmNew.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmNew.ForeColor = System.Drawing.Color.White;
            this.bttmNew.Location = new System.Drawing.Point(600, 199);
            this.bttmNew.Name = "bttmNew";
            this.bttmNew.Size = new System.Drawing.Size(97, 31);
            this.bttmNew.TabIndex = 11;
            this.bttmNew.Text = "New";
            this.bttmNew.UseVisualStyleBackColor = false;
            // 
            // bttmEdit
            // 
            this.bttmEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttmEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttmEdit.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmEdit.ForeColor = System.Drawing.Color.White;
            this.bttmEdit.Location = new System.Drawing.Point(706, 199);
            this.bttmEdit.Name = "bttmEdit";
            this.bttmEdit.Size = new System.Drawing.Size(97, 31);
            this.bttmEdit.TabIndex = 12;
            this.bttmEdit.Text = "Edit";
            this.bttmEdit.UseVisualStyleBackColor = false;
            // 
            // bttmDelete
            // 
            this.bttmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttmDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttmDelete.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmDelete.ForeColor = System.Drawing.Color.White;
            this.bttmDelete.Location = new System.Drawing.Point(811, 199);
            this.bttmDelete.Name = "bttmDelete";
            this.bttmDelete.Size = new System.Drawing.Size(97, 31);
            this.bttmDelete.TabIndex = 13;
            this.bttmDelete.Text = "Delete";
            this.bttmDelete.UseVisualStyleBackColor = false;
            this.bttmDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(896, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student list_____________________________________________________________________" +
    "______________________________";
            // 
            // gridStudents
            // 
            this.gridStudents.BackgroundColor = System.Drawing.Color.White;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Location = new System.Drawing.Point(40, 307);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.Size = new System.Drawing.Size(893, 260);
            this.gridStudents.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 29);
            this.comboBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Search by:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(640, 273);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 26);
            this.textBox6.TabIndex = 18;
            // 
            // bttmSearch
            // 
            this.bttmSearch.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmSearch.Location = new System.Drawing.Point(828, 272);
            this.bttmSearch.Name = "bttmSearch";
            this.bttmSearch.Size = new System.Drawing.Size(105, 29);
            this.bttmSearch.TabIndex = 19;
            this.bttmSearch.Text = "Search";
            this.bttmSearch.UseVisualStyleBackColor = true;
            // 
            // bttmClean
            // 
            this.bttmClean.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmClean.Image = ((System.Drawing.Image)(resources.GetObject("bttmClean.Image")));
            this.bttmClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmClean.Location = new System.Drawing.Point(811, 86);
            this.bttmClean.Name = "bttmClean";
            this.bttmClean.Size = new System.Drawing.Size(105, 37);
            this.bttmClean.TabIndex = 20;
            this.bttmClean.Text = "Clean";
            this.bttmClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmClean.UseVisualStyleBackColor = true;
            this.bttmClean.Click += new System.EventHandler(this.bttmLimpiar_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 579);
            this.Controls.Add(this.bttmClean);
            this.Controls.Add(this.bttmSearch);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttmDelete);
            this.Controls.Add(this.bttmEdit);
            this.Controls.Add(this.bttmNew);
            this.Controls.Add(this.txtDeleted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatioU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCreationD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreationD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreatioU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttmNew;
        private System.Windows.Forms.Button bttmEdit;
        private System.Windows.Forms.Button bttmDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button bttmSearch;
        private System.Windows.Forms.Button bttmClean;
    }
}