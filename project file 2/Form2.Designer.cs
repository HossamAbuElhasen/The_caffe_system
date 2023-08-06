
namespace project_file_2
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDrink = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.txtDrink);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Location = new System.Drawing.Point(151, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "cost :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(63, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "drink :";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Tahoma", 14F);
            this.delete.Location = new System.Drawing.Point(332, 175);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 41);
            this.delete.TabIndex = 6;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Tahoma", 14F);
            this.update.Location = new System.Drawing.Point(186, 175);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(140, 41);
            this.update.TabIndex = 5;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Add.Location = new System.Drawing.Point(31, 175);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(140, 41);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num_drink  :";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(197, 118);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(263, 20);
            this.txtCost.TabIndex = 2;
            // 
            // txtDrink
            // 
            this.txtDrink.Location = new System.Drawing.Point(197, 66);
            this.txtDrink.Name = "txtDrink";
            this.txtDrink.Size = new System.Drawing.Size(263, 20);
            this.txtDrink.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(197, 20);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(263, 20);
            this.txtNum.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(163, 284);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(483, 121);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Tahoma", 14F);
            this.clear.Location = new System.Drawing.Point(348, 411);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(140, 41);
            this.clear.TabIndex = 9;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Tahoma", 14F);
            this.back.Location = new System.Drawing.Point(2, 411);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(140, 41);
            this.back.TabIndex = 10;
            this.back.Text = " <= back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Tahoma", 14F);
            this.show.Location = new System.Drawing.Point(348, 239);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(140, 41);
            this.show.TabIndex = 9;
            this.show.Text = "show menu";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.back);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "mange of menu Drink";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDrink;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button show;
    }
}