using System.Drawing.Text;

namespace pryTaborda_SP3
{
    public partial class FrmRepuestos : Form
    {
        //Definir estructura
        struct Repuesto { }
        public char marca;  //P, F o R
        public char origen;// i,n
        public float precio;

        Repuesto[] repuestos = new Repuesto[100];
        int cantidad = 0;

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
            cantidad = 0;


            if (cantidad >= 100)

            {
                cantidad = 0;
            }
            //Validaciones 
            if (cmbMarca.SelectedIndex == -1 && mskNumero.Text == "" && txtDescripcion.Text == "" && txtPrecio.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
        } 
           
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = -1;
            mskNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();  
            rbtnInternacional.Checked = false;  
            rbtnNacional.Enabled = false;   
        }
        

    }


}
