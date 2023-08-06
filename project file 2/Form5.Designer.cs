
namespace project_file_2
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalry = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sarech = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.txtshow = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSalry);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Delete.Location = new System.Drawing.Point(400, 139);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 36);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Tahoma", 12F);
            this.update.Location = new System.Drawing.Point(400, 78);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 33);
            this.update.TabIndex = 7;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "salay :";
            // 
            // txtSalry
            // 
            this.txtSalry.Location = new System.Drawing.Point(102, 139);
            this.txtSalry.Name = "txtSalry";
            this.txtSalry.Size = new System.Drawing.Size(235, 20);
            this.txtSalry.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Add.Location = new System.Drawing.Point(400, 24);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 35);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add EMP";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(235, 20);
            this.txtID.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(155, 262);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 134);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.clear.Location = new System.Drawing.Point(351, 403);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(110, 36);
            this.clear.TabIndex = 9;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Tahoma", 12F);
            this.show.Location = new System.Drawing.Point(351, 221);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(110, 36);
            this.show.TabIndex = 10;
            this.show.Text = "show Emp";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(83, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "search";
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(37, 42);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(162, 20);
            this.searchID.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtshow);
            this.groupBox2.Controls.Add(this.sarech);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.searchID);
            this.groupBox2.Location = new System.Drawing.Point(553, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 203);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // sarech
            // 
            this.sarech.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sarech.Location = new System.Drawing.Point(62, 72);
            this.sarech.Name = "sarech";
            this.sarech.Size = new System.Drawing.Size(110, 36);
            this.sarech.TabIndex = 12;
            this.sarech.Text = "sarech";
            this.sarech.UseVisualStyleBackColor = true;
            this.sarech.Click += new System.EventHandler(this.sarech_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Back.Location = new System.Drawing.Point(5, 403);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(119, 45);
            this.Back.TabIndex = 12;
            this.Back.Text = "<= Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(23, 114);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(190, 73);
            this.txtshow.TabIndex = 13;
            this.txtshow.Text = "";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Employee page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalry;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sarech;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RichTextBox txtshow;
    }
}