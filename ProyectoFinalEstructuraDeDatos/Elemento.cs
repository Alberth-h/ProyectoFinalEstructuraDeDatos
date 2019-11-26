using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class Elemento
    {
        public string titulo { get; set; }
        public string anno { get; set; }
        public string genero { get; set; }
        public string temporadas { get; set; }
        public string productor { get; set; }
        public string descripcion { get; set; }
        public string rating { get; set; }

        public Elemento(string Titulo, string Anno, string Genero, string Temporadas, string Productor, string Descripcion, string Rating)
        {
            this.titulo = Titulo;
            this.anno = Anno;
            this.genero = Genero;
            this.temporadas = Temporadas;
            this.productor = Productor;
            this.descripcion = Descripcion;
            this.rating = Rating;
        }

        public override string ToString()
        {
            return this.titulo + "(" + this.anno + ")";
        }
    }
}
