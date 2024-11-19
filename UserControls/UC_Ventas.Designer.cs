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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelVentas = new Label();
            buttonNuevaVenta = new Button();
            labelAccionesVenta = new Label();
            dataGridViewVentas = new DataGridView();
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
            buttonNuevaVenta.Click += buttonNuevaVenta_Click;
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
            // dataGridViewVentas
            // 
            dataGridViewVentas.AllowUserToAddRows = false;
            dataGridViewVentas.AllowUserToDeleteRows = false;
            dataGridViewVentas.AllowUserToResizeColumns = false;
            dataGridViewVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewVentas.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium Cond", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = Color.Bisque;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewVentas.EnableHeadersVisualStyles = false;
            dataGridViewVentas.GridColor = Color.Black;
            dataGridViewVentas.ImeMode = ImeMode.Off;
            dataGridViewVentas.Location = new Point(141, 112);
            dataGridViewVentas.MultiSelect = false;
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVentas.Size = new Size(1016, 694);
            dataGridViewVentas.TabIndex = 17;
            // 
            // UC_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(dataGridViewVentas);
            Controls.Add(buttonNuevaVenta);
            Controls.Add(labelAccionesVenta);
            Controls.Add(labelVentas);
            Name = "UC_Ventas";
            Size = new Size(1924, 901);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVentas;
        private Button buttonNuevaVenta;
        private Label labelAccionesVenta;
        private DataGridView dataGridViewVentas;
    }
}
