namespace JogoAdivinharNumero
{
    public partial class Form1 : Form
    {

        private int numeroAleatorio { get; set; }
        private int numeroTentativas { get; set; }
        public Form1()
        {
            InitializeComponent();
            IniciarJogo();
        }

        public void IniciarJogo()
        {
            Random random = new();
            numeroAleatorio = random.Next(1, 101);
            numeroTentativas = 10;
            txtDicas.Text = "Estou pensando em um n�mero de 1 a 100";
            txtJogadasRestantes.Text = "TENTATIVAS RESTANTES: " + numeroTentativas.ToString();
            txtResultado.Text = "";
            txtTentativas.Text = "";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtTentativas.Text) < numeroAleatorio)
            {
                numeroTentativas -= 1;
                txtDicas.Text = "O n�mero que estou pensando � MAIOR!";
                txtJogadasRestantes.Text = "TENTATIVAS RESTANTES: " + numeroTentativas.ToString();
            }
            else if (int.Parse(txtTentativas.Text) > numeroAleatorio)
            {
                numeroTentativas -= 1;
                txtDicas.Text = "O n�mero que estou pensando � MENOR!";
                txtJogadasRestantes.Text = "TENTATIVAS RESTANTES: " + numeroTentativas.ToString();
            }
            else
            {
                numeroTentativas = 0;
                txtDicas.Text = "";
                txtJogadasRestantes.Text = "";
                txtResultado.Text = "PARAB�NS! VOC� ACERTOU. \n O n�mero era: " + numeroAleatorio.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }
    }
}
