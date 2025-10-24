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
            cmbMarca = new ComboBox();
            txtPrecio = new TextBox();
            rbtnInternacional = new RadioButton();
            rbtnNacional = new RadioButton();
            btnLimpiar = new Button();
            lblIngresoRep = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            listRepuestos = new ListView();
            Marca = new ColumnHeader();
            Origen = new ColumnHeader();
            Numero = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Precio = new ColumnHeader();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BorderStyle = BorderStyle.Fixed3D;
            lblMarca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(23, 88);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(128, 19);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca del Repuesto";
            lblMarca.Click += label1_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.BorderStyle = BorderStyle.Fixed3D;
            lblOrigen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(337, 87);
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
            lblPrecio.Location = new Point(88, 174);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 19);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio ";
            lblPrecio.Click += label5_Click;
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(175, 129);
            mskNumero.Mask = "000-000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(66, 23);
            mskNumero.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Location = new Point(268, 291);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 25);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P) Peugueot", "(F) Fiat", "(R) Renault" });
            cmbMarca.Location = new Point(175, 87);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(66, 23);
            cmbMarca.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(175, 170);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(66, 23);
            txtPrecio.TabIndex = 13;
            // 
            // rbtnInternacional
            // 
            rbtnInternacional.AutoSize = true;
            rbtnInternacional.Location = new Point(297, 133);
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
            rbtnNacional.Location = new Point(416, 133);
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
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Location = new Point(398, 291);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 25);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblIngresoRep
            // 
            lblIngresoRep.AutoSize = true;
            lblIngresoRep.BorderStyle = BorderStyle.Fixed3D;
            lblIngresoRep.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIngresoRep.Location = new Point(157, 28);
            lblIngresoRep.Name = "lblIngresoRep";
            lblIngresoRep.Size = new Size(177, 27);
            lblIngresoRep.TabIndex = 18;
            lblIngresoRep.Text = "Ingreso de Repuesto";
            lblIngresoRep.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 220);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 19;
            label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(104, 217);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(198, 52);
            txtDescripcion.TabIndex = 20;
            // 
            // listRepuestos
            // 
            listRepuestos.Columns.AddRange(new ColumnHeader[] { Marca, Origen, Numero, Descripcion, Precio });
            listRepuestos.Location = new Point(23, 348);
            listRepuestos.Name = "listRepuestos";
            listRepuestos.Size = new Size(387, 97);
            listRepuestos.TabIndex = 21;
            listRepuestos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(522, 487);
            Controls.Add(listRepuestos);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(lblIngresoRep);
            Controls.Add(btnLimpiar);
            Controls.Add(rbtnNacional);
            Controls.Add(rbtnInternacional);
            Controls.Add(txtPrecio);
            Controls.Add(cmbMarca);
            Controls.Add(btnAgregar);
            Controls.Add(mskNumero);
            Controls.Add(lblPrecio);
            Controls.Add(lblNumero);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            ForeColor = SystemColors.ControlText;
            Name = "FrmRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ComboBox cmbMarca;
        private TextBox txtPrecio;
        private RadioButton rbtnInternacional;
        private RadioButton rbtnNacional;
        private Button btnLimpiar;
        private Label lblIngresoRep;
        private Label label2;
        private TextBox txtDescripcion;
        private ListView listRepuestos;
        private ColumnHeader Numero;
        private ColumnHeader Marca;
        private ColumnHeader Origen;
        private ColumnHeader Descripcion;
        private ColumnHeader Precio;
    }
}
