﻿namespace PruebaApp.WinForm
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttmSettings = new System.Windows.Forms.Button();
            this.bttmUsers = new System.Windows.Forms.Button();
            this.bttmCourses = new System.Windows.Forms.Button();
            this.bttmInstructors = new System.Windows.Forms.Button();
            this.bttmStudents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.bttmSettings);
            this.panel1.Controls.Add(this.bttmUsers);
            this.panel1.Controls.Add(this.bttmCourses);
            this.panel1.Controls.Add(this.bttmInstructors);
            this.panel1.Controls.Add(this.bttmStudents);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 96);
            this.panel1.TabIndex = 1;
            // 
            // bttmSettings
            // 
            this.bttmSettings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttmSettings.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmSettings.Image = ((System.Drawing.Image)(resources.GetObject("bttmSettings.Image")));
            this.bttmSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmSettings.Location = new System.Drawing.Point(1085, 29);
            this.bttmSettings.Name = "bttmSettings";
            this.bttmSettings.Size = new System.Drawing.Size(62, 57);
            this.bttmSettings.TabIndex = 5;
            this.bttmSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmSettings.UseVisualStyleBackColor = false;
            this.bttmSettings.Click += new System.EventHandler(this.bttmSettings_Click);
            // 
            // bttmUsers
            // 
            this.bttmUsers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttmUsers.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmUsers.Image = ((System.Drawing.Image)(resources.GetObject("bttmUsers.Image")));
            this.bttmUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmUsers.Location = new System.Drawing.Point(870, 29);
            this.bttmUsers.Name = "bttmUsers";
            this.bttmUsers.Size = new System.Drawing.Size(135, 57);
            this.bttmUsers.TabIndex = 4;
            this.bttmUsers.Text = "Users";
            this.bttmUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmUsers.UseVisualStyleBackColor = false;
            this.bttmUsers.Click += new System.EventHandler(this.bttmUsers_Click);
            // 
            // bttmCourses
            // 
            this.bttmCourses.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttmCourses.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.bttmCourses.Image = ((System.Drawing.Image)(resources.GetObject("bttmCourses.Image")));
            this.bttmCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmCourses.Location = new System.Drawing.Point(724, 29);
            this.bttmCourses.Name = "bttmCourses";
            this.bttmCourses.Size = new System.Drawing.Size(140, 57);
            this.bttmCourses.TabIndex = 3;
            this.bttmCourses.Text = "Courses";
            this.bttmCourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmCourses.UseVisualStyleBackColor = false;
            // 
            // bttmInstructors
            // 
            this.bttmInstructors.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttmInstructors.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.bttmInstructors.Image = ((System.Drawing.Image)(resources.GetObject("bttmInstructors.Image")));
            this.bttmInstructors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmInstructors.Location = new System.Drawing.Point(527, 29);
            this.bttmInstructors.Name = "bttmInstructors";
            this.bttmInstructors.Size = new System.Drawing.Size(191, 57);
            this.bttmInstructors.TabIndex = 2;
            this.bttmInstructors.Text = "Instructors";
            this.bttmInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmInstructors.UseVisualStyleBackColor = false;
            // 
            // bttmStudents
            // 
            this.bttmStudents.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttmStudents.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.bttmStudents.Image = ((System.Drawing.Image)(resources.GetObject("bttmStudents.Image")));
            this.bttmStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmStudents.Location = new System.Drawing.Point(366, 29);
            this.bttmStudents.Name = "bttmStudents";
            this.bttmStudents.Size = new System.Drawing.Size(155, 57);
            this.bttmStudents.TabIndex = 1;
            this.bttmStudents.Text = "Students";
            this.bttmStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmStudents.UseVisualStyleBackColor = false;
            this.bttmStudents.Click += new System.EventHandler(this.bttmStudents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "LTM SCHOOL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(485, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario: Admin123";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 643);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttmStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttmUsers;
        private System.Windows.Forms.Button bttmCourses;
        private System.Windows.Forms.Button bttmInstructors;
        private System.Windows.Forms.Button bttmSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}