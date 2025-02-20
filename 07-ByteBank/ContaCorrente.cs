﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        private int _agencia { get; set; }
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

        public int Numero { get; set; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;

            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo <= valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }


        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }

    }
}
