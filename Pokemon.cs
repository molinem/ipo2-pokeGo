using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGo
{
    /// <summary>
    /// Clase que representa un pokemon
    /// que será obtenido de la DB
    /// </summary>
    public class Pokemon
    {
        ///Atributos
        public int Numero;
        public string Imagen;
        public string Nombre;
        public string Descripcion;
        public float Peso;
        public float Altura;
        public string Categoria;
        public string Habilidades;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="Numero"></param>
        /// <param name="Imagen"></param>
        /// <param name="Nombre"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Peso"></param>
        /// <param name="Altura"></param>
        /// <param name="Categoria"></param>
        /// <param name="Habilidades"></param>
        public Pokemon(int Numero, string Imagen, string Nombre, string Descripcion, float Peso, float Altura, string Categoria, string Habilidades)
        {
            this.Numero = Numero;
            this.Imagen = Imagen;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Categoria = Categoria;
            this.Habilidades = Habilidades;
        }
    }
}
