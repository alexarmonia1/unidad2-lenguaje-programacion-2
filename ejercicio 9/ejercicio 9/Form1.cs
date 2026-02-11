namespace ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtnumero.Text))
                {
                MessageBox.Show("el campo no puede estar vacio", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtnumero.Clear();
                txtnumero.Focus();
                return;
                
            }
            
            int varnumero;

            if (int.TryParse(txtnumero.Text, out varnumero))
            {
                MessageBox.Show("es un numero valido");
                    
            }
            else
            {
                MessageBox.Show("solo se permiten numeros.", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtnumero.Clear();
                txtnumero.Focus();
            }
        }
    }
}
