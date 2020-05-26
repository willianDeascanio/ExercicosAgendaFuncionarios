﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class ListaFuncionario
    {
        // Atributo da classe ListaFuncionario: Funcionarios
        // Funcionarios = lista de objetos Funcionario
        List<Funcionario> Funcionarios = new List<Funcionario>();

        // Metodo Procedure (sem retorno)
        // Que irá inserir um unico objeto Funcionario dentro da lista de objetos Funcionarios
        public void ArmazenarFuncionario(string nome, float salario, float desconto,
                                         float adicional, float bonus, string cpf, bool semDesconto, string cargo)
        {
            // Cada item (indice) da lista é um objeto Funcionario que contem nome, cpf, salario, desconto
            if (cargo == "gerente")
            {
                Gerente gerenteObj = new Gerente(nome, salario, desconto, adicional, cpf, cargo);

                // dependendo do valor da variavel semDesconto
                // executa versões diferentes da CalcularLiquido (conceito de sobrecarga)
                if (semDesconto)
                {
                    gerenteObj.CalcularLiquido(gerenteObj.salarioBruto, gerenteObj.adicional);
                    gerenteObj.CalcularBonus(gerenteObj.salarioBruto, gerenteObj.adicional);
                }
                else
                {
                    gerenteObj.CalcularLiquido(gerenteObj.salarioBruto, gerenteObj.desconto, gerenteObj.adicional);
                    gerenteObj.CalcularBonus(gerenteObj.salarioBruto, gerenteObj.desconto, gerenteObj.adicional);
                }
                // Função add é herdada da list
                Funcionarios.Add(gerenteObj);
            }
            else
            {
                Funcionario funcionarioObj = new Funcionario(nome, salario, desconto, adicional, cpf, cargo);

                // dependendo do valor da variavel semDesconto
                // executa versões diferentes da CalcularLiquido (conceito de sobrecarga)
                if (semDesconto)
                {
                    funcionarioObj.CalcularLiquido(funcionarioObj.salarioBruto, funcionarioObj.adicional);
                    funcionarioObj.CalcularBonus(funcionarioObj.salarioBruto, funcionarioObj.adicional);
                }
                else
                {
                    funcionarioObj.CalcularLiquido(funcionarioObj.salarioBruto, funcionarioObj.desconto, funcionarioObj.adicional);
                    funcionarioObj.CalcularBonus(funcionarioObj.salarioBruto, funcionarioObj.desconto, funcionarioObj.adicional);
                }
                // Função add é herdada da list
                Funcionarios.Add(funcionarioObj);
            }
        }
        public void RemoverFuncionario(String nome)
        {
            // Função removeall é herdada da list
            Funcionarios.RemoveAll(f => f.nome == nome); // a expressão lambda é uma representação :
                                                        // (input-parameters) => expression
        }

        public int BuscarFuncionario(String nome)
        {
            // Função findindex é herdada da list
            return Funcionarios.FindIndex(f => f.nome == nome); // expressao lambda. Parametro f do tipo Funcionario
                                                                // variavel capturada: nome comparada com o nome recebido por parametro
        }

        public void OrdenarFuncionario()
        {
            // Função OrderBy é herdada da list
            Funcionarios = Funcionarios.OrderBy(f => f.nome).ToList();
        }
        
        // Retorna o tamanho da list.
        // Lembrando que esses metodos da list só existem dentro da classe.
        // em outro escopo, instanciado a classe ListaFuncionario, a lista está encapsulada dentro do objeto
        // por isso é enrxgado como list apenas dentro da classe
        public int RetornarTamanhoLista()
        {
            return Funcionarios.Count;
        }

        // busca um unico objeto funcionario, de acordo com o indice recebido.
        // retorna um unico objeto Funcionario
        // lembrando que aqui temos uma lista de vários objetos funcionarios, um em cada indice
        public Funcionario RetornaObjetoFuncionario(int index)
        {
            // var é uma forma implicita de definir um dado.
            // a variavel irá tomar a forma que lhe form atribuido
            var funcionarioObj = Funcionarios[index]; // perceba que aqui pode-se manipular a lista diretamente com colchetes 
            return funcionarioObj;
        }
    }
}
