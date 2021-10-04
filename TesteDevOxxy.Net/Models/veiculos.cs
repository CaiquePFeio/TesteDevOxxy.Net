using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteDevOxxy.Net.Models
{
    public class veiculos
    {
        [Key]
        public int Veiculo { get; set; }

        [Required(ErrorMessage = "Campo Placa: preenchimento obrigatório.")]
        [MaxLength(8, ErrorMessage = "Campo Placa: aceita no máximo 8 caracteres.")]
        [MinLength(8, ErrorMessage = "Campo Placa: aceita no minimo 8 caracteres.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Campo Renavam: preenchimento obrigatório.")]
        [MaxLength(11, ErrorMessage = "Campo Renavam: aceita no máximo 11 caracteres.")]
        [MinLength(11, ErrorMessage = "Campo Renavam: aceita no minimo 11 caracteres.")]
        public string Renavam { get; set; }

        [Required(ErrorMessage = "Campo Nome: preenchimento obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo CPF: preenchimento obrigatório.")]
        [MaxLength(11, ErrorMessage = "Campo CPF: aceita no máximo 11 caracteres.")]
        [MinLength(11, ErrorMessage = "Campo CPF: aceita no minimo 11 caracteres.")]
        public string CPF { get; set; }


        public HashCode Carregar { get; set; }
        public bool Bloqueado { get; set; }
    }
}