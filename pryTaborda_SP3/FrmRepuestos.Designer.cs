namespace pryTaborda_SP3
{
    partial class FrmRepuestos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblPrecio = new Label();
            mskNumero = new MaskedTextBox();
            btnAgregar = new Button();
            cmbxMarca = new ComboBox();
            textBox2 = new TextBox();
            rbtnInternacional = new RadioButton();
            rbtnNacional = new RadioButton();
            btnLimpiar = new Button();
            lblIngresoRep = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            lblConsultaRep = new Label();
            lblMarcaC = new Label();
            lblOrigeen = new Label();
            rbtnInt = new RadioButton();
            rbtnNac = new RadioButton();
            cmbMarca = new ComboBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(23, 84);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(126, 17);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca del Repuesto";
            lblMarca.Click += label1_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.BorderStyle = BorderStyle.Fixed3D;
            lblOrigen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(335, 82);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(54, 19);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen ";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BorderStyle = BorderStyle.Fixed3D;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(80, 135);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(58, 19);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            lblNumero.Click += label3_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BorderStyle = BorderStyle.Fixed3D;
            lblPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(335, 135);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 19);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio ";
            lblPrecio.Click += label5_Click;
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(175, 133);
            mskNumero.Mask = "000-000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(100, 23);
            mskNumero.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Location = new Point(43, 255);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cmbxMarca
            // 
            cmbxMarca.FormattingEnabled = true;
            cmbxMarca.Items.AddRange(new object[] { "(P) Peugueot", "(F) Fiat", "(R) Renault" });
            cmbxMarca.Location = new Point(175, 83);
            cmbxMarca.Name = "cmbxMarca";
            cmbxMarca.Size = new Size(100, 23);
            cmbxMarca.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // rbtnInternacional
            // 
            rbtnInternacional.AutoSize = true;
            rbtnInternacional.Location = new Point(420, 83);
            rbtnInternacional.Name = "rbtnInternacional";
            rbtnInternacional.Size = new Size(94, 19);
            rbtnInternacional.TabIndex = 14;
            rbtnInternacional.TabStop = true;
            rbtnInternacional.Text = "Internacional";
            rbtnInternacional.UseVisualStyleBackColor = true;
            // 
            // rbtnNacional
            // 
            rbtnNacional.AutoSize = true;
            rbtnNacional.Location = new Point(536, 84);
            rbtnNacional.Name = "rbtnNacional";
            rbtnNacional.Size = new Size(72, 19);
            rbtnNacional.TabIndex = 15;
            rbtnNacional.TabStop = true;
            rbtnNacional.Text = "Nacional";
            rbtnNacional.UseVisualStyleBackColor = true;
            rbtnNacional.CheckedChanged += rbtnNacional_CheckedChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightGray;
            btnLimpiar.Location = new Point(175, 255);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblIngresoRep
            // 
            lblIngresoRep.AutoSize = true;
            lblIngresoRep.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIngresoRep.Location = new Point(214, 24);
            lblIngresoRep.Name = "lblIngresoRep";
            lblIngresoRep.Size = new Size(175, 25);
            lblIngresoRep.TabIndex = 18;
            lblIngresoRep.Text = "Ingreso de Repuesto";
            lblIngresoRep.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 189);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 19;
            label2.Text = "Descripcion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 186);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 52);
            textBox1.TabIndex = 20;
            // 
            // lblConsultaRep
            // 
            lblConsultaRep.AutoSize = true;
            lblConsultaRep.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConsultaRep.Location = new Point(149, 305);
            lblConsultaRep.Name = "lblConsultaRep";
            lblConsultaRep.Size = new Size(196, 25);
            lblConsultaRep.TabIndex = 21;
            lblConsultaRep.Text = "Consulta de Repuestos";
            // 
            // lblMarcaC
            // 
            lblMarcaC.AutoSize = true;
            lblMarcaC.BorderStyle = BorderStyle.Fixed3D;
            lblMarcaC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarcaC.Location = new Point(33, 361);
            lblMarcaC.Name = "lblMarcaC";
            lblMarcaC.Size = new Size(47, 19);
            lblMarcaC.TabIndex = 22;
            lblMarcaC.Text = "Marca";
            // 
            // lblOrigeen
            // 
            lblOrigeen.AutoSize = true;
            lblOrigeen.BorderStyle = BorderStyle.Fixed3D;
            lblOrigeen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigeen.Location = new Point(258, 361);
            lblOrigeen.Name = "lblOrigeen";
            lblOrigeen.Size = new Size(50, 19);
            lblOrigeen.TabIndex = 23;
            lblOrigeen.Text = "Origen";
            // 
            // rbtnInt
            // 
            rbtnInt.AutoSize = true;
            rbtnInt.Location = new Point(336, 360);
            rbtnInt.Name = "rbtnInt";
            rbtnInt.Size = new Size(94, 19);
            rbtnInt.TabIndex = 24;
            rbtnInt.TabStop = true;
            rbtnInt.Text = "Internacional";
            rbtnInt.UseVisualStyleBackColor = true;
            // 
            // rbtnNac
            // 
            rbtnNac.AutoSize = true;
            rbtnNac.Location = new Point(449, 359);
            rbtnNac.Name = "rbtnNac";
            rbtnNac.Size = new Size(72, 19);
            rbtnNac.TabIndex = 25;
            rbtnNac.TabStop = true;
            rbtnNac.Text = "Nacional";
            rbtnNac.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "Peugueot", "Fiat", "Renault" });
            cmbMarca.Location = new Point(100, 357);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(101, 23);
            cmbMarca.TabIndex = 26;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.Location = new Point(200, 422);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 28);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(644, 487);
            Controls.Add(btnBuscar);
            Controls.Add(cmbMarca);
            Controls.Add(rbtnNac);
            Controls.Add(rbtnInt);
            Controls.Add(lblOrigeen);
            Controls.Add(lblMarcaC);
            Controls.Add(lblConsultaRep);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lblIngresoRep);
            Controls.Add(btnLimpiar);
            Controls.Add(rbtnNacional);
            Controls.Add(rbtnInternacional);
            Controls.Add(textBox2);
            Controls.Add(cmbxMarca);
            Controls.Add(btnAgregar);
            Controls.Add(mskNumero);
            Controls.Add(lblPrecio);
            Controls.Add(lblNumero);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            ForeColor = SystemColors.ControlText;
            Name = "FrmRepuestos";
            Text = "Gestion de Repuestos";
            Load += FrmRepuestos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumero;
        private Label lblPrecio;
        private MaskedTextBox mskNumero;
        private Button btnAgregar;
        private ComboBox cmbxMarca;
        private TextBox textBox2;
        private RadioButton rbtnInternacional;
        private RadioButton rbtnNacional;
        private Button btnLimpiar;
        private Label lblIngresoRep;
        private Label label2;
        private TextBox textBox1;
        private Label lblConsultaRep;
        private Label lblMarcaC;
        private Label lblOrigeen;
        private RadioButton rbtnInt;
        private RadioButton rbtnNac;
        private ComboBox cmbMarca;
        private Button btnBuscar;
    }
}
