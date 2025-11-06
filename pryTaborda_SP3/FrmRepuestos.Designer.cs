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
            rbtnInternacional = new RadioButton();
            rbtnNacional = new RadioButton();
            btnLimpiar = new Button();
            lblIngresoRep = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lstRepuestos = new ListBox();
            mskPrecio = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(26, 112);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(161, 23);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca del Repuesto";
            lblMarca.Click += label1_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.BorderStyle = BorderStyle.Fixed3D;
            lblOrigen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(360, 114);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(69, 25);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen ";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BorderStyle = BorderStyle.Fixed3D;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(91, 180);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(75, 25);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            lblNumero.Click += label3_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BorderStyle = BorderStyle.Fixed3D;
            lblPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(365, 180);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 25);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio ";
            lblPrecio.Click += label5_Click;
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(200, 177);
            mskNumero.Margin = new Padding(3, 4, 3, 4);
            mskNumero.Mask = "000-000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(114, 27);
            mskNumero.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Location = new Point(360, 356);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 41);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbxMarca
            // 
            cmbxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxMarca.FormattingEnabled = true;
            cmbxMarca.Items.AddRange(new object[] { "(P) Peugueot", "(F) Fiat", "(R) Renault" });
            cmbxMarca.Location = new Point(200, 111);
            cmbxMarca.Margin = new Padding(3, 4, 3, 4);
            cmbxMarca.Name = "cmbxMarca";
            cmbxMarca.Size = new Size(114, 28);
            cmbxMarca.TabIndex = 12;
            // 
            // rbtnInternacional
            // 
            rbtnInternacional.AutoSize = true;
            rbtnInternacional.Location = new Point(446, 115);
            rbtnInternacional.Margin = new Padding(3, 4, 3, 4);
            rbtnInternacional.Name = "rbtnInternacional";
            rbtnInternacional.Size = new Size(116, 24);
            rbtnInternacional.TabIndex = 14;
            rbtnInternacional.TabStop = true;
            rbtnInternacional.Text = "Internacional";
            rbtnInternacional.UseVisualStyleBackColor = true;
            // 
            // rbtnNacional
            // 
            rbtnNacional.AutoSize = true;
            rbtnNacional.Location = new Point(579, 115);
            rbtnNacional.Margin = new Padding(3, 4, 3, 4);
            rbtnNacional.Name = "rbtnNacional";
            rbtnNacional.Size = new Size(89, 24);
            rbtnNacional.TabIndex = 15;
            rbtnNacional.TabStop = true;
            rbtnNacional.Text = "Nacional";
            rbtnNacional.UseVisualStyleBackColor = true;
            rbtnNacional.CheckedChanged += rbtnNacional_CheckedChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightGray;
            btnLimpiar.Location = new Point(464, 356);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 41);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblIngresoRep
            // 
            lblIngresoRep.AutoSize = true;
            lblIngresoRep.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIngresoRep.Location = new Point(245, 32);
            lblIngresoRep.Name = "lblIngresoRep";
            lblIngresoRep.Size = new Size(222, 32);
            lblIngresoRep.TabIndex = 18;
            lblIngresoRep.Text = "Ingreso de Repuesto";
            lblIngresoRep.Click += label1_Click_1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(26, 252);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 19;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 248);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(226, 68);
            txtDescripcion.TabIndex = 20;
            // 
            // lstRepuestos
            // 
            lstRepuestos.FormattingEnabled = true;
            lstRepuestos.Location = new Point(110, 428);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Size = new Size(328, 104);
            lstRepuestos.TabIndex = 21;
            // 
            // mskPrecio
            // 
            mskPrecio.Location = new Point(453, 178);
            mskPrecio.Mask = "$000-0000";
            mskPrecio.Name = "mskPrecio";
            mskPrecio.Size = new Size(109, 27);
            mskPrecio.TabIndex = 22;
            // 
            // FrmRepuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(670, 585);
            Controls.Add(mskPrecio);
            Controls.Add(lstRepuestos);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblIngresoRep);
            Controls.Add(btnLimpiar);
            Controls.Add(rbtnNacional);
            Controls.Add(rbtnInternacional);
            Controls.Add(cmbxMarca);
            Controls.Add(btnAgregar);
            Controls.Add(mskNumero);
            Controls.Add(lblPrecio);
            Controls.Add(lblNumero);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
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
        private RadioButton rbtnInternacional;
        private RadioButton rbtnNacional;
        private Button btnLimpiar;
        private Label lblIngresoRep;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private ListBox lstRepuestos;
        private MaskedTextBox mskPrecio;
    }
}
