
namespace Ball_Throw
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.НовыйБросокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p_ball = new System.Windows.Forms.PictureBox();
            this.p_bp = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_bp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.НовыйБросокToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(784, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // НовыйБросокToolStripMenuItem
            // 
            this.НовыйБросокToolStripMenuItem.Name = "НовыйБросокToolStripMenuItem";
            this.НовыйБросокToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.НовыйБросокToolStripMenuItem.Text = "Новый бросок";
            this.НовыйБросокToolStripMenuItem.Click += new System.EventHandler(this.НовыйБросокToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(187, 29);
            this.сохранитьToolStripMenuItem.Text = "Сохранить данные";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // p_ball
            // 
            this.p_ball.BackColor = System.Drawing.Color.Transparent;
            this.p_ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_ball.ErrorImage = null;
            this.p_ball.Image = ((System.Drawing.Image)(resources.GetObject("p_ball.Image")));
            this.p_ball.Location = new System.Drawing.Point(210, 209);
            this.p_ball.Name = "p_ball";
            this.p_ball.Size = new System.Drawing.Size(30, 30);
            this.p_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_ball.TabIndex = 1;
            this.p_ball.TabStop = false;
            this.p_ball.Visible = false;
            // 
            // p_bp
            // 
            this.p_bp.BackColor = System.Drawing.Color.Transparent;
            this.p_bp.Cursor = System.Windows.Forms.Cursors.Default;
            this.p_bp.Image = ((System.Drawing.Image)(resources.GetObject("p_bp.Image")));
            this.p_bp.Location = new System.Drawing.Point(30, 209);
            this.p_bp.Name = "p_bp";
            this.p_bp.Size = new System.Drawing.Size(150, 300);
            this.p_bp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_bp.TabIndex = 2;
            this.p_bp.TabStop = false;
            this.p_bp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.p_ball);
            this.Controls.Add(this.p_bp);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_bp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem НовыйБросокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox p_ball;
        private System.Windows.Forms.PictureBox p_bp;
    }
}

