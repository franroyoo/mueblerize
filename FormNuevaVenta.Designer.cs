namespace Mueblerize
{
    partial class FormNuevaVenta
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonRegistrarVenta = new Button();
            buttonAgregarItemVenta = new Button();
            dataGridViewMueblesVenta = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBoxCantidadItemVenta = new TextBox();
            comboBoxTipoMaderaVenta = new ComboBox();
            comboBoxTipoMuebleVenta = new ComboBox();
            label3 = new Label();
            textBoxDniClienteVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMueblesVenta).BeginInit();
            SuspendLayout();
            // 
            // buttonRegistrarVenta
            // 
            buttonRegistrarVenta.BackColor = Color.BurlyWood;
            buttonRegistrarVenta.FlatStyle = FlatStyle.Flat;
            buttonRegistrarVenta.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegistrarVenta.Location = new Point(163, 737);
            buttonRegistrarVenta.Name = "buttonRegistrarVenta";
            buttonRegistrarVenta.Size = new Size(362, 78);
            buttonRegistrarVenta.TabIndex = 27;
            buttonRegistrarVenta.Text = "REGISTRAR VENTA";
            buttonRegistrarVenta.UseVisualStyleBackColor = false;
            buttonRegistrarVenta.Click += buttonRegistrarVenta_Click;
            // 
            // buttonAgregarItemVenta
            // 
            buttonAgregarItemVenta.BackColor = Color.BurlyWood;
            buttonAgregarItemVenta.FlatStyle = FlatStyle.Flat;
            buttonAgregarItemVenta.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregarItemVenta.Location = new Point(651, 116);
            buttonAgregarItemVenta.Name = "buttonAgregarItemVenta";
            buttonAgregarItemVenta.Size = new Size(149, 78);
            buttonAgregarItemVenta.TabIndex = 26;
            buttonAgregarItemVenta.Text = "AGREGAR ITEM";
            buttonAgregarItemVenta.UseVisualStyleBackColor = false;
            buttonAgregarItemVenta.Click += buttonAgregarItemVenta_Click;
            // 
            // dataGridViewMueblesVenta
            // 
            dataGridViewMueblesVenta.AllowUserToAddRows = false;
            dataGridViewMueblesVenta.AllowUserToDeleteRows = false;
            dataGridViewMueblesVenta.AllowUserToResizeColumns = false;
            dataGridViewMueblesVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewMueblesVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMueblesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMueblesVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMueblesVenta.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium Cond", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = Color.Bisque;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMueblesVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMueblesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMueblesVenta.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewMueblesVenta.EnableHeadersVisualStyles = false;
            dataGridViewMueblesVenta.GridColor = Color.Black;
            dataGridViewMueblesVenta.ImeMode = ImeMode.Off;
            dataGridViewMueblesVenta.Location = new Point(53, 230);
            dataGridViewMueblesVenta.MultiSelect = false;
            dataGridViewMueblesVenta.Name = "dataGridViewMueblesVenta";
            dataGridViewMueblesVenta.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMueblesVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMueblesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMueblesVenta.Size = new Size(598, 479);
            dataGridViewMueblesVenta.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Wheat;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(499, 116);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 24;
            label2.Text = "CANTIDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(279, 116);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(134, 26);
            label1.TabIndex = 23;
            label1.Text = "TIPO DE MADERA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Wheat;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(53, 116);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(132, 26);
            label4.TabIndex = 22;
            label4.Text = "TIPO DE MUEBLE";
            // 
            // textBoxCantidadItemVenta
            // 
            textBoxCantidadItemVenta.Location = new Point(499, 171);
            textBoxCantidadItemVenta.Name = "textBoxCantidadItemVenta";
            textBoxCantidadItemVenta.Size = new Size(85, 23);
            textBoxCantidadItemVenta.TabIndex = 21;
            // 
            // comboBoxTipoMaderaVenta
            // 
            comboBoxTipoMaderaVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoMaderaVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoMaderaVenta.FormattingEnabled = true;
            comboBoxTipoMaderaVenta.Location = new Point(279, 171);
            comboBoxTipoMaderaVenta.Name = "comboBoxTipoMaderaVenta";
            comboBoxTipoMaderaVenta.Size = new Size(134, 29);
            comboBoxTipoMaderaVenta.TabIndex = 20;
            // 
            // comboBoxTipoMuebleVenta
            // 
            comboBoxTipoMuebleVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoMuebleVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoMuebleVenta.FormattingEnabled = true;
            comboBoxTipoMuebleVenta.Location = new Point(53, 171);
            comboBoxTipoMuebleVenta.Name = "comboBoxTipoMuebleVenta";
            comboBoxTipoMuebleVenta.Size = new Size(132, 29);
            comboBoxTipoMuebleVenta.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Wheat;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(53, 38);
            label3.Margin = new Padding(4);
            label3.Name = "label3";
            label3.Size = new Size(102, 26);
            label3.TabIndex = 28;
            label3.Text = "DNI CLIENTE";
            // 
            // textBoxDniClienteVenta
            // 
            textBoxDniClienteVenta.Location = new Point(172, 41);
            textBoxDniClienteVenta.Name = "textBoxDniClienteVenta";
            textBoxDniClienteVenta.Size = new Size(100, 23);
            textBoxDniClienteVenta.TabIndex = 29;
            // 
            // FormNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(817, 835);
            Controls.Add(textBoxDniClienteVenta);
            Controls.Add(label3);
            Controls.Add(buttonRegistrarVenta);
            Controls.Add(buttonAgregarItemVenta);
            Controls.Add(dataGridViewMueblesVenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBoxCantidadItemVenta);
            Controls.Add(comboBoxTipoMaderaVenta);
            Controls.Add(comboBoxTipoMuebleVenta);
            Name = "FormNuevaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva venta";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMueblesVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegistrarVenta;
        private Button buttonAgregarItemVenta;
        private DataGridView dataGridViewMueblesVenta;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBoxCantidadItemVenta;
        private ComboBox comboBoxTipoMaderaVenta;
        private ComboBox comboBoxTipoMuebleVenta;
        private Label label3;
        private TextBox textBoxDniClienteVenta;
    }
}