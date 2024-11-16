namespace Mueblerize
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelMueblerize = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 38, 36);
            panel1.Controls.Add(labelMueblerize);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 89);
            panel1.TabIndex = 0;
            // 
            // labelMueblerize
            // 
            labelMueblerize.AutoSize = true;
            labelMueblerize.Font = new Font("Franklin Gothic Medium Cond", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMueblerize.ForeColor = Color.AntiqueWhite;
            labelMueblerize.Location = new Point(733, 5);
            labelMueblerize.Name = "labelMueblerize";
            labelMueblerize.Size = new Size(448, 81);
            labelMueblerize.TabIndex = 0;
            labelMueblerize.Text = "M U E B L E R I Z E";
            labelMueblerize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 71);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.Dock = DockStyle.Left;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(1450, 0);
            button4.Name = "button4";
            button4.Size = new Size(474, 71);
            button4.TabIndex = 3;
            button4.Text = "MUEBLES";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.Dock = DockStyle.Left;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(998, 0);
            button3.Name = "button3";
            button3.Size = new Size(452, 71);
            button3.TabIndex = 2;
            button3.Text = "VENTAS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.Dock = DockStyle.Left;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(495, 0);
            button2.Name = "button2";
            button2.Size = new Size(503, 71);
            button2.TabIndex = 1;
            button2.Text = "CLIENTES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(495, 71);
            button1.TabIndex = 0;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.AntiqueWhite;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 160);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1924, 901);
            panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panelContainer;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label labelMueblerize;
    }
}
