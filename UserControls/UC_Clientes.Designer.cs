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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonNuevoCliente = new Button();
            labelAccionesCliente = new Label();
            labelClientes = new Label();
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // buttonNuevoCliente
            // 
            buttonNuevoCliente.BackColor = Color.Tan;
            buttonNuevoCliente.FlatStyle = FlatStyle.Flat;
            buttonNuevoCliente.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNuevoCliente.Location = new Point(1449, 197);
            buttonNuevoCliente.Name = "buttonNuevoCliente";
            buttonNuevoCliente.Size = new Size(287, 112);
            buttonNuevoCliente.TabIndex = 18;
            buttonNuevoCliente.Text = "NUEVO CLIENTE";
            buttonNuevoCliente.UseVisualStyleBackColor = false;
            buttonNuevoCliente.Click += buttonNuevoCliente_Click;
            // 
            // labelAccionesCliente
            // 
            labelAccionesCliente.AutoSize = true;
            labelAccionesCliente.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccionesCliente.ForeColor = Color.FromArgb(64, 38, 36);
            labelAccionesCliente.Location = new Point(1408, 112);
            labelAccionesCliente.Name = "labelAccionesCliente";
            labelAccionesCliente.Size = new Size(397, 61);
            labelAccionesCliente.TabIndex = 17;
            labelAccionesCliente.Text = "PANEL DE ACCIONES";
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClientes.ForeColor = Color.FromArgb(64, 38, 36);
            labelClientes.Location = new Point(502, 30);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(197, 61);
            labelClientes.TabIndex = 16;
            labelClientes.Text = "CLIENTES";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToResizeColumns = false;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewClientes.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium Cond", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = Color.Bisque;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.GridColor = Color.Black;
            dataGridViewClientes.ImeMode = ImeMode.Off;
            dataGridViewClientes.Location = new Point(141, 112);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(1016, 694);
            dataGridViewClientes.TabIndex = 15;
            dataGridViewClientes.CellClick += dataGridViewClientes_CellClick;
            // 
            // UC_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(buttonNuevoCliente);
            Controls.Add(labelAccionesCliente);
            Controls.Add(labelClientes);
            Controls.Add(dataGridViewClientes);
            Location = new Point(335, 63);
            Name = "UC_Clientes";
            Size = new Size(1924, 901);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonNuevoCliente;
        private Label labelAccionesCliente;
        private Label labelClientes;
        private DataGridView dataGridViewClientes;
    }
}
