
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
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

            txtNombrePk.Visibility = Visibility.Collapsed;
            txtDescripcionPk.Visibility = Visibility.Collapsed;
            txtCategoriaPk.Visibility = Visibility.Collapsed;
            txtAlturaPk.Visibility = Visibility.Collapsed;
            txtPesoPk.Visibility = Visibility.Collapsed;
            imgPokemon.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Método encargado de filtrar 
        /// el contenido de la listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filtrar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener los valores de los filtros
            string filtroNombre = txtFiltroNombre.Text.Trim();
            List<Pokemon> listaFiltrada = listaPokemon;

            if (!string.IsNullOrEmpty(filtroNombre))
            {
                listaFiltrada = listaFiltrada.Where(p => p.Nombre.ToLower().Contains(filtroNombre.ToLower())).ToList();
            }

            // Actualizar la lista
            lstPokemon.ItemsSource = listaFiltrada;
        }
        
        /// <summary>
        /// Conecta con la base de dato SQLite
        /// y obtiene todos los datos para la
        /// rellenar la pokedex
        /// </summary>
        private void conectarDB()
        {
            string rutaCarpeta = "Assets"; // Ruta relativa de la carpeta dentro del proyecto
            string nombreArchivo = "pokemons.db"; // Nombre del archivo
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.Combine(directorioBase, rutaCarpeta, nombreArchivo);

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
                            listaPokemon.Add(new Pokemon(read.GetInt32(1), read.GetString(2), read.GetString(3), read.GetString(4), read.GetFloat(5), read.GetFloat(6), read.GetString(7), read.GetString(8)));
                        }
                    }
                }
            }
            // ItemsSource del ListView
            lstPokemon.ItemsSource = listaPokemon;
        }

        public static readonly DependencyProperty ImagenSourceProperty = DependencyProperty.Register("ImagenSource", typeof(ImageSource), typeof(PokeDex), new PropertyMetadata(null));

        /// <summary>
        /// Utilizado para la fuente de imagen
        /// </summary>
        public BitmapImage ImagenSource
        {
            get { return (BitmapImage)GetValue(ImagenSourceProperty); }
            set { SetValue(ImagenSourceProperty, value); }
        }


        /// <summary>
        /// Cuando la selección en la
        /// listView cambia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstPokemon.SelectedItem != null)
            {
                Pokemon pk = (Pokemon)lstPokemon.SelectedItem;

                //Imagen
                string rutaCarpeta1 = "Assets";
                string rutaCarpeta2 = "PoKeDex";
                string nombreArchivo = pk.Nombre.ToLower() + ".png";

                string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivo = Path.Combine(directorioBase, rutaCarpeta1, rutaCarpeta2, nombreArchivo.Replace(" ", "").Trim());

                ImagenSource = new BitmapImage(new Uri(rutaArchivo));
                imgPokemon.Source = ImagenSource;

                //Datos Pokemon
                txtNombrePk.Text = pk.Nombre;
                txtDescripcionPk.Text = pk.Descripcion;
                txtCategoriaPk.Text = pk.Categoria;
                txtAlturaPk.Text = "Altura-> "+pk.Altura.ToString()+"m";
                txtPesoPk.Text = "Peso-> " + pk.Peso.ToString() + "Kg";

                txtNombrePk.Visibility = Visibility.Visible;
                txtDescripcionPk.Visibility = Visibility.Visible;
                txtCategoriaPk.Visibility = Visibility.Visible;
                txtAlturaPk.Visibility = Visibility.Visible;
                txtPesoPk.Visibility = Visibility.Visible;
                imgPokemon.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Se carga una vez el Page es cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string rutaCarpeta = "Assets"; // Ruta relativa de la carpeta dentro del proyecto
            string nombreArchivo = "fondo.mp4"; // Nombre del archivo

            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            string videoFilePath = Path.Combine(directorioBase, rutaCarpeta, nombreArchivo);

            if (videoFilePath != null)
            {
                // Establece la fuente del MediaElement como el archivo de video
                mediaElement.Source = new Uri(videoFilePath);
                mediaElement.Play();
            }
            
        }

        /// <summary>
        /// Evento cuando acaba el vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            // Reiniciar el video en bucle
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }

        /// <summary>
        /// Cuando pulsamos el botón
        /// de actualizar en la interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            txtFiltroNombre.Text = "";
            conectarDB();
        }
    }
}
