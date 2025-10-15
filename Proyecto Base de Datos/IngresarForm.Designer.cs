namespace Proyecto_Base_de_Datos
{
    partial class IngresarForm
    {
        private System.Windows.Forms.Label lblingresar;
        private System.Windows.Forms.Button buttonAtras;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblingresar = new Label();
            txtBoxNombreProducto = new TextBox();
            lblNombreProducto = new Label();
            lblCodigoProducto = new Label();
            txtBoxCodigoProducto = new TextBox();
            lblCantidadIngresada = new Label();
            txtBoxCantidadIngresada = new TextBox();
            lblProveedor = new Label();
            txtBoxProveedor = new TextBox();
            lblTipoServicioProducto = new Label();
            txtBoxTipoServicio = new TextBox();
            buttonIngresar = new Button();
            panelLeft = new Panel();
            buttonAtras = new Button();
            SuspendLayout();
            // 
            // lblingresar
            // 
            lblingresar.AutoSize = true;
            lblingresar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblingresar.ForeColor = Color.MediumSlateBlue;
            lblingresar.ImeMode = ImeMode.NoControl;
            lblingresar.Location = new Point(382, 9);
            lblingresar.Name = "lblingresar";
            lblingresar.Size = new Size(150, 37);
            lblingresar.TabIndex = 3;
            lblingresar.Text = "INGRESAR";
            // 
            // txtBoxNombreProducto
            // 
            txtBoxNombreProducto.Location = new Point(365, 103);
            txtBoxNombreProducto.Name = "txtBoxNombreProducto";
            txtBoxNombreProducto.Size = new Size(124, 27);
            txtBoxNombreProducto.TabIndex = 4;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(206, 106);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(153, 20);
            lblNombreProducto.TabIndex = 5;
            lblNombreProducto.Text = "Nombre del Producto";
            lblNombreProducto.Click += lblNombreProducto_Click;
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Location = new Point(206, 139);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(147, 20);
            lblCodigoProducto.TabIndex = 7;
            lblCodigoProducto.Text = "Codigo del Producto";
            // 
            // txtBoxCodigoProducto
            // 
            txtBoxCodigoProducto.Location = new Point(365, 136);
            txtBoxCodigoProducto.Name = "txtBoxCodigoProducto";
            txtBoxCodigoProducto.Size = new Size(124, 27);
            txtBoxCodigoProducto.TabIndex = 6;
            // 
            // lblCantidadIngresada
            // 
            lblCantidadIngresada.AutoSize = true;
            lblCantidadIngresada.Location = new Point(206, 172);
            lblCantidadIngresada.Name = "lblCantidadIngresada";
            lblCantidadIngresada.Size = new Size(138, 20);
            lblCantidadIngresada.TabIndex = 13;
            lblCantidadIngresada.Text = "Cantidad Ingresada";
            // 
            // txtBoxCantidadIngresada
            // 
            txtBoxCantidadIngresada.Location = new Point(365, 169);
            txtBoxCantidadIngresada.Name = "txtBoxCantidadIngresada";
            txtBoxCantidadIngresada.Size = new Size(124, 27);
            txtBoxCantidadIngresada.TabIndex = 12;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(206, 202);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(77, 20);
            lblProveedor.TabIndex = 15;
            lblProveedor.Text = "Proveedor";
            // 
            // txtBoxProveedor
            // 
            txtBoxProveedor.Location = new Point(365, 199);
            txtBoxProveedor.Name = "txtBoxProveedor";
            txtBoxProveedor.Size = new Size(124, 27);
            txtBoxProveedor.TabIndex = 14;
            // 
            // lblTipoServicioProducto
            // 
            lblTipoServicioProducto.AutoSize = true;
            lblTipoServicioProducto.Location = new Point(206, 235);
            lblTipoServicioProducto.Name = "lblTipoServicioProducto";
            lblTipoServicioProducto.Size = new Size(205, 20);
            lblTipoServicioProducto.TabIndex = 17;
            lblTipoServicioProducto.Text = "Tipo de Servicio del Producto";
            // 
            // txtBoxTipoServicio
            // 
            txtBoxTipoServicio.Location = new Point(417, 232);
            txtBoxTipoServicio.Name = "txtBoxTipoServicio";
            txtBoxTipoServicio.Size = new Size(124, 27);
            txtBoxTipoServicio.TabIndex = 16;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(395, 289);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(94, 29);
            buttonIngresar.TabIndex = 18;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.MediumSlateBlue;
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 450);
            panelLeft.TabIndex = 1;
            // 
            // buttonAtras
            // 
            buttonAtras.ImeMode = ImeMode.NoControl;
            buttonAtras.Location = new Point(206, 409);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(94, 29);
            buttonAtras.TabIndex = 19;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // IngresarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAtras);
            Controls.Add(buttonIngresar);
            Controls.Add(lblTipoServicioProducto);
            Controls.Add(txtBoxTipoServicio);
            Controls.Add(lblProveedor);
            Controls.Add(txtBoxProveedor);
            Controls.Add(lblCantidadIngresada);
            Controls.Add(txtBoxCantidadIngresada);
            Controls.Add(lblCodigoProducto);
            Controls.Add(txtBoxCodigoProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtBoxNombreProducto);
            Controls.Add(lblingresar);
            Controls.Add(panelLeft);
            Name = "IngresarForm";
            Text = "Form2";
            Load += IngresarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private TextBox txtBoxNombreProducto;
        private Label lblNombreProducto;
        private Label lblCodigoProducto;
        private TextBox txtBoxCodigoProducto;
        private Label lblCantidadIngresada;
        private TextBox txtBoxCantidadIngresada;
        private Label lblProveedor;
        private TextBox txtBoxProveedor;
        private Label lblTipoServicioProducto;
        private TextBox txtBoxTipoServicio;
        private Button buttonIngresar;
        private Panel panelLeft;
        private Button buttonAtrasING;
    }
}