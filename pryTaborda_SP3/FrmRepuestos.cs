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
        string[] vecMarca = new string[100];
        string[] vecNumeros = new string[100];
        float[] vecPrecio = new float[100];
        string[] vecOrigen = new string[100];
        string[] vecDescripcion = new string[100];
        int i = 0;
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
            if(i == 100)
 {
                MessageBox.Show("No se permiten mas ingresos");
            }
            else
            {
                if (cmbMarca.Text != "" && lblOrigen.Text != "" && txtNumero.Text != "" &&
                    txtPrecio.Text != "" && txtDescripcion.Text != "")
                {
                    int iDos = 0;
                    int Mensaje = 0;

                    while ((iDos < 100) && (Mensaje == 0))
                    {
                        if (vecNumeros[iDos] == txtNumero.Text)
                        {
                            MessageBox.Show("Numero de Repuesto ya existente");
                            Mensaje = 1;
                        }
                        iDos++;
                    }
                    if (iDos == 100)
                    {
                        vecDescripcion[i] = txtDescripcion.Text;
                        vecMarca[i] = cmbMarca.Text;
                        vecOrigen[i] = lblOrigen.Text;
                        vecPrecio[i] = Convert.ToSingle(txtPrecio.Text);
                        vecNumeros[i] = txtNumero.Text;
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos");
                }

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
