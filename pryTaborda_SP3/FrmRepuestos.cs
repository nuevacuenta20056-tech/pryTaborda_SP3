namespace pryTaborda_SP3
{
    public partial class FrmRepuestos : Form
    {
        //Definir estructura
        struct Repuesto { }
        public char marca;  //P, F o R
        public char origen;// i,n
        public int Numero; // maximo 6 digitos 
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
            if (cantidad >= 100)
                cantidad = 0;
            MessageBox.Show("no se pueden agregar mas repuestos(maximo 100).");
            return;
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
        

    }


}
