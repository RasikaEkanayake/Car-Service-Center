namespace Supplierform
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
            this.lab1sup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1sup
            // 
            this.lab1sup.AutoSize = true;
            this.lab1sup.Location = new System.Drawing.Point(495, 9);
            this.lab1sup.Name = "lab1sup";
            this.lab1sup.Size = new System.Drawing.Size(146, 17);
            this.lab1sup.TabIndex = 0;
            this.lab1sup.Text = "Supplier Management";
            this.lab1sup.Click += new System.EventHandler(this.label1_Click);
            // 
            // Supplierform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1138, 602);
            this.Controls.Add(this.lab1sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplierform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.supplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1sup;
    }
}

