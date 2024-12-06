namespace RelogioDigital
{
    public partial class Form1 : Form
    {
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void timerRelogioDigital_Tick(object sender, EventArgs e)
        {

            Horas = DateTime.Now.Hour;
            Minutos = DateTime.Now.Minute;
            Segundos = DateTime.Now.Second;

            horas.Text = Horas.ToString().PadLeft(2, '0');
            minutos.Text = Minutos.ToString().PadLeft(2, '0');
            segundos.Text = Segundos.ToString().PadLeft(2, '0');

        }

    }
}
