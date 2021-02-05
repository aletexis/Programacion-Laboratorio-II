using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excepciones;
using System.Data.SqlClient;
using Entidades;
using System.Threading;

namespace Formularios
{
    public partial class FormProductos : Form
    {
        protected SqlDataAdapter da;
        protected DataTable dt;
        private const string PATH_DATOS = "ArtisticaDatos.xml";
        private const string PATH_SCHEMA = "ArtisticaEsquema.xml";
        protected Artistica artistica;
        protected Producto productoSeleccionado;
        protected delegate void Delegado(object sender, EventArgs e);
        protected event Delegado EventoVender;


        #region Constructor
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FormProductos()
        {
            InitializeComponent();

            if (!this.ConfigurarDataAdapter())
            {
                MessageBox.Show("Error al configurar el DataAdapter.");
                this.Close();
            }

            this.ConfigurarDataTable();

            try
            {
                this.da.Fill(this.dt);
                this.dgvGrilla.DataSource = this.dt;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region DataAdapter
        /// <summary>
        /// Configuracion de los comandos del data adapter.
        /// </summary>
        /// <returns>Devuelve True si se configuro correctamente. Caso contrario, devuelve False.</returns>
        private bool ConfigurarDataAdapter()
        {
            bool retorno = false;

            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.Conexion);

                this.da = new SqlDataAdapter();

                this.da.SelectCommand = new SqlCommand("SELECT id, nombre, marca, stock, precio FROM product_table", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO product_table (nombre, marca, stock, precio) VALUES (@nombre, @marca, @stock, @precio)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE product_table SET nombre=@nombre, marca=@marca, stock=@stock, precio=@precio WHERE id=@id", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM product_table WHERE id=@id", cn);

                this.da.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.InsertCommand.Parameters.Add("@stock", SqlDbType.Int, 10, "stock");
                this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "precio");

                this.da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");
                this.da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
                this.da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.UpdateCommand.Parameters.Add("@stock", SqlDbType.Int, 10, "stock");
                this.da.UpdateCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "precio");

                this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");

                retorno = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retorno;
        }

        #endregion

        #region DataTable
        /// <summary>
        /// Configuracion de las columnas del data rable.
        /// </summary>
        private void ConfigurarDataTable()
        {
            this.dt = new DataTable("Producto");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("nombre", typeof(string));
            this.dt.Columns.Add("marca", typeof(string));
            this.dt.Columns.Add("stock", typeof(int));
            this.dt.Columns.Add("precio", typeof(float));

            this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;
        }

        #endregion

        /// <summary>
        /// Agrega un producto al data table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();

            try
            {
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    DataRow fila = this.dt.NewRow();

                    fila["id"] = formAgregar.Producto.Codigo;
                    fila["nombre"] = formAgregar.Producto.Nombre;
                    fila["marca"] = formAgregar.Producto.Marca;
                    fila["stock"] = formAgregar.Producto.Stock;
                    fila["precio"] = formAgregar.Producto.Precio;

                    this.dt.Rows.Add(fila);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Edita un producto del data table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int i = this.dgvGrilla.SelectedRows[0].Index;
            DataRow fila = this.dt.Rows[i];

            try
            {
                int codigo = int.Parse(fila["id"].ToString());
                string nombre = fila["nombre"].ToString();
                string marca = fila["marca"].ToString();
                int stock = int.Parse(fila["stock"].ToString());
                float precio = float.Parse(fila["precio"].ToString());

                Producto p = new Producto(codigo, nombre, marca, stock, precio);

                FormAgregar formEditar = new FormAgregar(p);

                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    fila["nombre"] = formEditar.Producto.Nombre;
                    fila["marca"] = formEditar.Producto.Marca;
                    fila["stock"] = formEditar.Producto.Stock;
                    fila["precio"] = formEditar.Producto.Precio;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Elimina un producto del data table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = this.dgvGrilla.SelectedRows[0].Index;
            DataRow fila = this.dt.Rows[i];

            try 
            {
                int codigo = int.Parse(fila["id"].ToString());
                string nombre = fila["nombre"].ToString();
                string marca = fila["marca"].ToString();
                int stock = int.Parse(fila["stock"].ToString());
                float precio = float.Parse(fila["precio"].ToString());

                Producto p = new Producto(codigo, nombre, marca, stock, precio);

                if (MessageBox.Show("¿Seguro que quiere eliminar el producto?",
                    "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) != DialogResult.OK)
                {
                    fila.Delete();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Vende un producto del data table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView fila = (DataRowView)dgvGrilla.CurrentRow.DataBoundItem;

                int codigo = int.Parse(fila["id"].ToString());
                string nombre = fila["nombre"].ToString();
                string marca = fila["marca"].ToString();
                int stock = int.Parse(fila["stock"].ToString());
                float precio = float.Parse(fila["precio"].ToString());

                Producto p = new Producto(codigo, nombre, marca, stock, precio);
                FormVender formVender = new FormVender(p);

                if (formVender.ShowDialog() == DialogResult.OK)
                {
                    if (this.EventoVender != null)
                    {
                        this.EventoVender -= productoSeleccionado_EventoVender;
                    }
                    this.productoSeleccionado = p;
                    this.EventoVender += productoSeleccionado_EventoVender;

                fila["stock"] = formVender.Producto.Stock;
                if (p.Stock == 0)
                {
                    fila.Delete();
                }
                    this.EventoVender(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento vender de un producto seleccionado. Imprime el ticket.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productoSeleccionado_EventoVender(object sender, EventArgs e)
        {
            if (Venta.ImprimirTicket(this.productoSeleccionado))
            {
                MessageBox.Show($"{this.productoSeleccionado.Nombre} vendido/a\nClick sobre la tabla para actualizar los datos!");
            }
            else
            {
                MessageBox.Show("No se pudo imprimir el ticket.");
            }
        }

        /// <summary>
        /// Sincroniza los datos con la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.da.Update(this.dt);
                MessageBox.Show("Infomación sincronizada con la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Guarda los datos y el esquema en un archivo xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                this.dt.WriteXmlSchema(PATH_SCHEMA);
                this.dt.WriteXml(PATH_DATOS);
                MessageBox.Show("Se guardaron los datos.");
            }
            catch
            {
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
