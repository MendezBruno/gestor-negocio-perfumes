using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfumes
{
    class Perfume
    {
        double precio;
        int cantidad;

        public Perfume()
        {
            precio = 0;
            cantidad = 0;
        }

        public double ActualizarTotal()
        {
            return precio * cantidad;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setCantidad(int cant)
        {
            this.cantidad = cant;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public string getCantidadString()
        {
            return cantidad.ToString();
        }

        public string ActualizarTotalString()
        {
            return ActualizarTotal().ToString();
        }
    }
}
