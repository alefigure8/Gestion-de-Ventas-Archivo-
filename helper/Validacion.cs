using System.Collections.Generic;
using System.Windows.Forms;
using negocio;
using dominio;
using System;

namespace helper
{
    public static class Validacion
    {
        public static bool esNumero(string numero)
        {
            decimal validar;
            if(decimal.TryParse(numero, out validar))
            {
                return true;
            }

            return false;
        }

        public static List<bool> estaVacio(List<TextBox> list)
        {
            List<bool> bools= new List<bool>();

            foreach(TextBox item in list)
            {
                if (string.IsNullOrEmpty(item.Text) && item.Name != "txtAgregarImagen")
                {
                    bools.Add(true);
                }
                else
                {
                    bools.Add(false);

                }
            }

            return bools;
        }

        public static bool estaSeleccionado(ComboBox combo)
        {
            if (combo.SelectedIndex < 0)
            {
                return false;
            }

            return true;
        }

        public static bool marcaUtilizada(int id)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            List<Producto> listaProducto = productoNegocio.listar();

            bool result = listaProducto.Exists(x => x.MarcaInfo.Id == id);

            return result;
        }

        public static bool categoriaUtilizada(int id)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            List<Producto> listaProducto = productoNegocio.listar();

            bool result = listaProducto.Exists(x => x.CategoriaInfo.Id == id);

            return result;
        }

        public static bool esMayorLaFechaDeInicio(DateTimePicker start, DateTimePicker end)
        {
            if (start.Value > end.Value)
                return true;

            return false;
        }
    }
}
