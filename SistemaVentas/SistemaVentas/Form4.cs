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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        VentasDataContext ventas = new VentasDataContext();

        private void Form4_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                var consulta = from C in ventas.Boleta
                               select C;

                dgvBoleta.DataSource = consulta.ToList(); // Convierte la consulta a una lista y asigna al DataSource del DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            };

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Boleta boleta = new Boleta();
            try
            {
                boleta.NroBoleta = int.Parse(txtNrodeBoleta.Text);
                boleta.Fecha = DateTime.Parse(txtFecha.Text); // Asumiendo que Fecha es de tipo DateTime
                boleta.CodCliente = txtCodCliente.Text;
                boleta.CodVendedor = txtCodVendedor.Text;
                boleta.Anulado = bool.Parse(txtAnulado.Text); // Conversión a bool (si Anulado es de tipo bool)

                ventas.Boleta.InsertOnSubmit(boleta);
                ventas.SubmitChanges(); // Confirmar la transacción

                txtNrodeBoleta.Clear();
                txtFecha.Clear();
                txtCodVendedor.Clear();
                txtCodCliente.Clear();
                txtAnulado.Clear();
                txtNrodeBoleta.Focus();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

