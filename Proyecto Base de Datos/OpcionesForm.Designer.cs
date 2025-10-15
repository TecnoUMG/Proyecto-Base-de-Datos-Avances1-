
namespace Proyecto_Base_de_Datos
{
    partial class OpcionesForm
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesForm));
            lblopciones = new Label();
            topPanel = new Panel();
            IngresarButton = new Button();
            BuscarButton = new Button();
            buttonEliminarRegistro = new Button();
            butonActualizar = new Button();
            buttonGenerarReporte = new Button();
            buttonAtrasOP = new Button();
            SuspendLayout();
            // 
            // lblopciones
            // 
            resources.ApplyResources(lblopciones, "lblopciones");
            lblopciones.ForeColor = Color.MediumSlateBlue;
            lblopciones.Name = "lblopciones";
            lblopciones.Click += lblTitle_Click;
            // 
            // topPanel
            // 
            topPanel.AccessibleRole = AccessibleRole.TitleBar;
            topPanel.BackColor = Color.MediumSlateBlue;
            resources.ApplyResources(topPanel, "topPanel");
            topPanel.Name = "topPanel";
            // 
            // IngresarButton
            // 
            resources.ApplyResources(IngresarButton, "IngresarButton");
            IngresarButton.Name = "IngresarButton";
            IngresarButton.UseVisualStyleBackColor = true;
            IngresarButton.Click += IngresarButton_Click;
            // 
            // BuscarButton
            // 
            resources.ApplyResources(BuscarButton, "BuscarButton");
            BuscarButton.Name = "BuscarButton";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarRegistro
            // 
            resources.ApplyResources(buttonEliminarRegistro, "buttonEliminarRegistro");
            buttonEliminarRegistro.Name = "buttonEliminarRegistro";
            buttonEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // butonActualizar
            // 
            resources.ApplyResources(butonActualizar, "butonActualizar");
            butonActualizar.Name = "butonActualizar";
            butonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonGenerarReporte
            // 
            resources.ApplyResources(buttonGenerarReporte, "buttonGenerarReporte");
            buttonGenerarReporte.Name = "buttonGenerarReporte";
            buttonGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // buttonAtrasOP
            // 
            resources.ApplyResources(buttonAtrasOP, "buttonAtrasOP");
            buttonAtrasOP.Name = "buttonAtrasOP";
            buttonAtrasOP.UseVisualStyleBackColor = true;
            buttonAtrasOP.Click += buttonAtrasOP_Click;
            // 
            // OpcionesForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAtrasOP);
            Controls.Add(buttonGenerarReporte);
            Controls.Add(butonActualizar);
            Controls.Add(buttonEliminarRegistro);
            Controls.Add(BuscarButton);
            Controls.Add(IngresarButton);
            Controls.Add(topPanel);
            Controls.Add(lblopciones);
            Name = "OpcionesForm";
            Load += OpcionesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonAtrasOP_Click(object sender, EventArgs e)
        {
            OpcionesForm opcionesForm = new OpcionesForm();
            opcionesForm.Show();
            this.Hide();
        }

        #endregion

        private Label lblopciones;
        private Panel topPanel;
        private Button IngresarButton;
        private Button BuscarButton;
        private Button buttonEliminarRegistro;
        private Button butonActualizar;
        private Button buttonGenerarReporte;
        private Button buttonAtrasOP;
    }
}