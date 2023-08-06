
namespace project_file_2
{
    partial class Form4
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
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtshow = new System.Windows.Forms.RichTextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.request = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.show = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtshow);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.request);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Tahoma", 16F);
            this.clear.Location = new System.Drawing.Point(194, 256);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 38);
            this.clear.TabIndex = 6;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "order Two :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "order one :";
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(120, 154);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(260, 96);
            this.txtshow.TabIndex = 3;
            this.txtshow.Text = "";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(133, 71);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(247, 20);
            this.txt2.TabIndex = 2;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(133, 19);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(247, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // request
            // 
            this.request.Font = new System.Drawing.Font("Tahoma", 16F);
            this.request.Location = new System.Drawing.Point(194, 110);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(120, 38);
            this.request.TabIndex = 0;
            this.request.Text = "Request";
            this.request.UseVisualStyleBackColor = true;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(462, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 264);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Tahoma", 16F);
            this.show.Location = new System.Drawing.Point(552, 3);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(150, 38);
            this.show.TabIndex = 6;
            this.show.Text = "show menu";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 16F);
            this.Back.Location = new System.Drawing.Point(7, 409);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(140, 38);
            this.Back.TabIndex = 7;
            this.Back.Text = "<= Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.show);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Request of Drink";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtshow;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button request;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button Back;
    }
}