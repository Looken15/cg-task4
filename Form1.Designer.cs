
namespace task4
{
    partial class clear_button
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.point_button = new System.Windows.Forms.Button();
            this.edge_button = new System.Windows.Forms.Button();
            this.polygon_button = new System.Windows.Forms.Button();
            this.clear_butt = new System.Windows.Forms.Button();
            this.origin_button = new System.Windows.Forms.Button();
            this.rotate_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1249, 672);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // point_button
            // 
            this.point_button.Location = new System.Drawing.Point(1256, 34);
            this.point_button.Margin = new System.Windows.Forms.Padding(4);
            this.point_button.Name = "point_button";
            this.point_button.Size = new System.Drawing.Size(168, 28);
            this.point_button.TabIndex = 1;
            this.point_button.Text = "Точка";
            this.point_button.UseVisualStyleBackColor = true;
            this.point_button.Click += new System.EventHandler(this.point_button_Click);
            // 
            // edge_button
            // 
            this.edge_button.Location = new System.Drawing.Point(1256, 70);
            this.edge_button.Margin = new System.Windows.Forms.Padding(4);
            this.edge_button.Name = "edge_button";
            this.edge_button.Size = new System.Drawing.Size(168, 28);
            this.edge_button.TabIndex = 2;
            this.edge_button.Text = "Ребро";
            this.edge_button.UseVisualStyleBackColor = true;
            this.edge_button.Click += new System.EventHandler(this.edge_button_Click);
            // 
            // polygon_button
            // 
            this.polygon_button.Location = new System.Drawing.Point(1256, 106);
            this.polygon_button.Margin = new System.Windows.Forms.Padding(4);
            this.polygon_button.Name = "polygon_button";
            this.polygon_button.Size = new System.Drawing.Size(168, 28);
            this.polygon_button.TabIndex = 3;
            this.polygon_button.Text = "Полигон";
            this.polygon_button.UseVisualStyleBackColor = true;
            this.polygon_button.Click += new System.EventHandler(this.polygon_button_Click);
            // 
            // clear_butt
            // 
            this.clear_butt.Location = new System.Drawing.Point(1256, 632);
            this.clear_butt.Margin = new System.Windows.Forms.Padding(4);
            this.clear_butt.Name = "clear_butt";
            this.clear_butt.Size = new System.Drawing.Size(168, 28);
            this.clear_butt.TabIndex = 4;
            this.clear_butt.Text = "Очистить";
            this.clear_butt.UseVisualStyleBackColor = true;
            this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
            // 
            // origin_button
            // 
            this.origin_button.Location = new System.Drawing.Point(1259, 193);
            this.origin_button.Margin = new System.Windows.Forms.Padding(4);
            this.origin_button.Name = "origin_button";
            this.origin_button.Size = new System.Drawing.Size(168, 28);
            this.origin_button.TabIndex = 5;
            this.origin_button.Text = "Якорь";
            this.origin_button.UseVisualStyleBackColor = true;
            this.origin_button.Click += new System.EventHandler(this.origin_button_Click);
            // 
            // rotate_button
            // 
            this.rotate_button.Location = new System.Drawing.Point(1259, 356);
            this.rotate_button.Margin = new System.Windows.Forms.Padding(4);
            this.rotate_button.Name = "rotate_button";
            this.rotate_button.Size = new System.Drawing.Size(168, 28);
            this.rotate_button.TabIndex = 6;
            this.rotate_button.Text = "Поворот";
            this.rotate_button.UseVisualStyleBackColor = true;
            this.rotate_button.Click += new System.EventHandler(this.rotate_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1294, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clear_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 673);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rotate_button);
            this.Controls.Add(this.origin_button);
            this.Controls.Add(this.clear_butt);
            this.Controls.Add(this.polygon_button);
            this.Controls.Add(this.edge_button);
            this.Controls.Add(this.point_button);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "clear_button";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button point_button;
        private System.Windows.Forms.Button edge_button;
        private System.Windows.Forms.Button polygon_button;
        private System.Windows.Forms.Button clear_butt;
        private System.Windows.Forms.Button origin_button;
        private System.Windows.Forms.Button rotate_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

