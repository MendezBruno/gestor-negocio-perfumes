using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Printing;

namespace Perfumes
{
    public partial class Perfumes : Form
    {
        

        //varibles perfumes
        PerfumeMujer pMujer = new PerfumeMujer();
        PerfumeHombre pHombre = new PerfumeHombre();
        PerfumeRopa pRopa = new PerfumeRopa();
        PerfumeAromatizante pAroma = new PerfumeAromatizante();
        //variable de persistencia
        Persistencia persistir;
        


        public Perfumes(Persistencia persistir)
        {
            InitializeComponent();
            this.persistir = persistir;
            persistir.setearPrecios(pMujer, pHombre, pRopa, pAroma);
            
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int tCantM = 0;
            int tCantH = 0;
            int tCantR = 0;
            int tCantA = 0;
            
            if (Convert.ToInt32(numericUpDownM2.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM2.Value);
            if (Convert.ToInt32(numericUpDownM0.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM0.Value);
            if (Convert.ToInt32(numericUpDownM1.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM1.Value);
            if (Convert.ToInt32(numericUpDownM3.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM3.Value);
            if (Convert.ToInt32(numericUpDownM4.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM4.Value);
            if (Convert.ToInt32(numericUpDownM5.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM5.Value);
            if (Convert.ToInt32(numericUpDownM6.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM6.Value);
            if (Convert.ToInt32(numericUpDownM7.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM7.Value);
            if (Convert.ToInt32(numericUpDownM8.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM8.Value);
            if (Convert.ToInt32(numericUpDownM9.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM9.Value);
            if (Convert.ToInt32(numericUpDownM10.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM10.Value);
            if (Convert.ToInt32(numericUpDownM11.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM11.Value);
            if (Convert.ToInt32(numericUpDownM12.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM12.Value);
            if (Convert.ToInt32(numericUpDownM13.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM13.Value);
            if (Convert.ToInt32(numericUpDownM14.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM14.Value);
            if (Convert.ToInt32(numericUpDownM15.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM15.Value);
            if (Convert.ToInt32(numericUpDownM16.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM16.Value);
            if (Convert.ToInt32(numericUpDownM17.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM17.Value);
            if (Convert.ToInt32(numericUpDownM18.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM18.Value);
            if (Convert.ToInt32(numericUpDownM19.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM19.Value);
            if (Convert.ToInt32(numericUpDownM20.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM20.Value);
            if (Convert.ToInt32(numericUpDownM21.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM21.Value);
            if (Convert.ToInt32(numericUpDownM22.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM22.Value);
            if (Convert.ToInt32(numericUpDownM23.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM23.Value);
            if (Convert.ToInt32(numericUpDownM24.Value) != 0) tCantM = tCantM + Convert.ToInt32(numericUpDownM24.Value);
            //ACTULIZAR HOMBRE
            if (Convert.ToInt32(numericUpDownH1.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH1.Value);
            if (Convert.ToInt32(numericUpDownH2.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH2.Value);
            if (Convert.ToInt32(numericUpDownH3.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH3.Value);
            if (Convert.ToInt32(numericUpDownH4.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH4.Value);
            if (Convert.ToInt32(numericUpDownH5.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH5.Value);
            if (Convert.ToInt32(numericUpDownH6.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH6.Value);
            if (Convert.ToInt32(numericUpDownH7.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH7.Value);
            if (Convert.ToInt32(numericUpDownH8.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH8.Value);
            if (Convert.ToInt32(numericUpDownH9.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH9.Value);
            if (Convert.ToInt32(numericUpDownH10.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH10.Value);
            if (Convert.ToInt32(numericUpDownH11.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH11.Value);
            if (Convert.ToInt32(numericUpDownH12.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH12.Value);
            if (Convert.ToInt32(numericUpDownH13.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH13.Value);
            if (Convert.ToInt32(numericUpDownH14.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH14.Value);
            if (Convert.ToInt32(numericUpDownH15.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH15.Value);
            if (Convert.ToInt32(numericUpDownH16.Value) != 0) tCantH = tCantH + Convert.ToInt32(numericUpDownH16.Value);
            //Actualizar ROPA
            if (Convert.ToInt32(numericUpDownR1.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR1.Value);
            if (Convert.ToInt32(numericUpDownR2.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR2.Value);
            if (Convert.ToInt32(numericUpDownR3.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR3.Value);
            if (Convert.ToInt32(numericUpDownR4.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR4.Value);
            if (Convert.ToInt32(numericUpDownR5.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR5.Value);
            if (Convert.ToInt32(numericUpDownR6.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR6.Value);
            if (Convert.ToInt32(numericUpDownR7.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR7.Value);
            if (Convert.ToInt32(numericUpDownR8.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR8.Value);
            if (Convert.ToInt32(numericUpDownR9.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR9.Value);
            if (Convert.ToInt32(numericUpDownR10.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR10.Value);
            if (Convert.ToInt32(numericUpDownR11.Value) != 0) tCantR = tCantR + Convert.ToInt32(numericUpDownR11.Value);
           //ACTULIZAR AROMATIZANTE
            if (Convert.ToInt32(numericUpDownA1.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA1.Value);
            if (Convert.ToInt32(numericUpDownA2.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA2.Value);
            if (Convert.ToInt32(numericUpDownA3.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA3.Value);
            if (Convert.ToInt32(numericUpDownA4.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA4.Value);
            if (Convert.ToInt32(numericUpDownA5.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA5.Value);
            if (Convert.ToInt32(numericUpDownA6.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA6.Value);
            if (Convert.ToInt32(numericUpDownA7.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA7.Value);
            if (Convert.ToInt32(numericUpDownA8.Value) != 0) tCantA = tCantA + Convert.ToInt32(numericUpDownA8.Value);

            pMujer.setCantidad(tCantM);
            pHombre.setCantidad(tCantH);
            pRopa.setCantidad(tCantR);
            pAroma.setCantidad(tCantA);
            actualizarMujer(pMujer);
            actulizarHombre(pHombre);
            actulizarRopa(pRopa);
            actulizarAroma(pAroma);
            actualizarTotal((pAroma.ActualizarTotal() + pRopa.ActualizarTotal() + pHombre.ActualizarTotal() + pMujer.ActualizarTotal()).ToString());


            

        }

        private void actualizarTotal(string total)
        {
            this.labelTOTAL.Text = total;
        }

        private void actualizarMujer(PerfumeMujer pMujer)
        {
            this.labelSubTotalMujer.Text = pMujer.ActualizarTotalString();
            this.labelCantMujer.Text = pMujer.getCantidadString();
        }

        private void actulizarHombre(PerfumeHombre pHombre)
        {
            this.labelSubTotalHombre.Text = pHombre.ActualizarTotalString();
            this.labelCantHombre.Text = pHombre.getCantidadString();
        }

        private void actulizarRopa(PerfumeRopa pRopa)
        {
            this.labelCantRopa.Text = pRopa.getCantidadString();
            this.labelSubTotalRopa.Text = pRopa.ActualizarTotalString();
        }

        private void actulizarAroma(PerfumeAromatizante pAroma)
        {
            this.labelSubTotalAroma.Text = pAroma.ActualizarTotalString();
            this.labelCantAroma.Text = pAroma.getCantidadString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
           persistir.GuardarLista(this, pMujer, pHombre, pRopa, pAroma);
        }

        private void buttonImprimir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("entre a la carpeta de Listas guardas y selecione la lista que desea imprimir");
            /*
            PrintDialog pdl = new PrintDialog();
            pdl.ShowDialog();

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            pd.Print();
             * */
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            float xp = 10;
            float yp = 20;
            System.Drawing.Font printFont = new Font("Courier", 12);
            string printString = "hola";
            e.Graphics.DrawString(printString,printFont, Brushes.Black, xp, yp, new StringFormat());
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            persistir.cargarLista(this);
        }

        private void buttonPrecios_Click_1(object sender, EventArgs e)
        {
            FormPrecios fPrecio = new FormPrecios(persistir);
            fPrecio.ShowDialog();
            persistir.setearPrecios(pMujer, pHombre, pRopa, pAroma);
        }

       
    }
}
