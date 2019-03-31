namespace Marching_squares_isoline
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Нарисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(23, 12);
            this.chart1.Name = "chart1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(883, 663);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 723);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество изолиний";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 752);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Файл...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(902, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 663);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 764);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mx";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(421, 762);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0,99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 734);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "My";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(421, 731);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0,99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 686);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "AlphaY";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(52, 684);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(97, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 687);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Zy";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(181, 684);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(97, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 711);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "StartX";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(576, 707);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(97, 20);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "-12";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(576, 762);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(97, 20);
            this.textBox9.TabIndex = 21;
            this.textBox9.Text = "25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 765);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hx";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(143, 762);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(97, 20);
            this.textBox10.TabIndex = 24;
            this.textBox10.Text = "Val";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 737);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "EndX";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(576, 734);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(97, 20);
            this.textBox11.TabIndex = 25;
            this.textBox11.Text = "-12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(682, 736);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "EndY";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(721, 733);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(97, 20);
            this.textBox12.TabIndex = 29;
            this.textBox12.Text = "-12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 710);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "StartY";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(721, 706);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(97, 20);
            this.textBox13.TabIndex = 27;
            this.textBox13.Text = "-12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(695, 764);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Hy";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(721, 761);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(97, 20);
            this.textBox14.TabIndex = 31;
            this.textBox14.Text = "25";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(432, 686);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Zx";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(452, 683);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(97, 20);
            this.textBox15.TabIndex = 35;
            this.textBox15.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 686);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "AlphaX";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(331, 681);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(97, 20);
            this.textBox16.TabIndex = 33;
            this.textBox16.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 746);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "подпись";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(263, 715);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "характерная величина";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(281, 731);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(97, 20);
            this.textBox17.TabIndex = 38;
            this.textBox17.Text = "1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 762);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 40;
            this.textBox4.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 785);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox4;
    }
}

