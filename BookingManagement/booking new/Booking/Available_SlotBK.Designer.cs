
namespace Booking
{
    partial class Available_SlotBK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Available_SlotBK));
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.slotAstatus = new System.Windows.Forms.TextBox();
            this.slotAtxt = new System.Windows.Forms.TextBox();
            this.slotAbg = new System.Windows.Forms.Panel();
            this.slotBtxt = new System.Windows.Forms.TextBox();
            this.slotBbg = new System.Windows.Forms.Panel();
            this.slotBstatus = new System.Windows.Forms.TextBox();
            this.srchSlot = new System.Windows.Forms.TextBox();
            this.srchBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.slotAbg.SuspendLayout();
            this.slotBbg.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Yu Gothic Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(213, 24);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(379, 60);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Available Service Slots";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 106);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(698, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // slotAstatus
            // 
            this.slotAstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.slotAstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slotAstatus.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slotAstatus.Location = new System.Drawing.Point(26, 165);
            this.slotAstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slotAstatus.Name = "slotAstatus";
            this.slotAstatus.Size = new System.Drawing.Size(136, 43);
            this.slotAstatus.TabIndex = 1;
            this.slotAstatus.Text = "Available";
            this.slotAstatus.TextChanged += new System.EventHandler(this.slotAstatus_TextChanged);
            // 
            // slotAtxt
            // 
            this.slotAtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.slotAtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slotAtxt.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slotAtxt.Location = new System.Drawing.Point(14, 45);
            this.slotAtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slotAtxt.Name = "slotAtxt";
            this.slotAtxt.Size = new System.Drawing.Size(157, 73);
            this.slotAtxt.TabIndex = 0;
            this.slotAtxt.Text = "   A";
            this.slotAtxt.TextChanged += new System.EventHandler(this.slotAtxt_TextChanged);
            // 
            // slotAbg
            // 
            this.slotAbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.slotAbg.Controls.Add(this.slotAstatus);
            this.slotAbg.Controls.Add(this.slotAtxt);
            this.slotAbg.Location = new System.Drawing.Point(64, 253);
            this.slotAbg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slotAbg.Name = "slotAbg";
            this.slotAbg.Size = new System.Drawing.Size(179, 288);
            this.slotAbg.TabIndex = 18;
            this.slotAbg.Paint += new System.Windows.Forms.PaintEventHandler(this.slotAbg_Paint);
            // 
            // slotBtxt
            // 
            this.slotBtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.slotBtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slotBtxt.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slotBtxt.Location = new System.Drawing.Point(13, 45);
            this.slotBtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slotBtxt.Name = "slotBtxt";
            this.slotBtxt.Size = new System.Drawing.Size(147, 73);
            this.slotBtxt.TabIndex = 1;
            this.slotBtxt.Text = "   B";
            this.slotBtxt.TextChanged += new System.EventHandler(this.slotBtxt_TextChanged);
            // 
            // slotBbg
            // 
            this.slotBbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.slotBbg.Controls.Add(this.slotBstatus);
            this.slotBbg.Controls.Add(this.slotBtxt);
            this.slotBbg.Location = new System.Drawing.Point(304, 253);
            this.slotBbg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slotBbg.Name = "slotBbg";
            this.slotBbg.Size = new System.Drawing.Size(176, 288);
            this.slotBbg.TabIndex = 19;
            this.slotBbg.Paint += new System.Windows.Forms.PaintEventHandler(this.slotBbg_Paint);
            // 
            // slotBstatus
            // 
            this.slotBstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.slotBstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slotBstatus.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slotBstatus.Location = new System.Drawing.Point(18, 165);
            this.slotBstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slotBstatus.Name = "slotBstatus";
            this.slotBstatus.Size = new System.Drawing.Size(155, 43);
            this.slotBstatus.TabIndex = 2;
            this.slotBstatus.Text = "Unavailable";
            this.slotBstatus.TextChanged += new System.EventHandler(this.slotBstatus_TextChanged);
            // 
            // srchSlot
            // 
            this.srchSlot.Location = new System.Drawing.Point(420, 168);
            this.srchSlot.Name = "srchSlot";
            this.srchSlot.Size = new System.Drawing.Size(234, 27);
            this.srchSlot.TabIndex = 20;
            this.srchSlot.TextChanged += new System.EventHandler(this.srchSlot_TextChanged);
            // 
            // srchBtn
            // 
            this.srchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("srchBtn.BackgroundImage")));
            this.srchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.srchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchBtn.Location = new System.Drawing.Point(660, 166);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(35, 29);
            this.srchBtn.TabIndex = 21;
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(730, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 510);
            this.panel3.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 510);
            this.panel4.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(14, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 16);
            this.panel2.TabIndex = 80;
            // 
            // Available_SlotBK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.srchSlot);
            this.Controls.Add(this.slotAbg);
            this.Controls.Add(this.slotBbg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Available_SlotBK";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Available_SlotBK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.slotAbg.ResumeLayout(false);
            this.slotAbg.PerformLayout();
            this.slotBbg.ResumeLayout(false);
            this.slotBbg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox slotAstatus;
        private System.Windows.Forms.TextBox slotAtxt;
        private System.Windows.Forms.Panel slotAbg;
        private System.Windows.Forms.TextBox slotBtxt;
        private System.Windows.Forms.Panel slotBbg;
        private System.Windows.Forms.TextBox slotBstatus;
        private System.Windows.Forms.TextBox srchSlot;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}