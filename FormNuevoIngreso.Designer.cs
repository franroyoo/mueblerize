namespace Mueblerize
{
    partial class FormNuevoIngreso
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
            comboBoxTipoMueble = new ComboBox();
            comboBoxTipoMadera = new ComboBox();
            textBoxCantidadItem = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridViewIngreso = new DataGridView();
            buttonAgregarIngresoForm = new Button();
            buttonRegistrarIngreso = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngreso).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTipoMueble
            // 
            comboBoxTipoMueble.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoMueble.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoMueble.FormattingEnabled = true;
            comboBoxTipoMueble.Location = new Point(80, 79);
            comboBoxTipoMueble.Name = "comboBoxTipoMueble";
            comboBoxTipoMueble.Size = new Size(132, 29);
            comboBoxTipoMueble.TabIndex = 3;
            // 
            // comboBoxTipoMadera
            // 
            comboBoxTipoMadera.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoMadera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoMadera.FormattingEnabled = true;
            comboBoxTipoMadera.Location = new Point(306, 79);
            comboBoxTipoMadera.Name = "comboBoxTipoMadera";
            comboBoxTipoMadera.Size = new Size(134, 29);
            comboBoxTipoMadera.TabIndex = 4;
            // 
            // textBoxCantidadItem
            // 
            textBoxCantidadItem.Location = new Point(526, 79);
            textBoxCantidadItem.Name = "textBoxCantidadItem";
            textBoxCantidadItem.Size = new Size(85, 23);
            textBoxCantidadItem.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Wheat;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(80, 24);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(132, 26);
            label4.TabIndex = 6;
            label4.Text = "TIPO DE MUEBLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(306, 24);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(134, 26);
            label1.TabIndex = 7;
            label1.Text = "TIPO DE MADERA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Wheat;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(526, 24);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 8;
            label2.Text = "CANTIDAD";
            // 
            // dataGridViewIngreso
            // 
            dataGridViewIngreso.AllowUserToAddRows = false;
            dataGridViewIngreso.AllowUserToDeleteRows = false;
            dataGridViewIngreso.AllowUserToResizeColumns = false;
            dataGridViewIngreso.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewIngreso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewIngreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIngreso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewIngreso.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium Cond", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = Color.Bisque;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewIngreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngreso.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewIngreso.EnableHeadersVisualStyles = false;
            dataGridViewIngreso.GridColor = Color.Black;
            dataGridViewIngreso.ImeMode = ImeMode.Off;
            dataGridViewIngreso.Location = new Point(80, 138);
            dataGridViewIngreso.MultiSelect = false;
            dataGridViewIngreso.Name = "dataGridViewIngreso";
            dataGridViewIngreso.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewIngreso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewIngreso.Size = new Size(598, 479);
            dataGridViewIngreso.TabIndex = 16;
            dataGridViewIngreso.CellClick += dataGridViewIngreso_CellClick;
            // 
            // buttonAgregarIngresoForm
            // 
            buttonAgregarIngresoForm.BackColor = Color.BurlyWood;
            buttonAgregarIngresoForm.FlatStyle = FlatStyle.Flat;
            buttonAgregarIngresoForm.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregarIngresoForm.Location = new Point(678, 24);
            buttonAgregarIngresoForm.Name = "buttonAgregarIngresoForm";
            buttonAgregarIngresoForm.Size = new Size(149, 78);
            buttonAgregarIngresoForm.TabIndex = 17;
            buttonAgregarIngresoForm.Text = "AGREGAR ITEM";
            buttonAgregarIngresoForm.UseVisualStyleBackColor = false;
            buttonAgregarIngresoForm.Click += buttonAgregarIngresoForm_Click;
            // 
            // buttonRegistrarIngreso
            // 
            buttonRegistrarIngreso.BackColor = Color.BurlyWood;
            buttonRegistrarIngreso.FlatStyle = FlatStyle.Flat;
            buttonRegistrarIngreso.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegistrarIngreso.Location = new Point(190, 645);
            buttonRegistrarIngreso.Name = "buttonRegistrarIngreso";
            buttonRegistrarIngreso.Size = new Size(362, 78);
            buttonRegistrarIngreso.TabIndex = 18;
            buttonRegistrarIngreso.Text = "REGISTRAR INGRESO";
            buttonRegistrarIngreso.UseVisualStyleBackColor = false;
            buttonRegistrarIngreso.Click += buttonRegistrarIngreso_Click;
            // 
            // FormNuevoIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(853, 781);
            Controls.Add(buttonRegistrarIngreso);
            Controls.Add(buttonAgregarIngresoForm);
            Controls.Add(dataGridViewIngreso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBoxCantidadItem);
            Controls.Add(comboBoxTipoMadera);
            Controls.Add(comboBoxTipoMueble);
            Name = "FormNuevoIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo ingreso";
            FormClosing += FormNuevoIngreso_FormClosing;
            FormClosed += FormNuevoIngreso_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngreso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxTipoMueble;
        private ComboBox comboBoxTipoMadera;
        private TextBox textBoxCantidadItem;
        private Label label4;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewIngreso;
        private Button buttonAgregarIngresoForm;
        private Button buttonRegistrarIngreso;
    }
}