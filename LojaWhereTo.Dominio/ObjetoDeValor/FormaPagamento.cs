using LojaWhereTo.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaWhereTo.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool SeBoleto {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; } 
        }
        public bool SeCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool SeDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool SeNaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
