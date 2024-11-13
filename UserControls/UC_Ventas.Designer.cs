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
            buttonNuevaVenta = new Button();
            labelAccionesVenta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            SuspendLayout();
            // 
            // labelVentas
            // 
            labelVentas.AutoSize = true;
            labelVentas.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVentas.ForeColor = Color.FromArgb(64, 38, 36);
            labelVentas.Location = new Point(502, 30);
            labelVentas.Name = "labelVentas";
            labelVentas.Size = new Size(165, 61);
            labelVentas.TabIndex = 4;
            labelVentas.Text = "VENTAS";
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Location = new Point(141, 112);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.Size = new Size(1016, 694);
            dataGridViewVentas.TabIndex = 3;
            dataGridViewVentas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonNuevaVenta
            // 
            buttonNuevaVenta.BackColor = Color.Tan;
            buttonNuevaVenta.FlatStyle = FlatStyle.Flat;
            buttonNuevaVenta.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNuevaVenta.Location = new Point(1449, 197);
            buttonNuevaVenta.Name = "buttonNuevaVenta";
            buttonNuevaVenta.Size = new Size(287, 112);
            buttonNuevaVenta.TabIndex = 16;
            buttonNuevaVenta.Text = "NUEVA VENTA";
            buttonNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // labelAccionesVenta
            // 
            labelAccionesVenta.AutoSize = true;
            labelAccionesVenta.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccionesVenta.ForeColor = Color.FromArgb(64, 38, 36);
            labelAccionesVenta.Location = new Point(1408, 112);
            labelAccionesVenta.Name = "labelAccionesVenta";
            labelAccionesVenta.Size = new Size(397, 61);
            labelAccionesVenta.TabIndex = 15;
            labelAccionesVenta.Text = "PANEL DE ACCIONES";
            // 
            // UC_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(buttonNuevaVenta);
            Controls.Add(labelAccionesVenta);
            Controls.Add(labelVentas);
            Controls.Add(dataGridViewVentas);
            Name = "UC_Ventas";
            Size = new Size(1924, 901);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVentas;
        private DataGridView dataGridViewVentas;
        private Button buttonNuevaVenta;
        private Label labelAccionesVenta;
    }
}
