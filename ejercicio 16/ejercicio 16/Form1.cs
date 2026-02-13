namespace ejercicio_16
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtpantalla.Text += boton.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtpantalla.Text))
            {
                MessageBox.Show("Ingrese un número primero.");
                return;
            }
            numero1 = Convert.ToDouble(txtpantalla.Text);
            operador = "+";
            txtpantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtpantalla.Text))
            {
                MessageBox.Show("Ingrese un número primero.");
                return;
            }
            numero1 = Convert.ToDouble(txtpantalla.Text);
            operador = "-";
            txtpantalla.Clear();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtpantalla.Text))
            {
                MessageBox.Show("Ingrese un número primero.");
                return;
            }
            numero1 = Convert.ToDouble(txtpantalla.Text);
            operador = "x";
            txtpantalla.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpantalla.Text))
            {
                MessageBox.Show("Ingrese un número primero.");
                return;
            }
            numero1 = Convert.ToDouble(txtpantalla.Text);
            operador = "/";
            txtpantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpantalla.Text))
            {
                MessageBox.Show("Ingrese un número primero.");
                return;
            }
            double numero2 = Convert.ToDouble(txtpantalla.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "x":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
            }

            txtpantalla.Text = resultado.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtpantalla.Clear();
            numero1 = 0;
            operador = "";
        }
    }
}
