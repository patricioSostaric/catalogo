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
    public partial class FrmNuevoArticulo : Form
    {
        private List<Articulo> listaArticulos;

        private Articulo articulo = null;
        public FrmNuevoArticulo()
        {
            InitializeComponent();
        }
        public FrmNuevoArticulo(Articulo Modificar)
        {
            InitializeComponent();
            articulo = Modificar;
            Text = "Modificar Artículo";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevaLista = new ArticuloNegocio();

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = nuevaLista.listar();

                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                if (validarCamposObligatorios())
                {
                    return;
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescr.Text;

                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCateg.SelectedItem;
                articulo.ImagenUrl = txtUrlimg.Text;


                if (articulo.Id != 0)
                {

                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado con exito!");

                }


                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado con exito");
                }



                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        public bool validarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Digite el código");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Escriba el nombre del producto");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese el precio del producto");
                return true;
            }
            if (validarNumeros(txtPrecio.Text))
            {
                MessageBox.Show("Solo números y en caso de usar decimales,utilizar coma  ' , ' por favor");
                return true;
            }

            return false;
        }
        private bool validarNumeros(string cadenaNum)
        {
            foreach (char num in cadenaNum)
            {
                if (char.IsLetter(num) || num == '.')
                {
                    return true;
                }
            }
            return false;

        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog Archivo = new OpenFileDialog();
            Archivo.Filter = "jpg|*jpg;|png|*png;";
            if (Archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlimg.Text = Archivo.FileName;
                cargarImagen(txtUrlimg.Text);

            }
        }

        private void cargarImagen(string img)
        {
            try
            {
                pbxArticulo.Load(img);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://rastro.com/fotos3/2021/10/18/11748542_foto1.jpg ");

            }
        }

        private void txtUrlimg_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlimg.Text);
        }

        private void FrmNuevoArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();

            try
            {

                cmbMarca.DataSource = marca.listar();
                cmbMarca.ValueMember = "Id1";
                cmbMarca.DisplayMember = "Descripcion1";

                cmbCateg.DataSource = cat.listar();
                cmbCateg.ValueMember = "Id1";
                cmbCateg.DisplayMember = "Descripcion1";


                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescr.Text = articulo.Descripcion;
                    txtPrecio.Text = Convert.ToString(articulo.Precio);
                    cmbMarca.SelectedValue = articulo.Marca.Id1;
                    cmbCateg.SelectedValue = articulo.Categoria.Id1;
                    cargarImagen(articulo.ImagenUrl);
                    txtUrlimg.Text = articulo.ImagenUrl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

    }
}

