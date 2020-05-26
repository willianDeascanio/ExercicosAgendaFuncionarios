using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{

    class Gerente : Funcionario
    {
        public Gerente(string nomeParam, float salarioBrutoParam, string CPF)
        {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.cpf = CPF;
        }

        // Construtor vazio
        public Gerente()
        {

        }

        // Construtor com seis parametros
        public Gerente (string nomeParam, float salarioBrutoParam,
                          float descontoParam, float adicionalParam, string CPF, string cargo)
        {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.adicional = adicionalParam;
            this.desconto = descontoParam;
            this.cpf = CPF;
            this.cargo = cargo;
        }

        public override void CalcularBonus(float salario, float desconto, float adicional)
        {
            var salarioLiquido = ((salario - desconto) + adicional);
            this.salarioBonus = salarioLiquido + (salarioLiquido * 2 / 100);
        }

        public override void CalcularBonus(float salario, float adicional)
        {
            var salarioLiquido = (salario + adicional);
            this.salarioBonus = salarioLiquido + (salarioLiquido * 2 / 100);
        }
    }
}