
namespace OutgoingFinance1
{
    partial class Employeesalary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topic
            // 
            this.topic.AutoSize = true;
            this.topic.Font = new System.Drawing.Font("Lato", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topic.Location = new System.Drawing.Point(824, 48);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(329, 50);
            this.topic.TabIndex = 6;
            this.topic.Text = "Employee Salary";
            this.topic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Employeesalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topic);
            this.Name = "Employeesalary";
            this.Size = new System.Drawing.Size(1792, 962);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic;
    }
}
