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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 69);
            label1.Name = "label1";
            label1.Size = new Size(126, 17);
            label1.TabIndex = 0;
            label1.Text = "Marca del Repuesto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 124);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 1;
            label2.Text = "Origen ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 181);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 2;
            label3.Text = "Numero ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 240);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 3;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 306);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 4;
            label5.Text = "Precio ";
            label5.Click += label5_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(115, 181);
            maskedTextBox1.Mask = "000-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // FrmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 430);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRepuestos";
            Text = "Repuestos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
    }
}
