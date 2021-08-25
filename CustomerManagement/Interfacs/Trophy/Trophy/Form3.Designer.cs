namespace Trophy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pEmail = new System.Windows.Forms.Label();
            this.pContactNumber = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pCustomerName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pcustomerID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnpSave = new System.Windows.Forms.Button();
            this.btnpUpdate = new System.Windows.Forms.Button();
            this.btnpDelete = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 60);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(753, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 46);
            this.button8.TabIndex = 19;
            this.button8.Text = "x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Profile";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monthly Service Count";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pEmail
            // 
            this.pEmail.AutoSize = true;
            this.pEmail.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pEmail.Location = new System.Drawing.Point(65, 389);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(46, 20);
            this.pEmail.TabIndex = 8;
            this.pEmail.Text = "Email";
            // 
            // pContactNumber
            // 
            this.pContactNumber.AutoSize = true;
            this.pContactNumber.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pContactNumber.Location = new System.Drawing.Point(65, 340);
            this.pContactNumber.Name = "pContactNumber";
            this.pContactNumber.Size = new System.Drawing.Size(122, 20);
            this.pContactNumber.TabIndex = 6;
            this.pContactNumber.Text = "Contact Number";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(249, 271);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(481, 63);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pAddress
            // 
            this.pAddress.AutoSize = true;
            this.pAddress.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAddress.Location = new System.Drawing.Point(65, 289);
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(63, 20);
            this.pAddress.TabIndex = 4;
            this.pAddress.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(249, 238);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(481, 27);
            this.textBox2.TabIndex = 3;
            // 
            // pCustomerName
            // 
            this.pCustomerName.AutoSize = true;
            this.pCustomerName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCustomerName.Location = new System.Drawing.Point(65, 245);
            this.pCustomerName.Name = "pCustomerName";
            this.pCustomerName.Size = new System.Drawing.Size(119, 20);
            this.pCustomerName.TabIndex = 2;
            this.pCustomerName.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, -39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pcustomerID
            // 
            this.pcustomerID.AutoSize = true;
            this.pcustomerID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcustomerID.ForeColor = System.Drawing.Color.Black;
            this.pcustomerID.Location = new System.Drawing.Point(65, 198);
            this.pcustomerID.Name = "pcustomerID";
            this.pcustomerID.Size = new System.Drawing.Size(101, 21);
            this.pcustomerID.TabIndex = 0;
            this.pcustomerID.Text = "Customer ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(249, 198);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(481, 27);
            this.textBox8.TabIndex = 18;
            // 
            // btnpSave
            // 
            this.btnpSave.BackColor = System.Drawing.Color.Green;
            this.btnpSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpSave.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpSave.ForeColor = System.Drawing.Color.White;
            this.btnpSave.Location = new System.Drawing.Point(236, 526);
            this.btnpSave.Name = "btnpSave";
            this.btnpSave.Size = new System.Drawing.Size(130, 43);
            this.btnpSave.TabIndex = 19;
            this.btnpSave.Text = "Save";
            this.btnpSave.UseVisualStyleBackColor = false;
            // 
            // btnpUpdate
            // 
            this.btnpUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnpUpdate.FlatAppearance.BorderSize = 0;
            this.btnpUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpUpdate.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpUpdate.ForeColor = System.Drawing.Color.White;
            this.btnpUpdate.Location = new System.Drawing.Point(69, 526);
            this.btnpUpdate.Name = "btnpUpdate";
            this.btnpUpdate.Size = new System.Drawing.Size(132, 41);
            this.btnpUpdate.TabIndex = 20;
            this.btnpUpdate.Text = "Update";
            this.btnpUpdate.UseVisualStyleBackColor = false;
            // 
            // btnpDelete
            // 
            this.btnpDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpDelete.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpDelete.ForeColor = System.Drawing.Color.White;
            this.btnpDelete.Location = new System.Drawing.Point(561, 528);
            this.btnpDelete.Name = "btnpDelete";
            this.btnpDelete.Size = new System.Drawing.Size(169, 41);
            this.btnpDelete.TabIndex = 21;
            this.btnpDelete.Text = "Delete All Records";
            this.btnpDelete.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(249, 342);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(481, 27);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(249, 382);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(481, 27);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(249, 430);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(481, 27);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(249, 476);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(481, 27);
            this.textBox7.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 581);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnpDelete);
            this.Controls.Add(this.btnpUpdate);
            this.Controls.Add(this.btnpSave);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pAddress);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pContactNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pEmail;
        private System.Windows.Forms.Label pContactNumber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label pAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label pCustomerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pcustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnpSave;
        private System.Windows.Forms.Button btnpUpdate;
        private System.Windows.Forms.Button btnpDelete;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}