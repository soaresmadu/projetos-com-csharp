namespace JogoAdivinharNumero
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
            txtDicas = new TextBox();
            txtTentativas = new TextBox();
            btnVerificar = new Button();
            txtJogadasRestantes = new Label();
            txtResultado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDicas
            // 
            txtDicas.BorderStyle = BorderStyle.None;
            txtDicas.Location = new Point(12, 24);
            txtDicas.Multiline = true;
            txtDicas.Name = "txtDicas";
            txtDicas.ReadOnly = true;
            txtDicas.Size = new Size(395, 31);
            txtDicas.TabIndex = 0;
            txtDicas.Text = "Estou pensando em um número de 0 a 100";
            txtDicas.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTentativas
            // 
            txtTentativas.Location = new Point(160, 98);
            txtTentativas.Name = "txtTentativas";
            txtTentativas.Size = new Size(100, 23);
            txtTentativas.TabIndex = 1;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(174, 146);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtJogadasRestantes
            // 
            txtJogadasRestantes.AutoSize = true;
            txtJogadasRestantes.Location = new Point(141, 191);
            txtJogadasRestantes.Name = "txtJogadasRestantes";
            txtJogadasRestantes.Size = new Size(138, 15);
            txtJogadasRestantes.TabIndex = 3;
            txtJogadasRestantes.Text = "JOGADAS RESTANTES: 10";
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Location = new Point(141, 228);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(141, 15);
            txtResultado.TabIndex = 4;
            txtResultado.Text = "PARABÉNS! Você acertou.";
            // 
            // button1
            // 
            button1.Location = new Point(147, 277);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 5;
            button1.Text = "REINICAR JOGO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(426, 450);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Controls.Add(txtJogadasRestantes);
            Controls.Add(btnVerificar);
            Controls.Add(txtTentativas);
            Controls.Add(txtDicas);
            Name = "Form1";
            Text = "Jogo: Adivinhe o Número";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDicas;
        private TextBox txtTentativas;
        private Button btnVerificar;
        private Label txtJogadasRestantes;
        private Label txtResultado;
        private Button button1;
    }
}
