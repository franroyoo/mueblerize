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
            buttonNuevoMueble = new Button();
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
            labelInventario.Size = new Size(241, 61);
            labelInventario.TabIndex = 5;
            labelInventario.Text = "INVENTARIO";
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
            // buttonNuevoMueble
            // 
            buttonNuevoMueble.BackColor = Color.Tan;
            buttonNuevoMueble.FlatStyle = FlatStyle.Flat;
            buttonNuevoMueble.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNuevoMueble.Location = new Point(1449, 197);
            buttonNuevoMueble.Name = "buttonNuevoMueble";
            buttonNuevoMueble.Size = new Size(287, 112);
            buttonNuevoMueble.TabIndex = 12;
            buttonNuevoMueble.Text = "NUEVO MUEBLE";
            buttonNuevoMueble.UseVisualStyleBackColor = false;
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
            buttonModificarDatosMueble.Text = "MODIFICAR DATOS MUEBLE";
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
            Controls.Add(buttonNuevoMueble);
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
        private Button buttonNuevoMueble;
        private Button buttonModificarDatosMueble;
        private Button buttonEliminarMueble;
        private DataGridView dataGridViewInventario;
    }
}
