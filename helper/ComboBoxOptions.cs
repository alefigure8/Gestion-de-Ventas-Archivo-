using configuracion;
using System;
using System.Linq;
using dominio;
using System.Windows.Forms;
using System.Collections.Generic;


namespace helper
{
    public static class ComboBoxOptions
    {
        public static void comboBoxMarca(ComboBox combo, bool todos = false)
        {
            try
            {
                listaDesplegable listaMarca = new listaDesplegable();
                List<Marca> aux = listaMarca.cargarMarcas(todos);
                Console.WriteLine(aux.Count);
                Console.WriteLine(aux);

                //Solo carga si hay elementos encontrados para evitar errores
                if (aux.Count > 0)
                {
                    combo.DataSource = aux.OrderBy((x) => x.Descripcion).ToList(); ;
                    combo.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Opciones.MensajeError.LISTAERROR);
            }
        }

        public static void comboBoxCategoria(ComboBox combo, bool todos = false)
        {
            try
            {
                listaDesplegable listaCategoria = new listaDesplegable();
                List<Categoria> aux = listaCategoria.cargarCategorias(todos);

                //Solo carga si hay elementos encontrados para evitar errores
                if(aux.Count > 0)
                {
                    combo.DataSource = aux.OrderBy((x) => x.Descripcion).ToList();
                    combo.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Opciones.MensajeError.LISTAERROR);
            }
        }

        public static void comboBoxProductos(ComboBox combo)
        {
            listaDesplegable listaProducto = new listaDesplegable();
            combo.DisplayMember = "Nombre";
            List<Producto> aux = listaProducto.cargarProductos();

            //Solo carga si hay elementos encontrados para evitar errores
            if(aux.Count > 0)
            {
                combo.DataSource = aux.OrderBy(x => x.Nombre).ToList();
            }
        }

        public static void comboBoxCamposBusquedaAvanzada(ComboBox combo)
        {
            try
            {
                listaDesplegable listaCampos = new listaDesplegable();
                combo.DataSource = listaCampos.cargarBusqueraColumnas();
                combo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show(Opciones.MensajeError.LISTAERROR);
            }
        }

        public static void comboBoxOpcionesDescarga(ComboBox combo)
        {
            try
            {
                listaDesplegable listaCampos = new listaDesplegable();
                combo.DataSource = listaCampos.cargarOpcionesDescarga();
                combo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show(Opciones.MensajeError.LISTAERROR);
            }
        }

        public static void comboBoxOrdenarPor(ComboBox combo)
        {
            try
            {
                listaDesplegable listaOrdenadoPor = new listaDesplegable();
                combo.DataSource = listaOrdenadoPor.cargarBusqueraColumnas();
                combo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show(Opciones.MensajeError.LISTAERROR);
            }
        }


        public static void comboBoxCantidad(ComboBox combo)
        {
            try
            {
                listaDesplegable listaCantidad = new listaDesplegable();
                combo.DataSource = listaCantidad.cargarBusquedaNumeros();
                combo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show(Opciones.MensajeError.LISTAERROR);
            }
        }
    }

}
