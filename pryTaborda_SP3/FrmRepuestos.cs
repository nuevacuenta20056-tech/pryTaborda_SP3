namespace pryTaborda_SP3
{
    public partial class FrmRepuestos : Form
    {
        public FrmRepuestos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmRepuestos_Load(object sender, EventArgs e)
        {

        }

        private void rbtnNacional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // aca valido si todos los campos estan completos
            if (cmbxMarca.SelectedIndex == -1 || mskNumero.Text == "" || mskPrecio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Información incompleta",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string marca = cmbxMarca.Text;
            string numero = mskNumero.Text;
            string precio = mskPrecio.Text;
            string descripcion = txtDescripcion.Text;

            string origen = "";
            if (rbtnInternacional.Checked)
            {
                origen = "Internacional";
            }
            else if (rbtnNacional.Checked)
            {
                origen = "Nacional";
            }
            else
            {
                origen = "No especificado";
            }

            // crear el texto a mostrar en la lista
            string item = $"Marca: {marca} | Nº: {numero} | Origen: {origen} | Precio: ${precio} | {descripcion}";

            // agrego datos a la lst
            lstRepuestos.Items.Add(item);

            // limpio los campos despues de agregar
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            cmbxMarca.SelectedIndex = -1;
            mskNumero.Clear();
            mskPrecio.Clear();
            txtDescripcion.Clear();
            rbtnInternacional.Checked = false;
            rbtnNacional.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            // limpio los datos agregados de la lst
            lstRepuestos.Items.Clear();

            // elimina datos y vuelve al primer campo
            cmbxMarca.Focus();
        }
    }
}
