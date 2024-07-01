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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Llamar al mapeado objeto relacional a través de un objeto 
        VentasDataContext ventas = new VentasDataContext();

        // Crear procedimiento para listar la tabla Cliente
        public void ListarClientes()
        {
            var consulta = from C in ventas.Cliente
                           select C;
            dgvClientes.DataSource = consulta;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }


        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            Cliente clienteAgregar = new Cliente();
            clienteAgregar.Apellidos = txtApellidoCliente.Text;
            clienteAgregar.Nombres = txtNombreCliente.Text;
            clienteAgregar.CodCliente = txtCodCliente.Text;
            clienteAgregar.Direccion = txtDireccionCliente.Text;
            ventas.Cliente.InsertOnSubmit(clienteAgregar);
            try
            {
                ventas.SubmitChanges(); // Confirma la transacción
                txtCodCliente.Clear(); txtNombreCliente.Clear(); txtApellidoCliente.Clear(); txtDireccionCliente.Clear();
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            // Obtener el código del cliente a eliminar
            var CodClienteEliminar = (from C in ventas.Cliente
                                      where C.CodCliente.Contains(txtCodCliente.Text)
                                      select C).First();

            ventas.Cliente.DeleteOnSubmit(CodClienteEliminar);
            try
            {
                ventas.SubmitChanges(); // Confirma la eliminación
                txtCodCliente.Clear(); txtNombreCliente.Clear(); txtApellidoCliente.Clear(); txtDireccionCliente.Clear();
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }







        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            // Buscar el cliente a actualizar
            var clienteActualizar = (from C in ventas.Cliente
                                     where C.CodCliente.Contains(txtCodCliente.Text)
                                     select C).First();

            if (clienteActualizar != null)
            {
                // Actualizar los campos del cliente
                clienteActualizar.Nombres = txtNombreCliente.Text.Trim();
                clienteActualizar.Apellidos = txtApellidoCliente.Text.Trim();
                clienteActualizar.Direccion = txtDireccionCliente.Text.Trim();

                try
                {
                    ventas.SubmitChanges(); // Confirmar los cambios
                    MessageBox.Show("Cliente actualizado correctamente.");
                    txtCodCliente.Clear(); txtNombreCliente.Clear(); txtApellidoCliente.Clear(); txtDireccionCliente.Clear();
                    ListarClientes(); // Actualizar la lista de clientes en la interfaz
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

