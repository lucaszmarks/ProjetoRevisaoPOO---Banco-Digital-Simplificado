using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRevisaoPOO
{
    abstract class Conta
    {
        public double  saldo { get; protected set; }
        public int numeroConta { get; set; }
        public int agencia { get; set; }
        public Cliente cliente { get; set; }

        protected Conta(int numeroConta, int agencia, Cliente cliente)
        {
            this.numeroConta = numeroConta;
            this.agencia = agencia;
            this.cliente = cliente;
        }

        public void depositar(double quantidade)
        {
            this.saldo += quantidade;
        }
        public void sacar(double quantidade)
        {
            this.saldo -= quantidade;
        }

    }





}
