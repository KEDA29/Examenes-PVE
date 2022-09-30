namespace ExamenParcial1
{
    partial class SelecDivisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkDivisa = new System.Windows.Forms.CheckedListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkDivisa
            // 
            this.checkDivisa.FormattingEnabled = true;
            this.checkDivisa.Items.AddRange(new object[] {
            "USD-Dólar estado unidense",
            "MXN-Peso mexicano",
            "CAD-Dólar canadiense",
            "EUR-Euro",
            "JPY-Yen japones"});
            this.checkDivisa.Location = new System.Drawing.Point(44, 12);
            this.checkDivisa.Name = "checkDivisa";
            this.checkDivisa.Size = new System.Drawing.Size(277, 172);
            this.checkDivisa.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(44, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(209, 227);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // SelecDivisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 373);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkDivisa);
            this.Name = "SelecDivisa";
            this.Text = "SelecDivisa";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkDivisa;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}