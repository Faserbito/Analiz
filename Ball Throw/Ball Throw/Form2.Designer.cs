
namespace Ball_Throw
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_h = new System.Windows.Forms.TextBox();
            this.tb_skth = new System.Windows.Forms.TextBox();
            this.tb_skv = new System.Windows.Forms.TextBox();
            this.cb_th = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.b_accept = new System.Windows.Forms.Button();
            this.cb_wind = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рост человека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость броска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Направление броска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скорость ветра";
            // 
            // tb_h
            // 
            this.tb_h.Location = new System.Drawing.Point(165, 20);
            this.tb_h.Name = "tb_h";
            this.tb_h.Size = new System.Drawing.Size(100, 20);
            this.tb_h.TabIndex = 4;
            this.tb_h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_h_KeyPress);
            // 
            // tb_skth
            // 
            this.tb_skth.Location = new System.Drawing.Point(165, 60);
            this.tb_skth.Name = "tb_skth";
            this.tb_skth.Size = new System.Drawing.Size(100, 20);
            this.tb_skth.TabIndex = 5;
            this.tb_skth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_skth_KeyPress);
            // 
            // tb_skv
            // 
            this.tb_skv.Location = new System.Drawing.Point(165, 140);
            this.tb_skv.Name = "tb_skv";
            this.tb_skv.Size = new System.Drawing.Size(100, 20);
            this.tb_skv.TabIndex = 6;
            this.tb_skv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_skv_KeyPress);
            // 
            // cb_th
            // 
            this.cb_th.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_th.FormattingEnabled = true;
            this.cb_th.Location = new System.Drawing.Point(165, 100);
            this.cb_th.Name = "cb_th";
            this.cb_th.Size = new System.Drawing.Size(100, 21);
            this.cb_th.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(271, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "см";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(271, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "м/с";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(271, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "м/с";
            // 
            // b_accept
            // 
            this.b_accept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_accept.Location = new System.Drawing.Point(0, 217);
            this.b_accept.Name = "b_accept";
            this.b_accept.Size = new System.Drawing.Size(299, 34);
            this.b_accept.TabIndex = 11;
            this.b_accept.Text = "Готово";
            this.b_accept.UseVisualStyleBackColor = true;
            this.b_accept.Click += new System.EventHandler(this.b_accept_Click);
            // 
            // cb_wind
            // 
            this.cb_wind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_wind.FormattingEnabled = true;
            this.cb_wind.Location = new System.Drawing.Point(165, 180);
            this.cb_wind.Name = "cb_wind";
            this.cb_wind.Size = new System.Drawing.Size(100, 21);
            this.cb_wind.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Направление ветра";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(299, 251);
            this.Controls.Add(this.cb_wind);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.b_accept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_th);
            this.Controls.Add(this.tb_skv);
            this.Controls.Add(this.tb_skth);
            this.Controls.Add(this.tb_h);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Параметры броска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_h;
        private System.Windows.Forms.TextBox tb_skth;
        private System.Windows.Forms.TextBox tb_skv;
        private System.Windows.Forms.ComboBox cb_th;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_accept;
        private System.Windows.Forms.ComboBox cb_wind;
        private System.Windows.Forms.Label label8;
    }
}