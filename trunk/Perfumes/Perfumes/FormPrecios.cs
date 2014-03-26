using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Perfumes
{
    public partial class FormPrecios : Form
    {
        Persistencia persistidor;
        public FormPrecios(Persistencia persistir)
        {
            persistidor = persistir;
            InitializeComponent();
            this.labelPrecioCuerpo.Text = persistidor.getDataprecioHombre().ToString();
            this.numericUpDownCuerpo.Value = Convert.ToDecimal(persistidor.getDataprecioHombre());
            this.labelPrecioCuerpoDescuento.Text = persistidor.getDataprecioHombreDescuento().ToString();
            this.numericUpDownCuerpoDesc.Value = Convert.ToDecimal(persistidor.getDataprecioHombreDescuento());
            this.labelPrecioRopa.Text = persistidor.getDataprecioRopa().ToString();
            this.numericUpDownRopa.Value = Convert.ToDecimal(persistidor.getDataprecioRopa());
            this.labelPrecioAroma.Text = persistidor.getDataprecioAroma().ToString();
            this.numericUpDownAroma.Value = Convert.ToDecimal(persistidor.getDataprecioAroma());
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            persistidor.CambiarPrecios(this.numericUpDownCuerpo.Value, this.numericUpDownCuerpoDesc.Value, this.numericUpDownRopa.Value, this.numericUpDownAroma.Value);
            this.Close();
        }

        
    }
}
