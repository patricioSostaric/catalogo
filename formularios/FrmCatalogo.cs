using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace formularios
{
    public partial class FrmCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            Cargar();
            cmbCampo.Items.Add("Código");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Descripción");
            cmbCampo.Items.Add("Precio");
        }
        private void ColumnaDecimales()
        {
            dgvListaArt.Columns["Precio"].DefaultCellStyle.Format = "0.00";
        }
        private void OcultarColumnas()
        {
            dgvListaArt.Columns["id"].Visible = false;
            dgvListaArt.Columns["imagenUrl"].Visible = false;
        }
        private void Cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();

                listaArticulos = negocio.listar();
                dgvListaArt.DataSource = listaArticulos;
                OcultarColumnas();
                CargarImagen(listaArticulos[0].ImagenUrl);
                ColumnaDecimales();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }

        }

        private void dgvListaArt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaArt.CurrentRow != null)
            {
                Articulo select = (Articulo)dgvListaArt.CurrentRow.DataBoundItem;
                CargarImagen(select.ImagenUrl);
                CargarDatos(select);
            }
        }
        private void CargarDatos(Articulo art)
        {
            lblNombreSelec.Text = "Nombre: " + art.Nombre;
            lblDescSelec.Text = "Descripción: " + art.Descripcion;
            lblMarcaSelec.Text = "Marca: " + art.Marca;
            lblPrecioSelec.Text = "Precio: " + art.Precio.ToString("0.00");
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://rastro.com/fotos3/2021/10/18/11748542_foto1.jpg ");

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevoArticulo nuevoArticulo = new FrmNuevoArticulo();
            nuevoArticulo.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo selecionado;
            selecionado = (Articulo)dgvListaArt.CurrentRow.DataBoundItem;
            FrmNuevoArticulo modificar = new FrmNuevoArticulo(selecionado);
            modificar.ShowDialog();
            Cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo selecionado;
            try
            {
                DialogResult consulta = MessageBox.Show("Eliminas este producto?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (consulta == DialogResult.Yes)
                {
                    selecionado = (Articulo)dgvListaArt.CurrentRow.DataBoundItem;
                    negocio.eliminar(selecionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eleccion = cmbCampo.SelectedItem.ToString();

            if (eleccion == "Precio")
            {
                cmbCriterio.Items.Clear();
                txtFiltroAvanz.Text = "";
                cmbCriterio.Items.Add("Mayor a ");
                cmbCriterio.Items.Add("Menor a ");
                cmbCriterio.Items.Add("Igual a ");
                Cargar();
            }
            else
            {
                cmbCriterio.Items.Clear();
                txtFiltroAvanz.Text = "";
                cmbCriterio.Items.Add("Comienza con ");
                cmbCriterio.Items.Add("Termina con ");
                cmbCriterio.Items.Add("Contiene ");
                Cargar();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (ValidarFiltro())
                {
                    return;
                }

                string campo = cmbCampo.SelectedItem.ToString();
                string criterio = cmbCriterio.SelectedItem.ToString();
                string filtroAv = txtFiltroAvanz.Text;

                dgvListaArt.DataSource = negocio.filtrarLista(campo, criterio, filtroAv);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        private bool ValidarFiltro()
        {
            if (cmbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar un campo");
                return true;
            }
            if (cmbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar un criterio");
                return true;
            }
            if (cmbCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanz.Text))
                {
                    MessageBox.Show("Debe ingresar un precio");
                    return true;
                }
                if (ValidarNumeros(txtFiltroAvanz.Text))
                {
                    MessageBox.Show("Sólo puedes ingresar números y el caracter usado para decimales es '.' (punto)");
                    return true;
                }
            }
            return false;
        }
        private bool ValidarNumeros(string cadenaNum)
        {
            foreach (char num in cadenaNum)
            {
                if (char.IsLetter(num) || (num == ','))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAgMarca_Click(object sender, EventArgs e)
        {
            FrmNuevaMarca nuevaMarca = new FrmNuevaMarca();
            nuevaMarca.ShowDialog();
        }

        private void btnAgCat_Click(object sender, EventArgs e)
        {
            FrmNuevaCategoria nuevaCategoria = new FrmNuevaCategoria();
            nuevaCategoria.ShowDialog();
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltro;
            string filtro = txtFiltroRapido.Text;


            if (filtro.Length >= 3)
            {
                listaFiltro = listaArticulos.FindAll(x => x.Marca.Descripcion1.ToUpper().Contains(txtFiltroRapido.Text.ToUpper())
                  || x.Categoria.Descripcion1.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));

            }
            else
            {
                listaFiltro = listaArticulos;
            }

            dgvListaArt.DataSource = null;
            dgvListaArt.DataSource = listaFiltro;
            OcultarColumnas();
        }
    }
}
