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
            // Supplierform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1896, 1102);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sup1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sup2;
    }
}

