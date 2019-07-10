using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboDivision")]
    public class SilaboDivisionModel:AuditoriaModel
    {
        public int Id { get; set; }
        public int IdSilabo { get; set; }
        [ForeignKey("IdSilabo")]
        public virtual SilaboModel Silabo { get; set; }
        public int IdDivision { get; set; }
        [ForeignKey("IdDivision")]
        public virtual DivisionModel Division { get; set; }
        //public SilaboDivicion()
        //{
                
        //}
        //public SilaboDivicion(string vista, int id, string sumilla)
        //{
        //    this.Silabo = new Silabo();
        //    this.Silabo.Id = id;
        //    this.Silabo.Sumilla = sumilla;
        //    this.Divicion = new Divicion();
        //    this.Divicion.Vista = vista;
        //}
    }
}