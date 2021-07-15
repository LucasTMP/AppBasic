using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppBasic.Models
{
    public class Produto : Entity
    {

        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string Image { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /* EF Relations */

        public Fornecedor Fornecedor { get; set; }

    }
}
