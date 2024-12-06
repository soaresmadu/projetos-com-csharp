namespace RelogioDigital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            horas = new Label();
            minutos = new Label();
            segundos = new Label();
            label4 = new Label();
            label5 = new Label();
            timerRelogioDigital = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // horas
            // 
            horas.AutoSize = true;
            horas.Font = new Font("Segoe UI", 50F);
            horas.Location = new Point(82, 60);
            horas.Name = "horas";
            horas.Size = new Size(110, 89);
            horas.TabIndex = 0;
            horas.Text = "00";
            horas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minutos
            // 
            minutos.AutoSize = true;
            minutos.Font = new Font("Segoe UI", 50F);
            minutos.Location = new Point(232, 60);
            minutos.Name = "minutos";
            minutos.Size = new Size(110, 89);
            minutos.TabIndex = 1;
            minutos.Text = "00";
            minutos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // segundos
            // 
            segundos.AutoSize = true;
            segundos.Font = new Font("Segoe UI", 50F);
            segundos.Location = new Point(375, 60);
            segundos.Name = "segundos";
            segundos.Size = new Size(110, 89);
            segundos.TabIndex = 2;
            segundos.Text = "00";
            segundos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 50F);
            label4.Location = new Point(185, 60);
            label4.Name = "label4";
            label4.Size = new Size(53, 89);
            label4.TabIndex = 3;
            label4.Text = ":";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 50F);
            label5.Location = new Point(329, 60);
            label5.Name = "label5";
            label5.Size = new Size(53, 89);
            label5.TabIndex = 4;
            label5.Text = ":";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerRelogioDigital
            // 
            timerRelogioDigital.Enabled = true;
            timerRelogioDigital.Interval = 1000;
            timerRelogioDigital.Tick += timerRelogioDigital_Tick;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(82, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 5;
            textBox1.Text = "HORAS";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(219, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 25);
            textBox2.TabIndex = 6;
            textBox2.Text = "MINUTOS";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(375, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 25);
            textBox3.TabIndex = 7;
            textBox3.Text = "SEGUNDOS";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 223);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(segundos);
            Controls.Add(minutos);
            Controls.Add(horas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relógio Digital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label horas;
        private Label minutos;
        private Label segundos;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timerRelogioDigital;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
