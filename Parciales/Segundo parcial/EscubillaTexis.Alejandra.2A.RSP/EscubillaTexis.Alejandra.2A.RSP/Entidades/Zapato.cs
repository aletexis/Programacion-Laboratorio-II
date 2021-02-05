using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Zapato : Producto, ISerializa, IDeserializa
    {
        #region Constructores
        public Zapato()
        {

        }

        public Zapato(string tipo, string marca, float precio)
            : base(tipo, marca, precio)
        {

        }
        #endregion

        #region Propiedades
        public string Path
        {
            get
            {
                return Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString() + "\\EscubillaTexis.Alejandra.Zapato.xml";
            }
        }
        #endregion

        #region Metodos

        public bool Xml()
        {
            bool retorno = true;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.Path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Zapato));
                    ser.Serialize(writer, this);
                }

            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        bool IDeserializa.Xml(out Zapato z)
        {
            bool retorno = true;

            try
            {
                using (XmlTextReader read = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Zapato));
                    z = (Zapato)ser.Deserialize(read);
                }
            }
            catch (Exception)
            {
                retorno = false;
                z = new Zapato();
            }

            return retorno;
        }
        #endregion
    }
}
