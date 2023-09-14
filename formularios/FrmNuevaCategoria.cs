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
    public partial class FrmNuevaCategoria : Form
    {
        List<Categoria> listaCategorias = new List<Categoria>();
        public FrmNuevaCategoria()
        {
            InitializeComponent();
        }

        private void FrmNuevaCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }
        private void cargarCategorias()
        {
            try
            {
                CategoriaNegocio categorias = new CategoriaNegocio();
                listaCategorias = categorias.listar();
                dgvCategorias.DataSource = listaCategorias;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (negocio.validarCampos(txtCateg.Text))
                {
                    MessageBox.Show("Debe ingresar una categoría");
                    return;
                }
                if (negocio.validarLetras(txtCateg.Text))
                {
                    MessageBox.Show("Ingrese letras, por favor");
                    txtCateg.Text = "";
                    return;
                }
                categoria.Descripcion1 = txtCateg.Text;
                bool existe = negocio.chequear(listaCategorias, categoria.Descripcion1);
                if (!existe)
                {
                    negocio.agregarCat(categoria);
                    MessageBox.Show("Categoría agregada con exito");
                    cargarCategorias();
                }
                else
                {
                    MessageBox.Show("La categoría ya existe"); ;
                }
                txtCateg.Text = "";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categPorBorrar;
            try
            {
                DialogResult consulta = MessageBox.Show("Eliminas esta categoría?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (consulta == DialogResult.OK)
                {
                    categPorBorrar = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminarCat(categPorBorrar);
                    cargarCategorias();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
