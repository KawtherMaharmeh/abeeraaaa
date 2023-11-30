namespace abeeraaaa
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
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(52, 70);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(87, 22);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "firstname";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(55, 178);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(83, 22);
            this.lastname.TabIndex = 1;
            this.lastname.Text = "lastname";
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(166, 70);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(143, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.TextChanged += new System.EventHandler(this.lbl1_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(166, 178);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(143, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.TextChanged += new System.EventHandler(this.lbl2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "swap";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox lbl1;
        private System.Windows.Forms.TextBox lbl2;
        private System.Windows.Forms.Button button1;
    }
}

