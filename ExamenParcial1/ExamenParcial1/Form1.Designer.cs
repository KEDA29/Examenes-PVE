namespace ExamenParcial1
{
    partial class Form1
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
            this.MenuMoneda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Conversiones = new System.Windows.Forms.GroupBox();
            this.txtYen = new System.Windows.Forms.TextBox();
            this.lblYen = new System.Windows.Forms.Label();
            this.txtEur = new System.Windows.Forms.TextBox();
            this.lblEur = new System.Windows.Forms.Label();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.lblCa = new System.Windows.Forms.Label();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.lblUs = new System.Windows.Forms.Label();
            this.txtMx = new System.Windows.Forms.TextBox();
            this.lblMx = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Conversiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMoneda
            // 
            this.MenuMoneda.FormattingEnabled = true;
            this.MenuMoneda.Items.AddRange(new object[] {
            "USD-Dólar Estado Unidense",
            "MXN-Peso Mexicano",
            "CAD-Dolar Canadiense",
            "EUR-Euro",
            "JPY-Yen japones"});
            this.MenuMoneda.Location = new System.Drawing.Point(12, 61);
            this.MenuMoneda.Name = "MenuMoneda";
            this.MenuMoneda.Size = new System.Drawing.Size(222, 33);
            this.MenuMoneda.TabIndex = 0;
            this.MenuMoneda.Text = "Divisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moneda";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(258, 61);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(169, 31);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto";
            // 
            // Conversiones
            // 
            this.Conversiones.Controls.Add(this.txtYen);
            this.Conversiones.Controls.Add(this.lblYen);
            this.Conversiones.Controls.Add(this.txtEur);
            this.Conversiones.Controls.Add(this.lblEur);
            this.Conversiones.Controls.Add(this.txtCa);
            this.Conversiones.Controls.Add(this.lblCa);
            this.Conversiones.Controls.Add(this.txtUs);
            this.Conversiones.Controls.Add(this.lblUs);
            this.Conversiones.Controls.Add(this.txtMx);
            this.Conversiones.Controls.Add(this.lblMx);
            this.Conversiones.Location = new System.Drawing.Point(12, 173);
            this.Conversiones.Name = "Conversiones";
            this.Conversiones.Size = new System.Drawing.Size(415, 271);
            this.Conversiones.TabIndex = 4;
            this.Conversiones.TabStop = false;
            this.Conversiones.Text = "Conversiones";
            // 
            // txtYen
            // 
            this.txtYen.Location = new System.Drawing.Point(246, 193);
            this.txtYen.Name = "txtYen";
            this.txtYen.ReadOnly = true;
            this.txtYen.Size = new System.Drawing.Size(150, 31);
            this.txtYen.TabIndex = 1;
            this.txtYen.Text = "0";
            // 
            // lblYen
            // 
            this.lblYen.AutoSize = true;
            this.lblYen.Location = new System.Drawing.Point(17, 193);
            this.lblYen.Name = "lblYen";
            this.lblYen.Size = new System.Drawing.Size(139, 25);
            this.lblYen.TabIndex = 0;
            this.lblYen.Text = "JPY-Yen japones";
            // 
            // txtEur
            // 
            this.txtEur.Location = new System.Drawing.Point(246, 156);
            this.txtEur.Name = "txtEur";
            this.txtEur.ReadOnly = true;
            this.txtEur.Size = new System.Drawing.Size(150, 31);
            this.txtEur.TabIndex = 1;
            this.txtEur.Text = "0";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Location = new System.Drawing.Point(17, 156);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(87, 25);
            this.lblEur.TabIndex = 0;
            this.lblEur.Text = "EUR-Euro";
            // 
            // txtCa
            // 
            this.txtCa.Location = new System.Drawing.Point(246, 119);
            this.txtCa.Name = "txtCa";
            this.txtCa.ReadOnly = true;
            this.txtCa.Size = new System.Drawing.Size(150, 31);
            this.txtCa.TabIndex = 1;
            this.txtCa.Text = "0";
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Location = new System.Drawing.Point(17, 119);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(190, 25);
            this.lblCa.TabIndex = 0;
            this.lblCa.Text = "CAD-Dolar canadiense";
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(246, 82);
            this.txtUs.Name = "txtUs";
            this.txtUs.ReadOnly = true;
            this.txtUs.Size = new System.Drawing.Size(150, 31);
            this.txtUs.TabIndex = 1;
            this.txtUs.Text = "0";
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Location = new System.Drawing.Point(6, 82);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(227, 25);
            this.lblUs.TabIndex = 0;
            this.lblUs.Text = "USD-Dolar estadounidense";
            // 
            // txtMx
            // 
            this.txtMx.Location = new System.Drawing.Point(246, 45);
            this.txtMx.Name = "txtMx";
            this.txtMx.ReadOnly = true;
            this.txtMx.Size = new System.Drawing.Size(150, 31);
            this.txtMx.TabIndex = 1;
            this.txtMx.Text = "0";
            // 
            // lblMx
            // 
            this.lblMx.AutoSize = true;
            this.lblMx.Location = new System.Drawing.Point(17, 45);
            this.lblMx.Name = "lblMx";
            this.lblMx.Size = new System.Drawing.Size(176, 25);
            this.lblMx.TabIndex = 0;
            this.lblMx.Text = "MXN-Peso mexicano";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(285, 110);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 34);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 472);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.Conversiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuMoneda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Conversiones.ResumeLayout(false);
            this.Conversiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox MenuMoneda;
        private Label label1;
        private TextBox txtMonto;
        private Label label2;
        private GroupBox Conversiones;
        private Button btnCalcular;
        private TextBox txtMx;
        private Label lblMx;
        private TextBox txtYen;
        private Label lblYen;
        private TextBox txtEur;
        private Label lblEur;
        private TextBox txtCa;
        private Label lblCa;
        private TextBox txtUs;
        private Label lblUs;
    }
}