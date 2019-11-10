using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        private string _CPF;

        /// <summary>
        /// CPF
        /// </summary>
        [Required(ErrorMessage = "O Campo CPF obrigatório")]
        [CustomValidationCPF(ErrorMessage = "O CPF informado é inválido")]
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = Regex.Replace(value, @"[^\d]+", ""); }
        }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }
    }
}