using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.ViewModels
{
    public class ListTablaViewModel
    {

        //Muestra los elementos en un listado o representa los elementos

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }
}