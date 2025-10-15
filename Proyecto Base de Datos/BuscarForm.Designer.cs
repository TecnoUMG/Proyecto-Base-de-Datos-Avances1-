namespace Proyecto_Base_de_Datos
{
    partial class BuscarForm
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
            panelLeft = new Panel();
            lblBuscar = new Label();
            lblCodigoProductoB = new Label();
            txtBoxCodigoProductoB = new TextBox();
            buttonBuscar = new Button();
            buttonAtrasBUS = new Button();
            lblinfoProductoNombre = new Label();
            lblinfoCantidades = new Label();
            lblinfoTipoServicio = new Label();
            lblinfoProveedores = new Label();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.MediumSlateBlue;
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 450);
            panelLeft.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.MediumSlateBlue;
            lblBuscar.ImeMode = ImeMode.NoControl;
            lblBuscar.Location = new Point(390, 9);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(123, 37);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "BUSCAR";
            // 
            // lblCodigoProductoB
            // 
            lblCodigoProductoB.AutoSize = true;
            lblCodigoProductoB.Location = new Point(215, 107);
            lblCodigoProductoB.Name = "lblCodigoProductoB";
            lblCodigoProductoB.Size = new Size(147, 20);
            lblCodigoProductoB.TabIndex = 8;
            lblCodigoProductoB.Text = "Codigo del Producto";
            // 
            // txtBoxCodigoProductoB
            // 
            txtBoxCodigoProductoB.Location = new Point(374, 104);
            txtBoxCodigoProductoB.Name = "txtBoxCodigoProductoB";
            txtBoxCodigoProductoB.Size = new Size(125, 27);
            txtBoxCodigoProductoB.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(390, 177);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 9;
            buttonBuscar.Text = "BUSCAR";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonAtrasBUS
            // 
            buttonAtrasBUS.ImeMode = ImeMode.NoControl;
            buttonAtrasBUS.Location = new Point(206, 409);
            buttonAtrasBUS.Name = "buttonAtrasBUS";
            buttonAtrasBUS.Size = new Size(94, 29);
            buttonAtrasBUS.TabIndex = 10;
            buttonAtrasBUS.Text = "Atras";
            buttonAtrasBUS.UseVisualStyleBackColor = true;
            buttonAtrasBUS.Click += buttonAtrasBUS_Click;
            // 
            // lblinfoProductoNombre
            // 
            lblinfoProductoNombre.AutoSize = true;
            lblinfoProductoNombre.Location = new Point(221, 230);
            lblinfoProductoNombre.Name = "lblinfoProductoNombre";
            lblinfoProductoNombre.Size = new Size(15, 20);
            lblinfoProductoNombre.TabIndex = 11;
            lblinfoProductoNombre.Text = "..";
            // 
            // lblinfoCantidades
            // 
            lblinfoCantidades.AutoSize = true;
            lblinfoCantidades.Location = new Point(221, 266);
            lblinfoCantidades.Name = "lblinfoCantidades";
            lblinfoCantidades.Size = new Size(15, 20);
            lblinfoCantidades.TabIndex = 12;
            lblinfoCantidades.Text = "..";
            // 
            // lblinfoTipoServicio
            // 
            lblinfoTipoServicio.AutoSize = true;
            lblinfoTipoServicio.Location = new Point(221, 335);
            lblinfoTipoServicio.Name = "lblinfoTipoServicio";
            lblinfoTipoServicio.Size = new Size(15, 20);
            lblinfoTipoServicio.TabIndex = 13;
            lblinfoTipoServicio.Text = "..";
            // 
            // lblinfoProveedores
            // 
            lblinfoProveedores.AutoSize = true;
            lblinfoProveedores.Location = new Point(221, 305);
            lblinfoProveedores.Name = "lblinfoProveedores";
            lblinfoProveedores.Size = new Size(15, 20);
            lblinfoProveedores.TabIndex = 14;
            lblinfoProveedores.Text = "..";
            // 
            // BuscarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblinfoProveedores);
            Controls.Add(lblinfoTipoServicio);
            Controls.Add(lblinfoCantidades);
            Controls.Add(lblinfoProductoNombre);
            Controls.Add(buttonAtrasBUS);
            Controls.Add(buttonBuscar);
            Controls.Add(lblCodigoProductoB);
            Controls.Add(txtBoxCodigoProductoB);
            Controls.Add(lblBuscar);
            Controls.Add(panelLeft);
            Name = "BuscarForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }
        //
        #endregion

        private Panel panelLeft;
        private Label lblBuscar;
        private Label lblCodigoProductoB;
        private TextBox txtBoxCodigoProductoB;
        private Button buttonBuscar;
        private Button buttonAtrasBUS;
        private Label lblinfoProductoNombre;
        private Label lblinfoCantidades;
        private Label lblinfoTipoServicio;
        private Label lblinfoProveedores;
    }
}