namespace Mueblerize.UserControls
{
    partial class UC_Ventas
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
            labelVentas = new Label();
            dataGridViewVentas = new DataGridView();
            labelAccionesVentas = new Label();
            buttonNuevaVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            SuspendLayout();
            // 
            // labelVentas
            // 
            labelVentas.AutoSize = true;
            labelVentas.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVentas.ForeColor = Color.FromArgb(64, 38, 36);
            labelVentas.Location = new Point(257, 20);
            labelVentas.Name = "labelVentas";
            labelVentas.Size = new Size(118, 41);
            labelVentas.TabIndex = 4;
            labelVentas.Text = "VENTAS";
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Location = new Point(33, 64);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.Size = new Size(617, 565);
            dataGridViewVentas.TabIndex = 3;
            dataGridViewVentas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelAccionesVentas
            // 
            labelAccionesVentas.AutoSize = true;
            labelAccionesVentas.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccionesVentas.ForeColor = Color.FromArgb(64, 38, 36);
            labelAccionesVentas.Location = new Point(787, 95);
            labelAccionesVentas.Name = "labelAccionesVentas";
            labelAccionesVentas.Size = new Size(287, 41);
            labelAccionesVentas.TabIndex = 10;
            labelAccionesVentas.Text = "PANEL DE ACCIONES";
            // 
            // buttonNuevaVenta
            // 
            buttonNuevaVenta.BackColor = Color.Tan;
            buttonNuevaVenta.FlatStyle = FlatStyle.Flat;
            buttonNuevaVenta.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNuevaVenta.Location = new Point(806, 175);
            buttonNuevaVenta.Name = "buttonNuevaVenta";
            buttonNuevaVenta.Size = new Size(241, 64);
            buttonNuevaVenta.TabIndex = 7;
            buttonNuevaVenta.Text = "NUEVA VENTA";
            buttonNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // UC_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(labelAccionesVentas);
            Controls.Add(buttonNuevaVenta);
            Controls.Add(labelVentas);
            Controls.Add(dataGridViewVentas);
            Name = "UC_Ventas";
            Size = new Size(1171, 663);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVentas;
        private DataGridView dataGridViewVentas;
        private Label labelAccionesVentas;
        private Button buttonNuevaVenta;
    }
}
