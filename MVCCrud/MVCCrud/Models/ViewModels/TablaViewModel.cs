using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.ViewModels
{
    public class TablaViewModel
    {

        //Recibe los elementos
        public int Id { get; set; }

        //Datanotation para hacer validaciones
        [Required]
        //Validacion
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        //Valida que es un correo
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Correo { get; set; }

        [Required]
        //Tipo del editorford (Date)
        [DataType(DataType.Date)] 
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Nacimiento { get; set; }





    }
}