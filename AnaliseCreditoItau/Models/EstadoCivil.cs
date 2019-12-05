using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AnaliseCreditoItau.Models
{
    public enum EstadoCivil
    {
        //Esse valores serão fixos e não serão gravados no banco, por isso q usei o enum
        //As informações abaixo serão exibidas de acordo com o valor que foi definido no name.
        [Display(Name = "Solteiro")]
        Solteiro,
        [Display(Name = "Casado")]
        Casado,
        [Display(Name = "Divorciado")]
        Divorciado,
        [Display(Name = "Viuvo")]
        Viuvo,
        [Display(Name = "Separado(a)")]
        Serparado
    }
}