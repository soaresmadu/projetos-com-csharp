namespace Calculadora
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
            txtResultado = new TextBox();
            btnZero = new Button();
            btnUm = new Button();
            btnDois = new Button();
            BtnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnDisplay = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(280, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(93, 295);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(59, 51);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(28, 238);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(59, 51);
            btnUm.TabIndex = 2;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(93, 238);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(59, 51);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // BtnTres
            // 
            BtnTres.Location = new Point(158, 238);
            BtnTres.Name = "BtnTres";
            BtnTres.Size = new Size(59, 51);
            BtnTres.TabIndex = 4;
            BtnTres.Text = "3";
            BtnTres.UseVisualStyleBackColor = true;
            BtnTres.Click += BtnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(28, 181);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(59, 51);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(93, 181);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(59, 51);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(158, 181);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(59, 51);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(28, 124);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(59, 51);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(93, 124);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(59, 51);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(158, 124);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(59, 51);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(223, 124);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(59, 51);
            btnDivisao.TabIndex = 11;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(223, 181);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(59, 51);
            btnMultiplicacao.TabIndex = 12;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(223, 238);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(59, 51);
            btnSubtracao.TabIndex = 13;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(223, 295);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(59, 51);
            btnAdicao.TabIndex = 14;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(28, 295);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(59, 51);
            btnVirgula.TabIndex = 15;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(158, 295);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(59, 51);
            btnIgual.TabIndex = 16;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(223, 67);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(59, 51);
            btnDisplay.TabIndex = 17;
            btnDisplay.Text = "C";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(28, 15);
            label.Name = "label";
            label.Size = new Size(0, 15);
            label.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 366);
            Controls.Add(label);
            Controls.Add(btnDisplay);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnAdicao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(BtnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnZero;
        private Button btnUm;
        private Button btnDois;
        private Button BtnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnDisplay;
        private Label label;
    }
}
