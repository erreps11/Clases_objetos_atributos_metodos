using laboratorio07;

namespace Laboratorio07
{
    public partial class Form1 : Form
    {
        Arquietecto arquietecto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipoAfiliacion.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            cboCondicionContrato.SelectedIndex = 0;
            cboTipoActividad.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string condicionContrato = cboCondicionContrato.Text;
            string especialidad = cboEspecialidad.Text;
            string tipoActividad = cboTipoActividad.Text;
            string afiliacion = cboTipoAfiliacion.Text;
            //decimal sueldo = decimal.Parse(txtSueldo.Text);
            //decimal horasExtras = decimal.Parse(txtHorasExtras.Text);
            //string area = cboArea.Text;

            arquietecto = new Arquietecto(codigo, nombre, condicionContrato, especialidad, tipoActividad, afiliacion);
            MessageBox.Show("Objeto Creado");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
