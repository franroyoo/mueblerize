using Mueblerize.UserControls;

namespace Mueblerize
{
    public partial class Form1 : Form
    {
        private static int DEFAULT_FONT_SIZE = 18;
        private static int HOVERED_FONT_SIZE = 22;
        public Form1()
        {
            InitializeComponent();
            UC_Inicio inicio = new UC_Inicio();
            AgregarUserControl(inicio);
        }

        // Metodo helper para mostrar los user control
        private void AgregarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }

        // Metodo helper para actualizar UI de los botones superiores
        private void ActualizarUIBotonesPrincipales()
        {
            button1.Font = new Font(button1.Font.FontFamily, DEFAULT_FONT_SIZE, FontStyle.Regular);
            button2.Font = new Font(button2.Font.FontFamily, DEFAULT_FONT_SIZE, FontStyle.Regular);
            button3.Font = new Font(button3.Font.FontFamily, DEFAULT_FONT_SIZE, FontStyle.Regular);
            button4.Font = new Font(button4.Font.FontFamily, DEFAULT_FONT_SIZE, FontStyle.Regular);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Inicio
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarUIBotonesPrincipales(); 
            button1.Font = new Font(button1.Font.FontFamily, HOVERED_FONT_SIZE, FontStyle.Bold);
            UC_Inicio inicio = new UC_Inicio();
            AgregarUserControl(inicio);

        }

        // Clientes
        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarUIBotonesPrincipales();
            button2.Font = new Font(button2.Font.FontFamily,HOVERED_FONT_SIZE, FontStyle.Bold);
            UC_Clientes clientes = new UC_Clientes();
            AgregarUserControl(clientes);
        }

        // Ventas
        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarUIBotonesPrincipales();
            button3.Font = new Font(button3.Font.FontFamily, HOVERED_FONT_SIZE, FontStyle.Bold);
            UC_Ventas ventas = new UC_Ventas();
            AgregarUserControl(ventas);
        }

        // Inventario
        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarUIBotonesPrincipales();
            button4.Font = new Font(button4.Font.FontFamily,HOVERED_FONT_SIZE, FontStyle.Bold);
            UC_Inventario inventario = new UC_Inventario();
            AgregarUserControl(inventario);
        }
    }
}
