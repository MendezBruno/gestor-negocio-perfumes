using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfumes
{
    class PerfumeHombre: Perfume
    {
        double precioDescuento;

        public void setPrecioDescuento(double precio)
        {
            this.precioDescuento = precio;
        }

        public double getPrecioDescuento()
        {
            return this.precioDescuento;
        }
        
    }
}
