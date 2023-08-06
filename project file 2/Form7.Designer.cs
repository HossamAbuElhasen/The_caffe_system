
namespace project_file_2
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtshow = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Floder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter path";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(126, 46);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(364, 20);
            this.txt1.TabIndex = 2;
            this.txt1.Text = "E:\\\\cafe\\\\testFolder";
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(126, 196);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(364, 96);
            this.txtshow.TabIndex = 3;
            this.txtshow.Text = "";
            this.txtshow.TextChanged += new System.EventHandler(this.txtshow_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Floder);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.txtshow);
            this.groupBox1.Location = new System.Drawing.Point(130, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 357);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Tahoma", 16F);
            this.show.Location = new System.Drawing.Point(126, 152);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(161, 38);
            this.show.TabIndex = 4;
            this.show.Text = "show File";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Tahoma", 16F);
            this.create.Location = new System.Drawing.Point(126, 91);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(161, 38);
            this.create.TabIndex = 1;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 16F);
            this.Back.Location = new System.Drawing.Point(12, 411);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(161, 38);
            this.Back.TabIndex = 5;
            this.Back.Text = "<= Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Tahoma", 16F);
            this.Delete.Location = new System.Drawing.Point(329, 91);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 38);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Tahoma", 16F);
            this.clear.Location = new System.Drawing.Point(228, 298);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(161, 38);
            this.clear.TabIndex = 6;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Floder
            // 
            this.Floder.Font = new System.Drawing.Font("Tahoma", 16F);
            this.Floder.Location = new System.Drawing.Point(329, 152);
            this.Floder.Name = "Floder";
            this.Floder.Size = new System.Drawing.Size(161, 38);
            this.Floder.TabIndex = 7;
            this.Floder.Text = "show Folder";
            this.Floder.UseVisualStyleBackColor = true;
            this.Floder.Click += new System.EventHandler(this.Floder_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.RichTextBox txtshow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Floder;
    }
}