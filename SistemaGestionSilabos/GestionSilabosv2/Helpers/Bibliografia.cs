using GestionSilabos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Helpers
{
    public class Bibliografia
    {
        private List<Libro> libros;

        public Bibliografia(List<Libro> libros)
        {
            this.libros = libros;
        }

        public List<Libro> Libros { get => libros; set => libros = value; }
        public Bibliografia()
        {

        }
    }
}