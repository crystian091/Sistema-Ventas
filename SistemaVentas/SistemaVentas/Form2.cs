using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        VentasDataContext ventas = new VentasDataContext();

        private void Form2_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                var consulta = from C in ventas.Cliente
                               select C;

                dgvClientes.DataSource = consulta.ToList(); // Convierte la consulta a una lista y asigna al DataSource del DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            };

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var consulta = from C in ventas.Cliente
                           select C;
            dgvClientes.DataSource = consulta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var consulta = from C in ventas.Producto
                           select new
                           {
                               C.CodProduto,
                           };
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            var consulta = from C in ventas.Cliente
                           select new
                           {
                               C.CodCliente,
                               C.Apellidos,
                               C.Nombres,
                           };
            dgvClientes.DataSource = consulta;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
