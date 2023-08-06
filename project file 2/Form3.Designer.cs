
namespace project_file_2
{
    partial class Form3
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
            this.button3 = new System.Windows.Forms.Button();
            this.Feedback = new System.Windows.Forms.Button();
            this.EMP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Feedback);
            this.groupBox1.Controls.Add(this.EMP);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(113, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button3.Location = new System.Drawing.Point(250, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "create Floder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Feedback
            // 
            this.Feedback.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Feedback.Location = new System.Drawing.Point(6, 226);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(204, 56);
            this.Feedback.TabIndex = 3;
            this.Feedback.Text = "complaints";
            this.Feedback.UseVisualStyleBackColor = true;
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // EMP
            // 
            this.EMP.Font = new System.Drawing.Font("Tahoma", 14F);
            this.EMP.Location = new System.Drawing.Point(129, 124);
            this.EMP.Name = "EMP";
            this.EMP.Size = new System.Drawing.Size(204, 56);
            this.EMP.TabIndex = 2;
            this.EMP.Text = "The Employee";
            this.EMP.UseVisualStyleBackColor = true;
            this.EMP.Click += new System.EventHandler(this.EMP_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button2.Location = new System.Drawing.Point(271, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "invols";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button1.Location = new System.Drawing.Point(18, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "The menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Back.Location = new System.Drawing.Point(3, 393);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(204, 56);
            this.Back.TabIndex = 4;
            this.Back.Text = "<= Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "select";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Feedback;
        private System.Windows.Forms.Button EMP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button3;
    }
}