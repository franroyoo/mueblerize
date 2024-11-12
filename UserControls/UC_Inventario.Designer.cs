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
            dataGridViewInventario = new DataGridView();
            labelInventario = new Label();
            labelAccionesInventario = new Label();
            buttonNuevoMueble = new Button();
            buttonModificarDatosMueble = new Button();
            buttonEliminarMueble = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Location = new Point(33, 64);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.Size = new Size(617, 565);
            dataGridViewInventario.TabIndex = 4;
            // 
            // labelInventario
            // 
            labelInventario.AutoSize = true;
            labelInventario.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInventario.ForeColor = Color.FromArgb(64, 38, 36);
            labelInventario.Location = new Point(257, 20);
            labelInventario.Name = "labelInventario";
            labelInventario.Size = new Size(174, 41);
            labelInventario.TabIndex = 5;
            labelInventario.Text = "INVENTARIO";
            // 
            // labelAccionesInventario
            // 
            labelAccionesInventario.AutoSize = true;
            labelAccionesInventario.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccionesInventario.ForeColor = Color.FromArgb(64, 38, 36);
            labelAccionesInventario.Location = new Point(787, 95);
            labelAccionesInventario.Name = "labelAccionesInventario";
            labelAccionesInventario.Size = new Size(287, 41);
            labelAccionesInventario.TabIndex = 11;
            labelAccionesInventario.Text = "PANEL DE ACCIONES";
            // 
            // buttonNuevoMueble
            // 
            buttonNuevoMueble.BackColor = Color.Tan;
            buttonNuevoMueble.FlatStyle = FlatStyle.Flat;
            buttonNuevoMueble.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNuevoMueble.Location = new Point(806, 175);
            buttonNuevoMueble.Name = "buttonNuevoMueble";
            buttonNuevoMueble.Size = new Size(241, 64);
            buttonNuevoMueble.TabIndex = 12;
            buttonNuevoMueble.Text = "NUEVO MUEBLE";
            buttonNuevoMueble.UseVisualStyleBackColor = false;
            // 
            // buttonModificarDatosMueble
            // 
            buttonModificarDatosMueble.BackColor = Color.Tan;
            buttonModificarDatosMueble.FlatStyle = FlatStyle.Flat;
            buttonModificarDatosMueble.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonModificarDatosMueble.Location = new Point(806, 275);
            buttonModificarDatosMueble.Name = "buttonModificarDatosMueble";
            buttonModificarDatosMueble.Size = new Size(241, 64);
            buttonModificarDatosMueble.TabIndex = 13;
            buttonModificarDatosMueble.Text = "MODIFICAR DATOS MUEBLE";
            buttonModificarDatosMueble.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarMueble
            // 
            buttonEliminarMueble.BackColor = Color.Tan;
            buttonEliminarMueble.FlatStyle = FlatStyle.Flat;
            buttonEliminarMueble.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarMueble.Location = new Point(806, 377);
            buttonEliminarMueble.Name = "buttonEliminarMueble";
            buttonEliminarMueble.Size = new Size(241, 64);
            buttonEliminarMueble.TabIndex = 14;
            buttonEliminarMueble.Text = "ELIMINAR MUEBLE";
            buttonEliminarMueble.UseVisualStyleBackColor = false;
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
            Size = new Size(1171, 663);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInventario;
        private Label labelInventario;
        private Label labelAccionesInventario;
        private Button buttonNuevoMueble;
        private Button buttonModificarDatosMueble;
        private Button buttonEliminarMueble;
    }
}
