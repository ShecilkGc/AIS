//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Usuarios
    {

        public int id_usuario { get; set; }
        [RegularExpression("([a-zA-Z]+)", ErrorMessage = "Tu nombre solo debe contener letras")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string app { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string apm { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression("([a-zA-Z0-9]+)", ErrorMessage = "Solo letras y numeros")]
        public string usuario { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression("([a-zA-Z0-9]+)", ErrorMessage = "Este campo es obligatorio")]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "La contraseña debe tener 4 caracteres de largo como maximo")]
        public string contraseña { get; set; }
        public int Id_rol { get; set; }

        public virtual Roles Roles { get; set; }


    }
}
