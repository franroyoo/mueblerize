namespace Mueblerize.UserControls
{
    partial class UC_Clientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            labelClientes = new Label();
            buttonAgregarNuevoCliente = new Button();
            buttonModificarDatosCliente = new Button();
            buttonEliminarCliente = new Button();
            labelAccionesCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(617, 565);
            dataGridView1.TabIndex = 0;
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClientes.ForeColor = Color.FromArgb(64, 38, 36);
            labelClientes.Location = new Point(257, 20);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(141, 41);
            labelClientes.TabIndex = 2;
            labelClientes.Text = "CLIENTES";
            // 
            // buttonAgregarNuevoCliente
            // 
            buttonAgregarNuevoCliente.BackColor = Color.Tan;
            buttonAgregarNuevoCliente.FlatStyle = FlatStyle.Flat;
            buttonAgregarNuevoCliente.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregarNuevoCliente.Location = new Point(806, 175);
            buttonAgregarNuevoCliente.Name = "buttonAgregarNuevoCliente";
            buttonAgregarNuevoCliente.Size = new Size(241, 64);
            buttonAgregarNuevoCliente.TabIndex = 3;
            buttonAgregarNuevoCliente.Text = "AGREGAR NUEVO CLIENTE";
            buttonAgregarNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // buttonModificarDatosCliente
            // 
            buttonModificarDatosCliente.BackColor = Color.Tan;
            buttonModificarDatosCliente.FlatStyle = FlatStyle.Flat;
            buttonModificarDatosCliente.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonModificarDatosCliente.Location = new Point(806, 294);
            buttonModificarDatosCliente.Name = "buttonModificarDatosCliente";
            buttonModificarDatosCliente.Size = new Size(241, 64);
            buttonModificarDatosCliente.TabIndex = 4;
            buttonModificarDatosCliente.Text = "MODIFICAR DATOS CLIENTE";
            buttonModificarDatosCliente.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.BackColor = Color.Tan;
            buttonEliminarCliente.FlatStyle = FlatStyle.Flat;
            buttonEliminarCliente.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarCliente.Location = new Point(806, 431);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(241, 64);
            buttonEliminarCliente.TabIndex = 5;
            buttonEliminarCliente.Text = "ELIMINAR CLIENTE";
            buttonEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // labelAccionesCliente
            // 
            labelAccionesCliente.AutoSize = true;
            labelAccionesCliente.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccionesCliente.ForeColor = Color.FromArgb(64, 38, 36);
            labelAccionesCliente.Location = new Point(787, 95);
            labelAccionesCliente.Name = "labelAccionesCliente";
            labelAccionesCliente.Size = new Size(287, 41);
            labelAccionesCliente.TabIndex = 6;
            labelAccionesCliente.Text = "PANEL DE ACCIONES";
            // 
            // UC_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(labelAccionesCliente);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(buttonModificarDatosCliente);
            Controls.Add(buttonAgregarNuevoCliente);
            Controls.Add(labelClientes);
            Controls.Add(dataGridView1);
            Location = new Point(335, 63);
            Name = "UC_Clientes";
            Size = new Size(1171, 663);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelClientes;
        private Button buttonAgregarNuevoCliente;
        private Button buttonModificarDatosCliente;
        private Button buttonEliminarCliente;
        private Label labelAccionesCliente;
    }
}
