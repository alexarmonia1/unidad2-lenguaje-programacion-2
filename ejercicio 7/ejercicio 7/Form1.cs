namespace ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtelemento.Text))
            {
                MessageBox.Show("no puedes agregar un campo vacio", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            lstelementos.Items.Add(txtelemento.Text);
            txtelemento.Clear();
            txtelemento.Focus();
            
        }
    }
}
