using System.Data.Common;
using System.Xml.Schema;

namespace Tareas
{
    class Tarea{
        //Atributos
        public int Id {get; set;}
        public char Descripcion {get;set;}
        public int Duracion {get;set;}

        //Constructor
        public Tarea(int id, char descripcion, int duracion){
            Id = id;
            Descripcion = descripcion;
            Duracion = duracion;
        }
        //Metodos
    }
}