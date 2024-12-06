using System.Linq.Expressions;

namespace Calculadora{
    public partial class Form1 : Form
    {
        public double Resultado { get; set; }
        public double Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            label.Text = "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            label.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            label.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            label.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + double.Parse(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - double.Parse(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * double.Parse(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / double.Parse(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Resultado.ToString();
            label.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            label.Text = "";
        }

    }
}
