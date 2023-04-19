
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeGo
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PokeDex : Page
    {
        private List<Pokemon> listaPokemon;

        public PokeDex()
        {
            this.InitializeComponent();

            conectarDB();

            // Valores del ComboBox de filtros
            cmbFiltroCategoria.Items.Add("Pato");
            cmbFiltroCategoria.Items.Add("BolaClavos");
            cmbFiltroCategoria.Items.Add("Estrella");
            cmbFiltroCategoria.Items.Add("Serpiente");
        }

        
        private void Filtrar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener los valores de los filtros
            string filtroNombre = txtFiltroNombre.Text.Trim();
            string filtroTipo = cmbFiltroCategoria.SelectedItem as string;

            List<Pokemon> listaFiltrada = listaPokemon;

            if (!string.IsNullOrEmpty(filtroNombre))
            {
                listaFiltrada = listaFiltrada.Where(p => p.Nombre.ToLower().Contains(filtroNombre.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(filtroTipo))
            {
                listaFiltrada = listaFiltrada.Where(p => p.Categoria.ToLower().Contains(filtroTipo.ToLower())).ToList();
            }

            // Actualizar la lista
            lstPokemon.ItemsSource = listaFiltrada;
            cmbFiltroCategoria.SelectedItem = "Categoria";
        }
        

        /// <summary>
        /// Conecta con la base de dato SQLite
        /// y obtiene todos los datos para la
        /// rellenar la pokedex
        /// </summary>
        private void conectarDB()
        {
            string nombreArchivo = "pokemons.db"; // Nombre del archivo
            string rutaCarpeta = "DB"; // Ruta relativa de la carpeta dentro del proyecto
            string rutaArchivo = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), rutaCarpeta, nombreArchivo);

            string cadenaConexion = "Data Source=" + rutaArchivo;
            listaPokemon = new List<Pokemon>();

            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3()); //Para hacer set del provider
            using (SqliteConnection conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string consultaSql = "SELECT * FROM pokemons";
                using (SqliteCommand comando = new SqliteCommand(consultaSql, conexion)) //Lleva autoclose para la DB
                {
                    using (SqliteDataReader read = comando.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            //System.Diagnostics.Debug.WriteLine(lector.GetInt32(1));
                            listaPokemon.Add(new Pokemon(read.GetInt32(1), read.GetString(2), read.GetString(3), read.GetString(4), read.GetFloat(5), read.GetFloat(6), read.GetString(7), read.GetString(8)));
                        }
                    }
                }
            }
            // ItemsSource del ListView
            lstPokemon.ItemsSource = listaPokemon;
        }

        
        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstPokemon.SelectedItem != null)
            {
                Pokemon pk = (Pokemon)lstPokemon.SelectedItem;
                System.Diagnostics.Debug.WriteLine(pk.Nombre);
            }
        }
    }
}
