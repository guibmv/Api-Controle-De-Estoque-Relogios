﻿using System.Xml.Schema;

namespace SistemaCadastroRelogios.Models
{
    public class Relogio
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public int IdCor { get; set; }
        public decimal Preco { get; set; }
        public string Garantia { get; set; }
        public string Referencia { get; set; }
    }
}
