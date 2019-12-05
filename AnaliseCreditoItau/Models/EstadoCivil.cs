using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AnaliseCreditoItau.Models
{
    public enum EstadoCivil
    {
        //Esse valores serão fixos e não serão gravados no banco de dados, por isso usei o enum
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