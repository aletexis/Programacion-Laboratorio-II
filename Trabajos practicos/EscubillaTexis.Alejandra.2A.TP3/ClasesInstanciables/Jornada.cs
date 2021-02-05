using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos

        private List<Alumno> alumnos;
        private Profesor instructor;
        private Universidad.EClases clase;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad que permite obtener o asignar alumnos de la jornada.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Propiedad que permite obtener o asignar clases de la jornada.
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                if (this.instructor == value)
                {
                    this.clase = value;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
        }

        /// <summary>
        /// Propiedad que permite obtener o asignar instructores de la jornada.
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                if (value == this.clase)
                {
                    this.instructor = value;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que inicializa la lista de alumnos de la jornada.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor que inicializa la clase y el instructor de la jornada.
        /// </summary>
        /// <param name="clase">La clase de la jornada.</param>
        /// <param name="instructor">El instructor de la jornada.</param>
        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos de la jornada en string.
        /// </summary>
        /// <returns>Retorna los datos de la jornada.</returns>
        public override string ToString()
        {
            StringBuilder jornada = new StringBuilder();
            jornada.AppendFormat("CLASE DE {0} POR {1}", this.clase.ToString(), this.instructor.ToString());
            jornada.AppendLine("ALUMNOS:");
            foreach (Alumno item in this.alumnos)
            {
                jornada.AppendLine(item.ToString());
            }
            return jornada.ToString();
        }

        /// <summary>
        /// Guarda los datos de la Jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada">La jornada a guardar.</param>
        /// <returns>Retorna True si pudo guardar. Caso contrario, lanza una excepcion.</returns>
        public static bool Guardar(Jornada jornada)
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory()
                    + @"\ArchivosGuardados";
                System.IO.Directory.CreateDirectory(path);
                Texto archivoTexto = new Texto();
                archivoTexto.Guardar((path + @"\Jornada.txt"), jornada.ToString());
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        /// <summary>
        /// Devuelve los datos de la Jornada como texto.
        /// </summary>
        /// <returns>Retorna los datos de la jornada. Caso contrario, lanza una excepcion.</returns>
        public static string Leer()
        {
            try
            {
                string jornada = "";
                Texto archivoTexto = new Texto();
                archivoTexto.Leer((System.IO.Directory.GetCurrentDirectory() +
                    @"\ArchivosGuardados\Jornada.txt"), out jornada);
                return jornada;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }


        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==. Una Jornada será igual a un
        /// Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j">La jornada a comparar.</param>
        /// <param name="a">El alumno a comparar.</param>
        /// <returns>Retorna True si participa en la clase, False si no participa.</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno item in j.alumnos)
            {
                if (item == a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador !=. Una Jornada será distinta a un
        /// Alumno si el mismo no participa de la clase.
        /// </summary>
        /// <param name="j">La jornada a comparar.</param>
        /// <param name="a">El alumno a comparar.</param>
        /// <returns>Retorna True si no participa en la clase, False si participa.</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega Alumnos a la jornada validando que no estén previamente cargados.
        /// </summary>
        /// <param name="j">La jornada en que se van a agregar.</param>
        /// <param name="a">El alumno a agregar.</param>
        /// <returns>Retorna la jornada con el alumno cargado, si se pudo.</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }

        #endregion
    }
}
