
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
            this.rotate_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dx_shift_textbox = new System.Windows.Forms.TextBox();
            this.dy_shift_textbox = new System.Windows.Forms.TextBox();
            this.shift_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kx_scale_textbox = new System.Windows.Forms.TextBox();
            this.ky_scale_textbox = new System.Windows.Forms.TextBox();
            this.scale_button = new System.Windows.Forms.Button();
            this.edge_rotate_button = new System.Windows.Forms.Button();
            this.info_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 546);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // point_button
            // 
            this.point_button.Location = new System.Drawing.Point(942, 28);
            this.point_button.Name = "point_button";
            this.point_button.Size = new System.Drawing.Size(272, 23);
            this.point_button.TabIndex = 1;
            this.point_button.Text = "Точка";
            this.point_button.UseVisualStyleBackColor = true;
            this.point_button.Click += new System.EventHandler(this.point_button_Click);
            // 
            // edge_button
            // 
            this.edge_button.Location = new System.Drawing.Point(942, 57);
            this.edge_button.Name = "edge_button";
            this.edge_button.Size = new System.Drawing.Size(272, 23);
            this.edge_button.TabIndex = 2;
            this.edge_button.Text = "Ребро";
            this.edge_button.UseVisualStyleBackColor = true;
            this.edge_button.Click += new System.EventHandler(this.edge_button_Click);
            // 
            // polygon_button
            // 
            this.polygon_button.Location = new System.Drawing.Point(942, 86);
            this.polygon_button.Name = "polygon_button";
            this.polygon_button.Size = new System.Drawing.Size(272, 23);
            this.polygon_button.TabIndex = 3;
            this.polygon_button.Text = "Полигон";
            this.polygon_button.UseVisualStyleBackColor = true;
            this.polygon_button.Click += new System.EventHandler(this.polygon_button_Click);
            // 
            // clear_butt
            // 
            this.clear_butt.Location = new System.Drawing.Point(942, 514);
            this.clear_butt.Name = "clear_butt";
            this.clear_butt.Size = new System.Drawing.Size(272, 23);
            this.clear_butt.TabIndex = 4;
            this.clear_butt.Text = "Очистить";
            this.clear_butt.UseVisualStyleBackColor = true;
            this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
            // 
            // origin_button
            // 
            this.origin_button.Location = new System.Drawing.Point(942, 135);
            this.origin_button.Name = "origin_button";
            this.origin_button.Size = new System.Drawing.Size(270, 23);
            this.origin_button.TabIndex = 5;
            this.origin_button.Text = "Якорь";
            this.origin_button.UseVisualStyleBackColor = true;
            this.origin_button.Click += new System.EventHandler(this.origin_button_Click);
            // 
            // rotate_button
            // 
            this.rotate_button.Location = new System.Drawing.Point(947, 203);
            this.rotate_button.Name = "rotate_button";
            this.rotate_button.Size = new System.Drawing.Size(123, 23);
            this.rotate_button.TabIndex = 6;
            this.rotate_button.Text = "Поворот";
            this.rotate_button.UseVisualStyleBackColor = true;
            this.rotate_button.Click += new System.EventHandler(this.rotate_button_Click);
            // 
            // rotate_text_box
            // 
            this.rotate_text_box.Location = new System.Drawing.Point(1041, 178);
            this.rotate_text_box.Margin = new System.Windows.Forms.Padding(2);
            this.rotate_text_box.Name = "rotate_text_box";
            this.rotate_text_box.Size = new System.Drawing.Size(29, 20);
            this.rotate_text_box.TabIndex = 7;
            this.rotate_text_box.TextChanged += new System.EventHandler(this.rotate_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Угол в градусах:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(944, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "dx:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(944, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "dy:";
            // 
            // dx_shift_textbox
            // 
            this.dx_shift_textbox.Location = new System.Drawing.Point(971, 248);
            this.dx_shift_textbox.Name = "dx_shift_textbox";
            this.dx_shift_textbox.Size = new System.Drawing.Size(99, 20);
            this.dx_shift_textbox.TabIndex = 11;
            this.dx_shift_textbox.TextChanged += new System.EventHandler(this.dx_shift_textbox_TextChanged);
            // 
            // dy_shift_textbox
            // 
            this.dy_shift_textbox.Location = new System.Drawing.Point(971, 277);
            this.dy_shift_textbox.Name = "dy_shift_textbox";
            this.dy_shift_textbox.Size = new System.Drawing.Size(99, 20);
            this.dy_shift_textbox.TabIndex = 12;
            this.dy_shift_textbox.TextChanged += new System.EventHandler(this.dy_shift_textbox_TextChanged);
            // 
            // shift_button
            // 
            this.shift_button.Location = new System.Drawing.Point(947, 303);
            this.shift_button.Name = "shift_button";
            this.shift_button.Size = new System.Drawing.Size(123, 23);
            this.shift_button.TabIndex = 13;
            this.shift_button.Text = "Сдвиг";
            this.shift_button.UseVisualStyleBackColor = true;
            this.shift_button.Click += new System.EventHandler(this.shift_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(944, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kx:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(944, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ky:";
            // 
            // kx_scale_textbox
            // 
            this.kx_scale_textbox.Location = new System.Drawing.Point(971, 346);
            this.kx_scale_textbox.Name = "kx_scale_textbox";
            this.kx_scale_textbox.Size = new System.Drawing.Size(99, 20);
            this.kx_scale_textbox.TabIndex = 17;
            this.kx_scale_textbox.TextChanged += new System.EventHandler(this.kx_scale_textbox_TextChanged);
            // 
            // ky_scale_textbox
            // 
            this.ky_scale_textbox.Location = new System.Drawing.Point(971, 374);
            this.ky_scale_textbox.Name = "ky_scale_textbox";
            this.ky_scale_textbox.Size = new System.Drawing.Size(99, 20);
            this.ky_scale_textbox.TabIndex = 18;
            this.ky_scale_textbox.TextChanged += new System.EventHandler(this.ky_scale_textbox_TextChanged);
            // 
            // scale_button
            // 
            this.scale_button.Location = new System.Drawing.Point(947, 401);
            this.scale_button.Name = "scale_button";
            this.scale_button.Size = new System.Drawing.Size(123, 23);
            this.scale_button.TabIndex = 19;
            this.scale_button.Text = "Масштабирование";
            this.scale_button.UseVisualStyleBackColor = true;
            this.scale_button.Click += new System.EventHandler(this.scale_button_Click);
            // 
            // edge_rotate_button
            // 
            this.edge_rotate_button.Location = new System.Drawing.Point(947, 443);
            this.edge_rotate_button.Name = "edge_rotate_button";
            this.edge_rotate_button.Size = new System.Drawing.Size(123, 23);
            this.edge_rotate_button.TabIndex = 20;
            this.edge_rotate_button.Text = "Поворот ребра";
            this.edge_rotate_button.UseVisualStyleBackColor = true;
            this.edge_rotate_button.Click += new System.EventHandler(this.edge_rotate_button_Click);
            // 
            // info_textBox
            // 
            this.info_textBox.Location = new System.Drawing.Point(947, 472);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ReadOnly = true;
            this.info_textBox.Size = new System.Drawing.Size(267, 36);
            this.info_textBox.TabIndex = 22;
            // 
            // clear_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 547);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.edge_rotate_button);
            this.Controls.Add(this.scale_button);
            this.Controls.Add(this.ky_scale_textbox);
            this.Controls.Add(this.kx_scale_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shift_button);
            this.Controls.Add(this.dy_shift_textbox);
            this.Controls.Add(this.dx_shift_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotate_text_box);
            this.Controls.Add(this.rotate_button);
            this.Controls.Add(this.origin_button);
            this.Controls.Add(this.clear_butt);
            this.Controls.Add(this.polygon_button);
            this.Controls.Add(this.edge_button);
            this.Controls.Add(this.point_button);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.TextBox rotate_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dx_shift_textbox;
        private System.Windows.Forms.TextBox dy_shift_textbox;
        private System.Windows.Forms.Button shift_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kx_scale_textbox;
        private System.Windows.Forms.TextBox ky_scale_textbox;
        private System.Windows.Forms.Button scale_button;
        private System.Windows.Forms.Button edge_rotate_button;
        private System.Windows.Forms.TextBox info_textBox;
    }
}

