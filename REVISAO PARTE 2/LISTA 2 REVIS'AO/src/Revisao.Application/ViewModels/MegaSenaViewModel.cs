﻿using Revisao.Application.Validação;
using System.ComponentModel.DataAnnotations;

namespace Revisao.Application.ViewModels
{
    public class MegaSenaViewModel
    {      
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int PrimeiroNro { get; set; }
        public int SegundoNro { get; set; }
        public int TerceiroNro { get; set; }
        public int QuartoNro { get; set; }
        public int QuintoNro { get; set; }
        public int SextoNro { get; set; }
        public DateTime DataJogo { get;  set; }
    }
}