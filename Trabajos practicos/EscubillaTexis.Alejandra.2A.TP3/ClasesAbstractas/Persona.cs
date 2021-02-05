using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que permite obtener o asignar un apellido.
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        ///  Propiedad que permite obtener o asignar un DNI.
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }

        /// <summary>
        ///  Propiedad que permite obtener o asignar una nacionalidad.
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        ///  Propiedad que permite obtener o asignar un nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Valida y convierte un DNI en string a DNI de tipo numerico.
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de Persona.
        /// </summary>
        public Persona()
        {
        }

        /// <summary>
        /// Constructor que inicializa el nombre, apellido y nacionalidad de la persona.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="apellido">El apellido de la persona.</param>
        /// <param name="nacionalidad">La nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor que inicializa el nombre, apellido, dni (int) y nacionalidad de la persona.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        /// <summary>
        /// Constructor que inicializa el nombre, apellido, dni (string) y nacionalidad de la persona.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="apellido">El apellido de la persona.</param>
        /// <param name="dni">El dni de la persona.</param>
        /// <param name="nacionalidad">La nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve los datos de la persona en string.
        /// </summary>
        /// <returns>Los datos de la persona.</returns>
        public override string ToString()
        {
            StringBuilder persona = new StringBuilder();
            persona.AppendFormat("NOMBRE COMPLETO: {0}, {1}\n", this.Apellido, this.Nombre);
            persona.AppendFormat("NACIONALIDAD: {0}\n", this.Nacionalidad);
            return persona.ToString();
        }

        /// <summary>
        /// Valida el DNI de la persona.
        /// </summary>
        /// <param name="nacionalidad">La nacionalidad de la persona.</param>
        /// <param name="dato">El DNI a validar.</param>
        /// <returns>Retorna el DNI validado. Caso contrario, lanza una excepcion.</returns>
        private static int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno;

            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato >= 1 && dato <= 89999999)
                {
                    retorno = dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else if (nacionalidad == ENacionalidad.Extranjero)
            {
                if (dato >= 90000000 && dato <= 99999999)
                {
                    retorno = dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else
            {
                throw new DniInvalidoException("DNI fuera de rango. Rango valido: entre 1 y 99.999.999.");
            }

            return retorno;
        }

        /// <summary>
        /// Valida el DNI de la persona.
        /// </summary>
        /// <param name="nacionalidad">La nacionalidad de la persona.</param>
        /// <param name="dato">El DNI a validar.</param>
        /// <returns>Retorna el DNI validado. Caso contrario, lanza una excepcion.</returns>
        private static int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            try
            {
                int datoParseado = int.Parse(dato);
                return Persona.ValidarDni(nacionalidad, datoParseado);
            }
            catch (FormatException)
            {
                throw new DniInvalidoException("El DNI contiene caracteres no validos.");
            }
        }

        /// <summary>
        /// Valida el nombre y apellido de la persona.
        /// </summary>
        /// <param name="dato">El nombre o apellido a validar.</param>
        /// <returns>Retorna el nombre o apellido validado.</returns>
        private static string ValidarNombreApellido(string dato)
        {
            foreach (char c in dato)
            {
                if (!char.IsLetter(c))
                {
                    dato = "";
                    break;
                }
            }

            return dato;
        }

        #endregion

        #region Enumerados

        /// <summary>
        /// Enumerados de nacionalidad de la persona.
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        
        #endregion
    }
}
