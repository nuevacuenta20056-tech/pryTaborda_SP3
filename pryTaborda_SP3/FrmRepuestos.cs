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
            // Validar que se haya ingresado la información 
            if (cmbxMarca.SelectedIndex == -1 || mskNumero.Text == "" || mskPrecio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los valores de los controles
            string marca = cmbxMarca.Text;
            string numero = mskNumero.Text;
            string precio = mskPrecio.Text;
            string descripcion = txtDescripcion.Text;

            string origen;
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
            MessageBox.Show($"Marca: {marca}\nNúmero: {numero}\nPrecio: {precio}\nDescripción: {descripcion}\nOrigen: {origen}",
                            "Datos del Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Crear el texto a mostrar en la lista
            string item = $"Marca: {marca} | Nº: {numero} | Origen: {origen} | Precio: ${precio} | {descripcion}";

            // Agregar a la ListBox
            lstRepuestos.Items.Add(item);

            // Limpiar campos después de agregar
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        /// Limpia los campos del formulario de repuestos.
        private void LimpiarCampos()
        {
            cmbxMarca.SelectedIndex = -1;
            mskNumero.Text = "";
            mskPrecio.Text = "";
            txtDescripcion.Text = "";
            rbtnNacional.Checked = false;
            rbtnInternacional.Checked = false;
        }

    }
}
