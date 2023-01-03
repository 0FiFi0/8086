namespace Procesor8086
{
    partial class XCHG
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DX1_btn = new System.Windows.Forms.RadioButton();
            this.CX1_btn = new System.Windows.Forms.RadioButton();
            this.BX1_btn = new System.Windows.Forms.RadioButton();
            this.AX1_btn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.exec_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ax_value_box = new System.Windows.Forms.TextBox();
            this.bx_value_box = new System.Windows.Forms.TextBox();
            this.cx_value_box = new System.Windows.Forms.TextBox();
            this.dx_value_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AX2_btn = new System.Windows.Forms.RadioButton();
            this.BX2_btn = new System.Windows.Forms.RadioButton();
            this.CX2_btn = new System.Windows.Forms.RadioButton();
            this.DX2_btn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // DX1_btn
            // 
            this.DX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.DX1_btn.AutoSize = true;
            this.DX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DX1_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DX1_btn.Location = new System.Drawing.Point(159, 185);
            this.DX1_btn.Name = "DX1_btn";
            this.DX1_btn.Size = new System.Drawing.Size(54, 26);
            this.DX1_btn.TabIndex = 1;
            this.DX1_btn.TabStop = true;
            this.DX1_btn.Text = "DX";
            this.DX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DX1_btn.UseVisualStyleBackColor = true;
            this.DX1_btn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // CX1_btn
            // 
            this.CX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.CX1_btn.AutoSize = true;
            this.CX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CX1_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CX1_btn.Location = new System.Drawing.Point(159, 160);
            this.CX1_btn.Name = "CX1_btn";
            this.CX1_btn.Size = new System.Drawing.Size(53, 26);
            this.CX1_btn.TabIndex = 1;
            this.CX1_btn.TabStop = true;
            this.CX1_btn.Text = "CX";
            this.CX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CX1_btn.UseVisualStyleBackColor = true;
            this.CX1_btn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BX1_btn
            // 
            this.BX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.BX1_btn.AutoSize = true;
            this.BX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BX1_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BX1_btn.Location = new System.Drawing.Point(159, 135);
            this.BX1_btn.Name = "BX1_btn";
            this.BX1_btn.Size = new System.Drawing.Size(52, 26);
            this.BX1_btn.TabIndex = 1;
            this.BX1_btn.TabStop = true;
            this.BX1_btn.Text = "BX";
            this.BX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BX1_btn.UseVisualStyleBackColor = true;
            this.BX1_btn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // AX1_btn
            // 
            this.AX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX1_btn.AutoSize = true;
            this.AX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AX1_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AX1_btn.Location = new System.Drawing.Point(159, 110);
            this.AX1_btn.Name = "AX1_btn";
            this.AX1_btn.Size = new System.Drawing.Size(53, 26);
            this.AX1_btn.TabIndex = 1;
            this.AX1_btn.TabStop = true;
            this.AX1_btn.Text = "AX";
            this.AX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AX1_btn.UseVisualStyleBackColor = true;
            this.AX1_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(171, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // exec_btn
            // 
            this.exec_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exec_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exec_btn.ForeColor = System.Drawing.Color.Lavender;
            this.exec_btn.Location = new System.Drawing.Point(104, 235);
            this.exec_btn.Name = "exec_btn";
            this.exec_btn.Size = new System.Drawing.Size(96, 23);
            this.exec_btn.TabIndex = 1;
            this.exec_btn.Text = "EXECUTE";
            this.exec_btn.UseVisualStyleBackColor = false;
            this.exec_btn.Click += new System.EventHandler(this.exec_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(306, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "AX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(306, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "BX";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(306, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "CX";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(306, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "DX";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ax_value_box
            // 
            this.ax_value_box.Location = new System.Drawing.Point(353, 110);
            this.ax_value_box.Multiline = true;
            this.ax_value_box.Name = "ax_value_box";
            this.ax_value_box.ReadOnly = true;
            this.ax_value_box.Size = new System.Drawing.Size(34, 20);
            this.ax_value_box.TabIndex = 3;
            this.ax_value_box.TextChanged += new System.EventHandler(this.ax_value_box_TextChanged);
            // 
            // bx_value_box
            // 
            this.bx_value_box.Location = new System.Drawing.Point(353, 135);
            this.bx_value_box.Multiline = true;
            this.bx_value_box.Name = "bx_value_box";
            this.bx_value_box.ReadOnly = true;
            this.bx_value_box.Size = new System.Drawing.Size(34, 20);
            this.bx_value_box.TabIndex = 3;
            this.bx_value_box.TextChanged += new System.EventHandler(this.bx_value_box_TextChanged);
            // 
            // cx_value_box
            // 
            this.cx_value_box.Location = new System.Drawing.Point(353, 160);
            this.cx_value_box.Multiline = true;
            this.cx_value_box.Name = "cx_value_box";
            this.cx_value_box.ReadOnly = true;
            this.cx_value_box.Size = new System.Drawing.Size(34, 20);
            this.cx_value_box.TabIndex = 3;
            this.cx_value_box.TextChanged += new System.EventHandler(this.cx_value_box_TextChanged);
            // 
            // dx_value_box
            // 
            this.dx_value_box.Location = new System.Drawing.Point(353, 185);
            this.dx_value_box.Multiline = true;
            this.dx_value_box.Name = "dx_value_box";
            this.dx_value_box.ReadOnly = true;
            this.dx_value_box.Size = new System.Drawing.Size(34, 20);
            this.dx_value_box.TabIndex = 3;
            this.dx_value_box.TextChanged += new System.EventHandler(this.dx_value_box_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(310, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Value :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(159, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 44);
            this.label8.TabIndex = 6;
            this.label8.Text = "XCHG";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(217, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // AX2_btn
            // 
            this.AX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX2_btn.AutoSize = true;
            this.AX2_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AX2_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AX2_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AX2_btn.Location = new System.Drawing.Point(47, 108);
            this.AX2_btn.Name = "AX2_btn";
            this.AX2_btn.Size = new System.Drawing.Size(53, 26);
            this.AX2_btn.TabIndex = 1;
            this.AX2_btn.Text = "AX";
            this.AX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AX2_btn.UseVisualStyleBackColor = false;
            this.AX2_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // BX2_btn
            // 
            this.BX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.BX2_btn.AutoSize = true;
            this.BX2_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BX2_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BX2_btn.Location = new System.Drawing.Point(47, 133);
            this.BX2_btn.Name = "BX2_btn";
            this.BX2_btn.Size = new System.Drawing.Size(52, 26);
            this.BX2_btn.TabIndex = 1;
            this.BX2_btn.Text = "BX";
            this.BX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BX2_btn.UseVisualStyleBackColor = false;
            this.BX2_btn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // CX2_btn
            // 
            this.CX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.CX2_btn.AutoSize = true;
            this.CX2_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.CX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CX2_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CX2_btn.Location = new System.Drawing.Point(47, 160);
            this.CX2_btn.Name = "CX2_btn";
            this.CX2_btn.Size = new System.Drawing.Size(53, 26);
            this.CX2_btn.TabIndex = 1;
            this.CX2_btn.Text = "CX";
            this.CX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CX2_btn.UseVisualStyleBackColor = false;
            this.CX2_btn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // DX2_btn
            // 
            this.DX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.DX2_btn.AutoSize = true;
            this.DX2_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DX2_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DX2_btn.Location = new System.Drawing.Point(47, 185);
            this.DX2_btn.Name = "DX2_btn";
            this.DX2_btn.Size = new System.Drawing.Size(54, 26);
            this.DX2_btn.TabIndex = 1;
            this.DX2_btn.Text = "DX";
            this.DX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DX2_btn.UseVisualStyleBackColor = false;
            this.DX2_btn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // XCHG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.DX1_btn);
            this.Controls.Add(this.DX2_btn);
            this.Controls.Add(this.CX1_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BX1_btn);
            this.Controls.Add(this.CX2_btn);
            this.Controls.Add(this.AX1_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BX2_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AX2_btn);
            this.Controls.Add(this.dx_value_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cx_value_box);
            this.Controls.Add(this.bx_value_box);
            this.Controls.Add(this.ax_value_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exec_btn);
            this.Name = "XCHG";
            this.Size = new System.Drawing.Size(460, 310);
            this.Load += new System.EventHandler(this.MOV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton DX1_btn;
        private RadioButton CX1_btn;
        private RadioButton BX1_btn;
        private RadioButton AX1_btn;
        private Label label2;
        private Button exec_btn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ax_value_box;
        private TextBox bx_value_box;
        private TextBox cx_value_box;
        private TextBox dx_value_box;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label1;
        private RadioButton AX2_btn;
        private RadioButton BX2_btn;
        private RadioButton CX2_btn;
        private RadioButton DX2_btn;
    }
}
