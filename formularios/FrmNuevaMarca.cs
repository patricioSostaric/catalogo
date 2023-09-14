using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace formularios
{
    public partial class FrmNuevaMarca : Form
    {
        List<Marca> listaMarcas = new List<Marca>();
        public FrmNuevaMarca()
        {
            InitializeComponent();
        }

        private void FrmNuevaMarca_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }
        private void cargarMarcas()
        {
            try
            {
                MarcaNegocio marcas = new MarcaNegocio();

                listaMarcas = marcas.listar();
                dgvMarcas.DataSource = listaMarcas;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnAgregarNew_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (negocio.validarCampos(txtMarcAgr.Text))
                {
                    MessageBox.Show("Debe ingresar una marca");
                    return;
                }
                if (negocio.validarLetras(txtMarcAgr.Text))
                {
                    MessageBox.Show("Ingrese letras, por favor");
                    txtMarcAgr.Text = "";
                    return;
                }
                marca.Descripcion1 = txtMarcAgr.Text;

                bool existe = negocio.chequear(listaMarcas, marca.Descripcion1);
                if (!existe)
                {
                    negocio.agregarMarca(marca);
                    MessageBox.Show("Marca agregada con exito");
                    cargarMarcas();
                }
                else
                {
                    MessageBox.Show("La marca ya existe");
                }

                txtMarcAgr.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca marcaBorrar;

            try
            {
                DialogResult consulta = MessageBox.Show("Eliminas esta marca?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (consulta == DialogResult.OK)
                {
                    marcaBorrar = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(marcaBorrar);
                    cargarMarcas();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

