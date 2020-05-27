using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Usuario
    {
        private string nome;
        private DateTime dataNascimento;
        private double altura;
        private double peso;

        public string Nome
        {
            set
            {
                if (value!= string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }

        public DateTime DataNascimento
        {
            set 
            {

                if (DateTime.Now.Year - this.dataNascimento.Year >= 1)
                {
                    this.dataNascimento = value;
                }
                else
                {
                    throw new Exception("O ano de nascimento deve ser anterior ao escolhido.");
                }
            }
            get { return this.dataNascimento; }
        }
        public double Altura
        {
            set
            {
                if (value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura deve ser maior que 1 metro.");
                }
            }
            get { return this.altura; }
        }
        public double Peso
        {
            set
            {
                if (value >= 10.00)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso deve ser maior que 10 quilogramas.");
                }
            }
            get { return this.peso; }
        }
        public string ImprimeDados()
        {
            return "\n\nNome: " + this.nome +
                    "\nData de Nascimento: " + this.dataNascimento.ToString("dd/MM/yyy") +
                    "\nAltura: " + this.altura.ToString("0.00") + "m" +
                    "\nPeso: " + this.peso.ToString("00.0") + "Kg.";
        }
        public double CalcularIMC()
        {
            return this.peso / (this.altura * this.altura);
        }
        public int CalcularIdade()
        {
            return DateTime.Now.Year - this.dataNascimento.Year;
        }
    }
}
