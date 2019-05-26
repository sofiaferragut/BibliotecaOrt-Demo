using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaOrt_Demo.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Libro LibroHardcodeado() {
            Libro l = new Libro();
            l.Nombre = "HarryPotter";
            return l;
        }
        
    }
}