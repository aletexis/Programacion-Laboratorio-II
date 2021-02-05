using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
using Excepciones;

namespace ArtisticaApp
{
    public partial class Productos : Form
    {

        private string PATH_XML_PERSONAS = System.IO.Directory.GetCurrentDirectory()
                    + @"\ArchivosGuardados\DataTableProductosDatos.xml";
        private string PATH_XML_PERSONAS_SCHEMA = System.IO.Directory.GetCurrentDirectory()
                    + @"\ArchivosGuardados\DataTableProductosSchema.xml";

        protected SqlDataAdapter da;
        protected DataTable dt;

        #region Constructor

        public Productos()
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

        private bool ConfigurarDataAdapter()
        {
            bool rta = false;

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

                rta = true;
            }
            catch (BaseDatosException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return rta;
        }

        #endregion

        #region DataTable

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar formAgregar = new Agregar();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
             int i = this.dgvGrilla.SelectedRows[0].Index;

             DataRow fila = this.dt.Rows[i];

             int codigo = int.Parse(fila["id"].ToString());
             string nombre = fila["nombre"].ToString();
             string marca = fila["marca"].ToString();
             int stock = int.Parse(fila["stock"].ToString());
             float precio = float.Parse(fila["precio"].ToString());

            Entidades.Producto p = new Entidades.Producto(codigo, nombre, marca, stock, precio);

             Agregar formEditar = new Agregar(p);

             if (formEditar.ShowDialog() == DialogResult.OK)
             {
                 fila["nombre"] = formEditar.Producto.Nombre;
                 fila["marca"] = formEditar.Producto.Marca;
                 fila["stock"] = formEditar.Producto.Stock;
                 fila["precio"] = formEditar.Producto.Precio;
             }

        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           int i = this.dgvGrilla.SelectedRows[0].Index;

           DataRow fila = this.dt.Rows[i];

           int codigo = int.Parse(fila["id"].ToString());
           string nombre = fila["nombre"].ToString();
           string marca = fila["marca"].ToString();
           int stock = int.Parse(fila["stock"].ToString());
           float precio = float.Parse(fila["precio"].ToString());

            Entidades.Producto p = new Entidades.Producto(codigo, nombre, marca, stock, precio);

            if (MessageBox.Show("¿Seguro que quiere eliminar el producto?", 
                "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) != DialogResult.OK)
            {
               fila.Delete();
            }

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int i = this.dgvGrilla.SelectedRows[0].Index;

            DataRow fila = this.dt.Rows[i];

            int codigo = int.Parse(fila["id"].ToString());
            string nombre = fila["nombre"].ToString();
            string marca = fila["marca"].ToString();
            int stock = int.Parse(fila["stock"].ToString());
            float precio = float.Parse(fila["precio"].ToString());

            Entidades.Producto p = new Entidades.Producto(codigo, nombre, marca, stock, precio);
            
            Vender formVender = new Vender(p);
            formVender.Show();
        }

    }
}
