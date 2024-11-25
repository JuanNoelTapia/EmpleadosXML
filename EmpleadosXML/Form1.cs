namespace EmpleadosXML
{
    public partial class Form1 : Form
    {
        private List<Empleado> empleados = new List<Empleado>();
        private string archivoXml = "empleados.xml";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(archivoXml))
            {
                empleados = Xml.LeerDesdeXml<Empleado>(archivoXml);
                ActualizarLista();
            }
        }

        private void AgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id) &&
               int.TryParse(txtEdad.Text, out int edad) &&
               !string.IsNullOrWhiteSpace(txtNombre.Text) &&
               !string.IsNullOrWhiteSpace(txtApellido.Text) &&
               !string.IsNullOrWhiteSpace(txtPuesto.Text))
            {
                Empleado nuevoEmpleado = new Empleado
                {
                    ID = id,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = edad,
                    Puesto = txtPuesto.Text
                };

                empleados.Add(nuevoEmpleado);
                ActualizarLista();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
            }
        }

        private void GuardarEmpleado_Click(object sender, EventArgs e)
        {
            Xml.GuardarEnXml(empleados, archivoXml);
            MessageBox.Show("Empleados guardados en XML.");
        }

        private void CargarEmpleado_Click(object sender, EventArgs e)
        {
            empleados = Xml.LeerDesdeXml<Empleado>(archivoXml);
            ActualizarLista();
            MessageBox.Show("Empleados cargados desde XML.");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ActualizarLista()
        {
            ListaEmpleados.Items.Clear();
            foreach (var empleado in empleados)
            {
                ListaEmpleados.Items.Add($"{empleado.ID} - {empleado.Nombre} {empleado.Apellido}, {empleado.Edad} años, Puesto: {empleado.Puesto}");
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPuesto.Clear();
        }

        private void LimpiarLista_Click(object sender, EventArgs e)
        {
            // Limpiar la lista en memoria
            empleados.Clear();

            // Actualizar la interfaz para reflejar los cambios
            ListaEmpleados.Items.Clear();

            // Mensaje de confirmación
            MessageBox.Show("La lista ha sido limpiada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
