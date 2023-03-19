namespace EjercicioPanesRectangulares
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pan panesitoCuadrado = new Pan((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Calculadora.CalcularPanArea(ref panesitoCuadrado);
            Calculadora.CalcularPanArea(ref panesitoCuadrado);
            Calculadora.CalcularPanArea(ref panesitoCuadrado);
        }
    }
}