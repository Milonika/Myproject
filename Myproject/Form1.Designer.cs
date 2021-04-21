namespace Myproject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Reactangle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(112, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.Line);
            this.panel2.Controls.Add(this.Triangle);
            this.panel2.Controls.Add(this.Circle);
            this.panel2.Controls.Add(this.Reactangle);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 426);
            this.panel2.TabIndex = 1;
            // 
            // Line
            // 
            this.Line.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line.Location = new System.Drawing.Point(13, 270);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(65, 57);
            this.Line.TabIndex = 3;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Triangle
            // 
            this.Triangle.Image = global::Myproject.Properties.Resources.df;
            this.Triangle.Location = new System.Drawing.Point(13, 196);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(65, 68);
            this.Triangle.TabIndex = 2;
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Circle
            // 
            this.Circle.Image = global::Myproject.Properties.Resources._205_2051215_bluecircle_circle_blue_trend_glowblue_glow_trends_blue;
            this.Circle.Location = new System.Drawing.Point(13, 123);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(65, 67);
            this.Circle.TabIndex = 1;
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Reactangle
            // 
            this.Reactangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reactangle.Image = global::Myproject.Properties.Resources._9369366693_stickermin_yapfiles_ru;
            this.Reactangle.Location = new System.Drawing.Point(13, 56);
            this.Reactangle.Name = "Reactangle";
            this.Reactangle.Size = new System.Drawing.Size(65, 61);
            this.Reactangle.TabIndex = 0;
            this.Reactangle.UseVisualStyleBackColor = true;
            this.Reactangle.Click += new System.EventHandler(this.Reactangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Reactangle;
    }
}

