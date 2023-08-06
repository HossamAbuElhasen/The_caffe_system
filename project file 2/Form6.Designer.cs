
namespace project_file_2
{
    partial class Form6
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
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.txtsh = new System.Windows.Forms.RichTextBox();
            this.time = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Back.Location = new System.Drawing.Point(3, 405);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(157, 43);
            this.Back.TabIndex = 0;
            this.Back.Text = "<= Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "complaints";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(259, 145);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(355, 96);
            this.txtpath.TabIndex = 3;
            this.txtpath.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(144, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "please , If you have any problem or opinion create your file to write it";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Tahoma", 14F);
            this.create.Location = new System.Drawing.Point(360, 247);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(157, 43);
            this.create.TabIndex = 6;
            this.create.Text = "send";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // txtsh
            // 
            this.txtsh.Location = new System.Drawing.Point(259, 389);
            this.txtsh.Name = "txtsh";
            this.txtsh.Size = new System.Drawing.Size(355, 59);
            this.txtsh.TabIndex = 8;
            this.txtsh.Text = "";
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Tahoma", 14F);
            this.time.Location = new System.Drawing.Point(303, 330);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(269, 53);
            this.time.TabIndex = 7;
            this.time.Text = "show the time of complaints ";
            this.time.UseVisualStyleBackColor = true;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsh);
            this.Controls.Add(this.time);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.RichTextBox txtsh;
        private System.Windows.Forms.Button time;
    }
}