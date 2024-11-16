namespace Mueblerize.UserControls
{
    partial class UC_Inventario
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
            labelInventario = new Label();
            labelAccionesInventario = new Label();
            buttonNuevoIngreso = new Button();
            buttonModificarDatosMueble = new Button();
            buttonEliminarMueble = new Button();
            dataGridViewInventario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).BeginInit();
            SuspendLayout();
            // 
            // labelInventario
            // 
            labelInventario.AutoSize = true;
            labelInventario.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInventario.ForeColor = Color.FromArgb(64, 38, 36);
            labelInventario.Location = new Point(502, 30);
            labelInventario.Name = "labelInventario";
            labelInventario.Size = new Size(202, 61);
            labelInventario.TabIndex = 5;
            labelInventario.Text = "MUEBLES";
            // 
            // labelAccionesInventario
            // 
            labelAccionesInventario.AutoSize = true;
            labelAccionesInventario.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccionesInventario.ForeColor = Color.FromArgb(64, 38, 36);
            labelAccionesInventario.Location = new Point(1408, 112);
            labelAccionesInventario.Name = "labelAccionesInventario";
            labelAccionesInventario.Size = new Size(397, 61);
            labelAccionesInventario.TabIndex = 11;
            labelAccionesInventario.Text = "PANEL DE ACCIONES";
            // 
            // buttonNuevoIngreso
            // 
            buttonNuevoIngreso.BackColor = Color.Tan;
            buttonNuevoIngreso.FlatStyle = FlatStyle.Flat;
            buttonNuevoIngreso.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNuevoIngreso.Location = new Point(1449, 197);
            buttonNuevoIngreso.Name = "buttonNuevoIngreso";
            buttonNuevoIngreso.Size = new Size(287, 112);
            buttonNuevoIngreso.TabIndex = 12;
            buttonNuevoIngreso.Text = "REGISTRAR NUEVO INGRESO";
            buttonNuevoIngreso.UseVisualStyleBackColor = false;
            buttonNuevoIngreso.Click += buttonNuevoIngreso_Click;
            // 
            // buttonModificarDatosMueble
            // 
            buttonModificarDatosMueble.BackColor = Color.Tan;
            buttonModificarDatosMueble.FlatStyle = FlatStyle.Flat;
            buttonModificarDatosMueble.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonModificarDatosMueble.Location = new Point(1449, 369);
            buttonModificarDatosMueble.Name = "buttonModificarDatosMueble";
            buttonModificarDatosMueble.Size = new Size(287, 112);
            buttonModificarDatosMueble.TabIndex = 13;
            buttonModificarDatosMueble.Text = "MODIFICAR PRECIOS";
            buttonModificarDatosMueble.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarMueble
            // 
            buttonEliminarMueble.BackColor = Color.Tan;
            buttonEliminarMueble.FlatStyle = FlatStyle.Flat;
            buttonEliminarMueble.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarMueble.Location = new Point(1449, 536);
            buttonEliminarMueble.Name = "buttonEliminarMueble";
            buttonEliminarMueble.Size = new Size(287, 112);
            buttonEliminarMueble.TabIndex = 14;
            buttonEliminarMueble.Text = "ELIMINAR MUEBLE";
            buttonEliminarMueble.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Location = new Point(141, 112);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.Size = new Size(1016, 694);
            dataGridViewInventario.TabIndex = 4;
            // 
            // UC_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(buttonEliminarMueble);
            Controls.Add(buttonModificarDatosMueble);
            Controls.Add(buttonNuevoIngreso);
            Controls.Add(labelAccionesInventario);
            Controls.Add(labelInventario);
            Controls.Add(dataGridViewInventario);
            Name = "UC_Inventario";
            Size = new Size(1924, 901);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelInventario;
        private Label labelAccionesInventario;
        private Button buttonNuevoIngreso;
        private Button buttonModificarDatosMueble;
        private Button buttonEliminarMueble;
        private DataGridView dataGridViewInventario;
    }
}
