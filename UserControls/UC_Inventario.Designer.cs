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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelInventario = new Label();
            labelAccionesInventario = new Label();
            buttonNuevoIngreso = new Button();
            buttonModificarDatosMueble = new Button();
            dataGridViewMuebles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuebles).BeginInit();
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
            buttonModificarDatosMueble.Click += buttonModificarDatosMueble_Click;
            // 
            // dataGridViewMuebles
            // 
            dataGridViewMuebles.AllowUserToAddRows = false;
            dataGridViewMuebles.AllowUserToDeleteRows = false;
            dataGridViewMuebles.AllowUserToResizeColumns = false;
            dataGridViewMuebles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewMuebles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMuebles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMuebles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMuebles.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium Cond", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = Color.Bisque;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMuebles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMuebles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMuebles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewMuebles.EnableHeadersVisualStyles = false;
            dataGridViewMuebles.GridColor = Color.Black;
            dataGridViewMuebles.ImeMode = ImeMode.Off;
            dataGridViewMuebles.Location = new Point(141, 112);
            dataGridViewMuebles.MultiSelect = false;
            dataGridViewMuebles.Name = "dataGridViewMuebles";
            dataGridViewMuebles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMuebles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMuebles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMuebles.Size = new Size(1016, 694);
            dataGridViewMuebles.TabIndex = 16;
            dataGridViewMuebles.CellClick += dataGridViewMuebles_CellClick;
            // 
            // UC_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(dataGridViewMuebles);
            Controls.Add(buttonModificarDatosMueble);
            Controls.Add(buttonNuevoIngreso);
            Controls.Add(labelAccionesInventario);
            Controls.Add(labelInventario);
            Name = "UC_Inventario";
            Size = new Size(1924, 901);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuebles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelInventario;
        private Label labelAccionesInventario;
        private Button buttonNuevoIngreso;
        private Button buttonModificarDatosMueble;
        private DataGridView dataGridViewMuebles;
    }
}
