namespace Procesor8086
{
    partial class General
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XCHG_btn = new System.Windows.Forms.Button();
            this.MOV_btn = new System.Windows.Forms.Button();
            this.xchG1 = new Procesor8086.XCHG();
            this.moV1 = new Procesor8086.MOV();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 448);
            this.panel1.TabIndex = 14;
            // 
            // XCHG_btn
            // 
            this.XCHG_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.XCHG_btn.Location = new System.Drawing.Point(15, 183);
            this.XCHG_btn.Name = "XCHG_btn";
            this.XCHG_btn.Size = new System.Drawing.Size(75, 23);
            this.XCHG_btn.TabIndex = 0;
            this.XCHG_btn.Text = "XCHG";
            this.XCHG_btn.UseVisualStyleBackColor = true;
            this.XCHG_btn.Click += new System.EventHandler(this.XCHG_btn_Click);
            // 
            // MOV_btn
            // 
            this.MOV_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MOV_btn.Location = new System.Drawing.Point(15, 212);
            this.MOV_btn.Name = "MOV_btn";
            this.MOV_btn.Size = new System.Drawing.Size(75, 23);
            this.MOV_btn.TabIndex = 0;
            this.MOV_btn.Text = "MOV";
            this.MOV_btn.UseVisualStyleBackColor = true;
            this.MOV_btn.Click += new System.EventHandler(this.MOV_Click);
            // 
            // xchG1
            // 
            this.xchG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xchG1.Location = new System.Drawing.Point(107, 83);
            this.xchG1.Name = "xchG1";
            this.xchG1.Size = new System.Drawing.Size(462, 276);
            this.xchG1.TabIndex = 16;
            // 
            // moV1
            // 
            this.moV1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moV1.Location = new System.Drawing.Point(107, 83);
            this.moV1.Name = "moV1";
            this.moV1.Size = new System.Drawing.Size(462, 276);
            this.moV1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.MOV_btn);
            this.panel2.Controls.Add(this.XCHG_btn);
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 448);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 77);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(0, 349);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 99);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "8086";
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(677, 448);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moV1);
            this.Controls.Add(this.xchG1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "General";
            this.Text = "8086";
            this.Load += new System.EventHandler(this.General_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Button XCHG_btn;
        private Button MOV_btn;
        private XCHG xchG1;
        private MOV moV1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
    }
}