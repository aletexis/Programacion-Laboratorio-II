using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using ClasesInstanciables;

namespace ClasesInstanciables
{
    public class Universidad
    {

        #region Atributos

        private List<Alumno> alumnos;
        private List<Profesor> profesores;
        private List<Jornada> jornada;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad que permite obtener o asignar alumnos de la universidad.
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
        /// Propiedad que permite obtener o asignar instructores de la universidad.
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// Propiedad que permite obtener o asignar jornadas de la universidad.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        /// <summary>
        /// Permite obtener o asignar una jornada de la universidad de un indice especificado.
        /// </summary>
        /// <param name="i">El indice a acceder.</param>
        /// <returns>La jornada de la universidad de un indice especificado.</returns>
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }

            set
            {
                this.jornada[i] = value;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de universidad. Inicializa la lista de alumnos, profesores y jornada.
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Hace publicos los datos de la universidad.
        /// </summary>
        /// <returns>Retorna los datos de la universidad.</returns>
        public override string ToString()
        {
            StringBuilder universidad = new StringBuilder();
            universidad.AppendLine("JORNADA: ");
            foreach (Jornada item in this.Jornadas)
            {
                universidad.AppendFormat("{0}", item.ToString());
                universidad.AppendLine("<------------------------------------------------->");
            }
            return universidad.ToString();
        }

        /// <summary>
        /// Muestra los datos de la universidad en string.
        /// </summary>
        /// <param name="uni">La universidad a mostrar.</param>
        /// <returns>Los datos de la universidad.</returns>
        private static string MostrarDatos(Universidad uni)
        {
            return uni.ToString();
        }

        /// <summary>
        /// Guarda los datos de una universidad en un archivo .xlm
        /// </summary>
        /// <param name="uni">La universidad a guardar.</param>
        /// <returns>Retorna True si pudo guardar. Caso contrario, lanza una excepcion.</returns>
        public static bool Guardar(Universidad uni)
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory()
                    + @"\ArchivosGuardados";
                System.IO.Directory.CreateDirectory(path);
                Xml<Universidad> archivo = new Xml<Universidad>();
                return archivo.Guardar((path + @"\Universidad.xml"), uni);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        /// <summary>
        /// Devuelve los datos de la Universidad como un objeto.
        /// </summary>
        /// <returns>Retorna los datos de la universidad.</returns>
        public static Universidad Leer()
        {
            try
            {
                Universidad uni = new Universidad();
                Xml<Universidad> archivo = new Xml<Universidad>();
                archivo.Leer((System.IO.Directory.GetCurrentDirectory()
                    + @"\ArchivosGuardados\Universidad.xml"), out uni);
                return uni;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==. Una Universidad será igual a un
        /// Alumno si el mismo está inscripto en ella.
        /// </summary>
        /// <param name="g">La universidad a comparar.</param>
        /// <param name="a">El alumno a comparar.</param>
        /// <returns>Retorna True si el alumno esta inscripto, False si no lo esta.</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno item in g.alumnos)
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
        /// Sobrecarga del operador !=. Una Universidad será distinta a un
        /// Alumno si el mismo no está inscripto en ella.
        /// </summary>
        /// <param name="g">La universidad a comparar.</param>
        /// <param name="a">El alumno a comparar.</param>
        /// <returns>Retorna True si el alumno no esta inscripto, False si lo esta.</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Sobrecarga del operador ==. Una Universidad será igual
        /// a un Profesor si el mismo está dando clases en ella.
        /// </summary>
        /// <param name="g">La universidad a comparar.</param>
        /// <param name="i">El profesor a comparar.</param>
        /// <returns>Retorna True si da clases, False si no da.</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            foreach (Profesor item in g.profesores)
            {
                if (item == i)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador !=. Una Universidad será distinta
        /// a un Profesor si el mismo no está dando clases en ella.
        /// </summary>
        /// <param name="g">La universidad a comparar.</param>
        /// <param name="i">El profesor a comparar.</param>
        /// <returns>Retorna True si no da clases, False si da.</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Informa el primer Profesor capaz de dar una clase.
        /// </summary>
        /// <param name="u">La universidad a la que pertenece el profesor a comparar.</param>
        /// <param name="clase">La clase a comparar.</param>
        /// <returns>Retorna el profesor que da la clase. Caso contrario, lanza una excepcion.</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.Instructores)
            {
                if (item == clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Informa el primer Profesor que no puede dar una clase.
        /// </summary>
        /// <param name="u">La universidad a la que pertenece el profesor a comparar.</param>
        /// <param name="clase">La clase a comparar.</param>
        /// <returns>Retorna el profesor que no da la clase. Caso contrario, lanza una excepcion.</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.Instructores)
            {
                if (item != clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Agrega alumnos validando que no estén previamente cargados.
        /// </summary>
        /// <param name="u">La universidad a la que se va a agregar el alumno.</param>
        /// <param name="a">El alumno a agregar.</param>
        /// <returns>Retorna la universidad con el alumno cargado. Caso contrario, lanza una excepcion.</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }

        /// <summary>
        /// Agrega profesores validando que no estén previamente cargados.
        /// </summary>
        /// <param name="u">La universidad a la que se va a agregar el profesor.</param>
        /// <param name="i">El profesor a agregar.</param>
        /// <returns>Retorna la universidad con el profesor cargado, si no esta repetido.</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
            }
            return u;
        }

        /// <summary>
        /// Agrega un nueva jornada a la universidad.
        /// </summary>
        /// <param name="g">La universidad a la cual se va a agregar la jornada.</param>
        /// <param name="clase">La clase de la jornada a agregar.</param>
        /// <returns>Retorna la universidad con la nueva jornada agregada. Caso contrario, lanza una excepcion.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            try
            {
                Jornada nuevaJornada = new Jornada(clase, (g == clase));

                foreach (Alumno item in g.Alumnos)
                {
                    if (item == nuevaJornada.Clase)
                    {
                        nuevaJornada += item;
                    }
                }

                g.jornada.Add(nuevaJornada);

                return g;
            }
            catch (SinProfesorException e)
            {
                throw e;
            }
        }

        #endregion

        #region Enumerados
        /// <summary>
        /// Enumerados de clase de la universidad.
        /// </summary>
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion


    }
}
