using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace archivosTextoyBinario
{
    public partial class Form1 : Form
    {
        char fstbit, scndbit;
        int ancho, alto,bytes, bxp;
        public Form1()
        {
            InitializeComponent();

            
        }

        private bool esBMP(FileStream archivo)
        {
            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(0, SeekOrigin.Begin);
            fstbit = Convert.ToChar(br.ReadByte());
            br.BaseStream.Seek(1, SeekOrigin.Begin);
            scndbit = Convert.ToChar(br.ReadByte());
            if (fstbit == 'B' && scndbit == 'M')
            {
                Console.WriteLine("Marca del fichero: {0}{1}", fstbit, scndbit);
                //txtArchivo.Text += "es bmp";

                return true;
            }
            else
            {
                br.Close();
                archivo.Close();
                Console.WriteLine("no es");
                txtArchivo.Text += "No es bmp";
                return false;
            }

        }



        private int tamaño(FileStream archivo)
        {

            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(2, SeekOrigin.Begin);//2 posición en un archivo bmp para el tamaño de bytes
            bytes= br.ReadInt32();
            Console.WriteLine("Tamaño real en bytes: " +  bytes);
            txtArchivo.Text += "Tamaño real en bytes: " + bytes;
            return bytes;
        }
        private int axaImagen(FileStream archivo)
        {
            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(18, SeekOrigin.Begin);//18 posición en un archivo bmp para el ancho de una imagen
            ancho = br.ReadInt32();
            Console.WriteLine("Ancho:{0} ", ancho);
            txtArchivo.Text += Environment.NewLine + "Ancho de la imagen: " + ancho;
            alto = br.ReadInt32();
            Console.WriteLine("Alto:{0} ", alto);
            txtArchivo.Text += Environment.NewLine + "Alto de la imagen: " + alto;
            return ancho+alto;

        }

        private int bitsxPixel(FileStream archivo)
        {
            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(28, SeekOrigin.Begin);//28 posición en un archivo bmp para el bits por pixel
            bxp = br.ReadInt16();
            Console.WriteLine("Bits por pixel:{0} ", bxp);
            txtArchivo.Text += Environment.NewLine + "Bits por pixel: " + bxp;
            return bxp;
        }



        private void btnAbrir_Click(object sender, EventArgs e)
        {            
            opnFileDialog.ShowDialog();
            FileStream archivo = new FileStream(opnFileDialog.FileName, FileMode.Open);
           

            if (esBMP(archivo)==true)
            {                
                tamaño(archivo);
                axaImagen(archivo);
                bitsxPixel(archivo);
            }
            archivo.Close();
        }

        private void archivoXML( XmlDocument doc, string nombre, string apellido, string apellido2, string edad,string numeroCuenta)
        {

            
            XmlDeclaration dcl= doc.CreateXmlDeclaration("1.0","utf-8","yes");
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(dcl, root);

            XmlNode node = doc.CreateElement("Alumnos");
            doc.AppendChild(node);
            XmlNode usNode = doc.CreateElement("usuario");
            XmlAttribute age = doc.CreateAttribute("edad");
            age.Value = edad;
            usNode.Attributes.Append(age);
            usNode.InnerText = nombre+" " +apellido + " " +apellido2 + " " +numeroCuenta ;
            node.AppendChild(usNode);
           

        }

        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            sFileDialog.Filter = "XML files(.xml)|*.xml|all Files(*.*)|*.*";
            sFileDialog.ShowDialog();

            archivoXML( doc,txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtEdad.Text, txtNumCuenta.Text);

            doc.Save(sFileDialog.FileName);

            



        }

    }
}
