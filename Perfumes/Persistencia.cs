using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Xml.Serialization;

namespace Perfumes
{
    public class Persistencia
    {
        //variables persistentes
        DataSet dsPrecios;
        DataRow row;
        public struct archGuar
        {
          public  string tipo;
          public  string nombre;
          public  int cantidad;
        }
        
        public Persistencia() 
        {
        this.dsPrecios = new DataSet("Precio");
        dsPrecios.ReadXml("Precio.xml");
        row = dsPrecios.Tables["Precio"].Rows[0];
        

        }

             
        
        internal void GuardarLista(Perfumes perfumes, PerfumeMujer pMujer, PerfumeHombre pHombre, PerfumeRopa pRopa, PerfumeAromatizante pAroma)
        {
            SaveFileDialog dlg;
            bool cancel = false;
            bool ok = true;

         do {
             
            dlg = new SaveFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.TXT" +
              "|All files (*.*)|*.*";
            dlg.AddExtension = true;
            dlg.DefaultExt = "*.txt";
            
            dlg.InitialDirectory = Application.StartupPath;
             
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!dlg.FileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Por Favor agragre la extención '.txt' al final del nombre");
                }
                else
                {
                    FileInfo f = new FileInfo(dlg.FileName);
                    StreamWriter writer = f.CreateText();
                    this.EscribirLista(writer,perfumes,  pMujer, pHombre,  pRopa,  pAroma);
                    writer.Close();
                    this.PersistirLista(dlg.FileName+".xml", perfumes, pMujer, pHombre, pRopa, pAroma);
                    

                    ok = false;
                }

            }
            else { cancel = false; ok = false; } 

            

         }while ( ok || cancel );
                       
        }

        internal void cargarLista(Perfumes perfumes)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Xml Files (*.xml)|*.XML" +
              "|All files (*.*)|*.*";
            // dlg.CheckFileExists = true;
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.txt";

            ofd.InitialDirectory = Application.StartupPath;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                XmlSerializer mySerializer = new XmlSerializer(typeof(archGuar[]));
                FileStream myFileStream = new FileStream(ofd.FileName, FileMode.Open);
                archGuar[] element = new archGuar[100];
                element= (archGuar[])mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
                               
                setearVista(perfumes, element);
            }

        }

        private void setearVista(Perfumes perfumes, archGuar[] element)
        {
            for (int i = 0; i <= cantidadDePerfumes(element); i++)
            {
                switch (element[i].tipo)
                {
                    case "M":
                        llenarBoxLibreMujer(perfumes, element[i]);
                        break;

                    case "H":
                        llenarBoxLibreHombre(perfumes, element[i]);
                        break;

                    case "R":
                        llenarBoxLibreRopa(perfumes, element[i]);
                        break;

                    case "A":
                        llenarBoxLibreAroma(perfumes, element[i]);
                        break;


                }
            }
        }

        private int cantidadDePerfumes(archGuar[] element)
        {
            int i=0, res=0;
            while (element[i].cantidad != 0) { res++; i++; }
            return res;
        }

        private bool llenarBoxLibreMujer(Perfumes perfumes, archGuar element)
        {
            if (Convert.ToInt32(perfumes.numericUpDownM0.Value) == 0) { perfumes.comboBoxPerfumeMujer0.Text = element.nombre; perfumes.numericUpDownM0.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM1.Value) == 0) { perfumes.comboBoxPerfumeMujer1.Text = element.nombre; perfumes.numericUpDownM1.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM2.Value) == 0) { perfumes.comboBoxPerfumeMujer2.Text = element.nombre; perfumes.numericUpDownM2.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM3.Value) == 0) { perfumes.comboBoxPerfumeMujer3.Text = element.nombre; perfumes.numericUpDownM3.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM4.Value) == 0) { perfumes.comboBoxPerfumeMujer4.Text = element.nombre; perfumes.numericUpDownM4.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM5.Value) == 0) { perfumes.comboBoxPerfumeMujer5.Text = element.nombre; perfumes.numericUpDownM5.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM6.Value) == 0) { perfumes.comboBoxPerfumeMujer6.Text = element.nombre; perfumes.numericUpDownM6.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM7.Value) == 0) { perfumes.comboBoxPerfumeMujer7.Text = element.nombre; perfumes.numericUpDownM7.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM8.Value) == 0) { perfumes.comboBoxPerfumeMujer8.Text = element.nombre; perfumes.numericUpDownM8.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM9.Value) == 0) { perfumes.comboBoxPerfumeMujer9.Text = element.nombre; perfumes.numericUpDownM9.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM10.Value) == 0) { perfumes.comboBoxPerfumeMujer10.Text = element.nombre; perfumes.numericUpDownM10.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM11.Value) == 0) { perfumes.comboBoxPerfumeMujer11.Text = element.nombre; perfumes.numericUpDownM11.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM12.Value) == 0) { perfumes.comboBoxPerfumeMujer12.Text = element.nombre; perfumes.numericUpDownM12.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM13.Value) == 0) { perfumes.comboBoxPerfumeMujer13.Text = element.nombre; perfumes.numericUpDownM13.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM14.Value) == 0) { perfumes.comboBoxPerfumeMujer14.Text = element.nombre; perfumes.numericUpDownM14.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM15.Value) == 0) { perfumes.comboBoxPerfumeMujer15.Text = element.nombre; perfumes.numericUpDownM15.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM16.Value) == 0) { perfumes.comboBoxPerfumeMujer16.Text = element.nombre; perfumes.numericUpDownM16.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM17.Value) == 0) { perfumes.comboBoxPerfumeMujer17.Text = element.nombre; perfumes.numericUpDownM17.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM18.Value) == 0) { perfumes.comboBoxPerfumeMujer18.Text = element.nombre; perfumes.numericUpDownM18.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM19.Value) == 0) { perfumes.comboBoxPerfumeMujer19.Text = element.nombre; perfumes.numericUpDownM19.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM20.Value) == 0) { perfumes.comboBoxPerfumeMujer20.Text = element.nombre; perfumes.numericUpDownM20.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM21.Value) == 0) { perfumes.comboBoxPerfumeMujer21.Text = element.nombre; perfumes.numericUpDownM21.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM22.Value) == 0) { perfumes.comboBoxPerfumeMujer22.Text = element.nombre; perfumes.numericUpDownM22.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM23.Value) == 0) { perfumes.comboBoxPerfumeMujer23.Text = element.nombre; perfumes.numericUpDownM23.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownM24.Value) == 0) { perfumes.comboBoxPerfumeMujer24.Text = element.nombre; perfumes.numericUpDownM24.Value = element.cantidad; return true; }
            else return false;
        }

        private bool llenarBoxLibreAroma(Perfumes perfumes, archGuar element)
        {
            if (Convert.ToInt32(perfumes.numericUpDownA1.Value) == 0) { perfumes.comboBoxA1.Text = element.nombre; perfumes.numericUpDownA1.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownA2.Value) == 0) { perfumes.comboBoxA2.Text = element.nombre; perfumes.numericUpDownA2.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownA3.Value) == 0) { perfumes.comboBoxA3.Text = element.nombre; perfumes.numericUpDownA3.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownA4.Value) == 0) { perfumes.comboBoxA4.Text = element.nombre; perfumes.numericUpDownA4.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownA5.Value) == 0) { perfumes.comboBoxA5.Text = element.nombre; perfumes.numericUpDownA5.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownA6.Value) == 0) { perfumes.comboBoxA6.Text = element.nombre; perfumes.numericUpDownA6.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownA7.Value) == 0) { perfumes.comboBoxA7.Text = element.nombre; perfumes.numericUpDownA7.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownA8.Value) == 0) { perfumes.comboBoxA8.Text = element.nombre; perfumes.numericUpDownA8.Value = element.cantidad; return true; }
            else return false;
        }

        private bool llenarBoxLibreRopa(Perfumes perfumes, archGuar element)
        {
            if (Convert.ToInt32(perfumes.numericUpDownR1.Value) == 0) { perfumes.comboBoxRopa.Text = element.nombre; perfumes.numericUpDownR1.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR2.Value) == 0) { perfumes.comboBoxRopa2.Text = element.nombre; perfumes.numericUpDownR2.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR3.Value) == 0) { perfumes.comboBoxRopa3.Text = element.nombre; perfumes.numericUpDownR3.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR4.Value) == 0) { perfumes.comboBoxRopa4.Text = element.nombre; perfumes.numericUpDownR4.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR5.Value) == 0) { perfumes.comboBoxRopa5.Text = element.nombre; perfumes.numericUpDownR5.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR6.Value) == 0) { perfumes.comboBoxRopa6.Text = element.nombre; perfumes.numericUpDownR6.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR7.Value) == 0) { perfumes.comboBoxRopa7.Text = element.nombre; perfumes.numericUpDownR7.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR8.Value) == 0) { perfumes.comboBoxRopa8.Text = element.nombre; perfumes.numericUpDownR8.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR9.Value) == 0) { perfumes.comboBoxRopa9.Text = element.nombre; perfumes.numericUpDownR9.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR10.Value)== 0) { perfumes.comboBoxRopa10.Text = element.nombre; perfumes.numericUpDownR10.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownR11.Value)== 0) { perfumes.comboBoxRopa11.Text = element.nombre; perfumes.numericUpDownR11.Value = element.cantidad; return true; }
            else return false;       
        }

        private bool llenarBoxLibreHombre(Perfumes perfumes, archGuar element)
        {
            if (Convert.ToInt32(perfumes.numericUpDownH1.Value) == 0) { perfumes.comboBoxPerfumeHombre.Text = element.nombre; perfumes.numericUpDownH1.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH2.Value) == 0) { perfumes.comboBoxPerfumeHombre2.Text = element.nombre; perfumes.numericUpDownH2.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH3.Value) == 0) { perfumes.comboBoxPerfumeHombre3.Text = element.nombre; perfumes.numericUpDownH3.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH4.Value) == 0) { perfumes.comboBoxPerfumeHombre4.Text = element.nombre; perfumes.numericUpDownH4.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH5.Value) == 0) { perfumes.comboBoxPerfumeHombre5.Text = element.nombre; perfumes.numericUpDownH5.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH6.Value) == 0) { perfumes.comboBoxPerfumeHombre6.Text = element.nombre; perfumes.numericUpDownH6.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH7.Value) == 0) { perfumes.comboBoxPerfumeHombre7.Text = element.nombre; perfumes.numericUpDownH7.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH8.Value) == 0) { perfumes.comboBoxPerfumeHombre8.Text = element.nombre; perfumes.numericUpDownH8.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH9.Value) == 0) { perfumes.comboBoxPerfumeHombre9.Text = element.nombre; perfumes.numericUpDownH9.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH10.Value) == 0) { perfumes.comboBoxPerfumeHombre10.Text = element.nombre; perfumes.numericUpDownH10.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH11.Value) == 0) { perfumes.comboBoxPerfumeHombre11.Text = element.nombre; perfumes.numericUpDownH11.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH12.Value) == 0) { perfumes.comboBoxPerfumeHombre12.Text = element.nombre; perfumes.numericUpDownH12.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH13.Value) == 0) { perfumes.comboBoxPerfumeHombre13.Text = element.nombre; perfumes.numericUpDownH13.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH14.Value) == 0) { perfumes.comboBoxPerfumeHombre14.Text = element.nombre; perfumes.numericUpDownH14.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH15.Value) == 0) { perfumes.comboBoxPerfumeHombre15.Text = element.nombre; perfumes.numericUpDownH15.Value = element.cantidad; return true; }
            if (Convert.ToInt32(perfumes.numericUpDownH16.Value) == 0) { perfumes.comboBoxPerfumeHombre16.Text = element.nombre; perfumes.numericUpDownH16.Value = element.cantidad; return true; }
            else return false;
        }

        




        private void EscribirLista(StreamWriter writer, Perfumes perfumes, PerfumeMujer pMujer, PerfumeHombre pHombre, PerfumeRopa pRopa, PerfumeAromatizante pAroma)
        {
           
            if (Convert.ToInt32(perfumes.numericUpDownM2.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer2.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM0.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer0.Text + "  " + perfumes.numericUpDownM0.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM1.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer1.Text + "  " + perfumes.numericUpDownM1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM3.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer3.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM4.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer4.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM5.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer5.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM6.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer6.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM7.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer7.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM8.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer8.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM9.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer9.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM10.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer10.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM11.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer11.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM12.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer12.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM13.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer13.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM14.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer14.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM15.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer15.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM16.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer16.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM17.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer17.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM18.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer18.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM19.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer19.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM20.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer20.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM21.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer21.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM22.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer22.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM23.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer23.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownM24.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeMujer24.Text + "  " + perfumes.numericUpDownM2.Value.ToString());
            //PERSISTIR HOMBRE
            if (Convert.ToInt32(perfumes.numericUpDownH1.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre.Text + "  " + perfumes.numericUpDownH1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH2.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre2.Text + "  " + perfumes.numericUpDownH2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH3.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre3.Text + "  " + perfumes.numericUpDownH3.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH4.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre4.Text + "  " + perfumes.numericUpDownH4.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH5.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre5.Text + "  " + perfumes.numericUpDownH5.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH6.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre6.Text + "  " + perfumes.numericUpDownH6.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH7.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre7.Text + "  " + perfumes.numericUpDownH7.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH8.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre8.Text + "  " + perfumes.numericUpDownH8.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH9.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre9.Text + "  " + perfumes.numericUpDownH9.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH10.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre10.Text + "  " + perfumes.numericUpDownH10.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH11.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre11.Text + "  " + perfumes.numericUpDownH11.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH12.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre12.Text + "  " + perfumes.numericUpDownH12.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH13.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre13.Text + "  " + perfumes.numericUpDownH13.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH14.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre14.Text + "  " + perfumes.numericUpDownH14.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH15.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre15.Text + "  " + perfumes.numericUpDownH15.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownH16.Value) != 0) writer.WriteLine(perfumes.comboBoxPerfumeHombre16.Text + "  " + perfumes.numericUpDownH16.Value.ToString());
           
            //PERSISTIR ROPA
            if (Convert.ToInt32(perfumes.numericUpDownR1.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR2.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa2.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR3.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa4.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR4.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa4.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR5.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa5.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR6.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa6.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR7.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa7.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR8.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa8.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR9.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa9.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR10.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa10.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownR11.Value) != 0) writer.WriteLine(perfumes.comboBoxRopa11.Text + "  " + perfumes.numericUpDownR1.Value.ToString());
            //ACTULIZAR AROMATIZANTE
            if (Convert.ToInt32(perfumes.numericUpDownA1.Value) != 0) writer.WriteLine(perfumes.comboBoxA1.Text + "  " + perfumes.numericUpDownA1.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownA2.Value) != 0) writer.WriteLine(perfumes.comboBoxA2.Text + "  " + perfumes.numericUpDownA2.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownA3.Value) != 0) writer.WriteLine(perfumes.comboBoxA3.Text + "  " + perfumes.numericUpDownA3.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownA4.Value) != 0) writer.WriteLine(perfumes.comboBoxA4.Text + "  " + perfumes.numericUpDownA4.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownA5.Value) != 0) writer.WriteLine(perfumes.comboBoxA5.Text + "  " + perfumes.numericUpDownA5.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownA6.Value) != 0) writer.WriteLine(perfumes.comboBoxA6.Text + "  " + perfumes.numericUpDownA6.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownA7.Value) != 0) writer.WriteLine(perfumes.comboBoxA7.Text + "  " + perfumes.numericUpDownA7.Value.ToString());
            if (Convert.ToInt32(perfumes.numericUpDownA8.Value) != 0) writer.WriteLine(perfumes.comboBoxA8.Text + "  " + perfumes.numericUpDownA8.Value.ToString());


            writer.WriteLine("Total De Perfumes de Mujer: "+perfumes.labelCantMujer.Text   + " X " + pMujer.getPrecio().ToString() + " = " + perfumes.labelSubTotalMujer.Text);
            writer.WriteLine("Total De Perfumes de Hombre: " + perfumes.labelCantHombre.Text + " X " + pHombre.getPrecio().ToString() + " = " + perfumes.labelSubTotalHombre.Text);
            writer.WriteLine("Total De Perfumes de Ropa: " + perfumes.labelCantRopa.Text + " X " + pRopa.getPrecio().ToString() + " = " + perfumes.labelSubTotalRopa.Text);
            writer.WriteLine("Total De Perfumes de Aroma: " + perfumes.labelCantAroma.Text + " X " + pAroma.getPrecio().ToString() + " = " + perfumes.labelSubTotalAroma.Text);
            writer.WriteLine("Total: " + perfumes.labelTOTAL.Text);
        }

        internal void PersistirLista(string fileName,Perfumes perfumes, PerfumeMujer pMujer, PerfumeHombre pHombre, PerfumeRopa pRopa, PerfumeAromatizante pAroma)
        {
            archGuar[] element = new archGuar[100];   //EL 100 SE DEBE CAMBIAR POR LA CANTIDAD TOTAL DE PERFUMES.
            int i = 0;

            if (Convert.ToInt32(perfumes.numericUpDownM0.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer0.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownM0.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM1.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer1.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM1.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM2.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer2.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM2.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM3.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer3.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM3.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM4.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer4.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM4.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM5.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer5.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM5.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM6.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer6.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM6.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM7.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer7.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM7.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM8.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer8.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM8.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM9.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer9.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM9.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM10.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer10.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM10.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM11.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer11.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM11.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM12.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer12.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM12.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM13.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer13.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM13.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM14.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer14.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM14.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM15.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer15.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM15.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM16.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer16.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM16.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM17.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer17.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM17.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM18.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer18.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM18.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM19.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer19.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM19.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM20.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer20.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM20.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM21.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer21.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM21.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM22.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer22.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM22.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM23.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer23.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM23.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownM24.Value) != 0) { element[i].tipo = "M"; element[i].nombre = perfumes.comboBoxPerfumeMujer24.Text; element[1].cantidad = Convert.ToInt32(perfumes.numericUpDownM24.Value); i++; }
            //PERSISTIR HOMBRE
            if (Convert.ToInt32(perfumes.numericUpDownH1.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH1.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH2.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre2.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH2.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH3.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre3.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH3.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH4.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre4.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH4.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH5.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre5.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH5.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH6.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre6.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH6.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH7.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre7.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH7.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH8.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre8.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH8.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH9.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre9.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH9.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH10.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre10.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH10.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH11.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre11.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH11.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH12.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre12.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH12.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH13.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre13.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH13.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH14.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre14.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH14.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH15.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre15.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH15.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownH16.Value) != 0) { element[i].tipo = "H"; element[i].nombre = perfumes.comboBoxPerfumeHombre16.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownH16.Value); i++; }

            //PERSISTIR ROPA
            if (Convert.ToInt32(perfumes.numericUpDownR1.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR1.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR2.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa2.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR2.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR3.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa3.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR3.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR4.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa4.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR4.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR5.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa5.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR5.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR6.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa6.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR6.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR7.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa7.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR7.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR8.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa8.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR8.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR9.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa9.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR9.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR10.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa10.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR10.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownR11.Value) != 0) { element[i].tipo = "R"; element[i].nombre = perfumes.comboBoxRopa11.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownR11.Value); i++; }
            //ACTULIZAR AROMATIZANTE
            if (Convert.ToInt32(perfumes.numericUpDownA1.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA1.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA1.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownA2.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA2.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA2.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownA3.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA3.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA3.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownA4.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA4.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA4.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownA5.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA5.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA5.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownA6.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA6.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA6.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownA7.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA7.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA7.Value); i++; }
            if (Convert.ToInt32(perfumes.numericUpDownA8.Value) != 0) { element[i].tipo = "A"; element[i].nombre = perfumes.comboBoxA8.Text; element[i].cantidad = Convert.ToInt32(perfumes.numericUpDownA8.Value); i++; }

                        
            
            XmlSerializer serializer = new XmlSerializer(typeof(archGuar[]));
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, element);
            writer.Close();
        }
                

        internal double getDataprecioMujerDescuento()
        {
            return Convert.ToDouble(row[1]);

        }

        internal double getDataprecioMujer()
        {
            return Convert.ToDouble(row[0]);
        }

        internal double getDataprecioHombre()
        {
            return Convert.ToDouble(row[0]);
        }

        internal double getDataprecioHombreDescuento()
        {
            return Convert.ToDouble(row[1]);
        }

        internal double getDataprecioRopa()
        {
            return Convert.ToDouble(row[2]);
        }

        internal double getDataprecioAroma()
        {
            return Convert.ToDouble(row[3]);
        }



        internal void CambiarPrecios(decimal cuerpo, decimal cuerpoDesc, decimal ropa, decimal aroma)
        {
            
            dsPrecios.ReadXml("Precio.xml");
            DataRow row = dsPrecios.Tables["Precio"].Rows[0];
            dsPrecios.Tables["Precio"].Rows[0].SetField("precioPerfumeComun",Convert.ToDouble(cuerpo));
            dsPrecios.Tables["Precio"].Rows[0].SetField("precioPerfumeComunDescuento", Convert.ToDouble(cuerpoDesc));
            dsPrecios.Tables["Precio"].Rows[0].SetField("precioRopa", Convert.ToDouble(ropa));
            dsPrecios.Tables["Precio"].Rows[0].SetField("precioAroma", Convert.ToDouble(aroma));
            dsPrecios.WriteXml("Precio.xml");
            MessageBox.Show("Precios Camiados Correctamente");
         
        }

        internal void setearPrecios(PerfumeMujer pMujer, PerfumeHombre pHombre, PerfumeRopa pRopa, PerfumeAromatizante pAroma)
        {
            pMujer.setPrecio(getDataprecioMujer());
            pMujer.setPrecioDescuento(getDataprecioMujerDescuento());
            pHombre.setPrecio(getDataprecioHombre());
            pHombre.setPrecioDescuento(getDataprecioHombreDescuento());
            pRopa.setPrecio(getDataprecioRopa());
            pAroma.setPrecio(getDataprecioAroma());
        }
    }
}



