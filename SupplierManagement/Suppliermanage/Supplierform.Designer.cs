namespace Suppliermanage
{
    partial class Supplierform
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
            this.sup1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sup2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sup1
            // 
            this.sup1.AutoSize = true;
            this.sup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup1.Location = new System.Drawing.Point(791, 9);
            this.sup1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sup1.Name = "sup1";
            this.sup1.Size = new System.Drawing.Size(324, 36);
            this.sup1.TabIndex = 0;
            this.sup1.Text = "Supplier Management";
            this.sup1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sup1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // sup2
            // 
            this.sup2.AutoSize = true;
            this.sup2.Location = new System.Drawing.Point(864, 45);
            this.sup2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sup2.Name = "sup2";
            this.sup2.Size = new System.Drawing.Size(175, 25);
            this.sup2.TabIndex = 2;
            this.sup2.Text = "Registeration Form";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-19, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 1085);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.BackgroundImage = global::Suppliermanage.Properties.Resources.settings;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(34, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 64);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.BackgroundImage = global::Suppliermanage.Properties.Resources.calendar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(34, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 64);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImage = global::Suppliermanage.Properties.Resources.email;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(34, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 64);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImage = global::Suppliermanage.Properties.Resources.home;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(34, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 64);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Supplierform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1896, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sup2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sup1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Supplierform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suppliermanage";
            this.Load += new System.EventHandler(this.suppliermanage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sup1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sup2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

