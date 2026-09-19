using System;

namespace CalculadoraSemiCientifica
{
  
    public class CalculadoraEngine
    {
      
        private double _memoria;

       
        public bool PossuiValorNaMemoria => _memoria != 0;

      
        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

      
        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

      
        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

    
        public double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }

            return valor1 / valor2;
        }

   
        public double RaizQuadrada(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
            }

            return Math.Sqrt(valor);
        }

 
        public double Potencia(double valorBase, double expoente)
        {
            return Math.Pow(valorBase, expoente);
        }

        
        public double Calcular(double valor1, double valor2, string operacao)
        {
            switch (operacao)
            {
                case "+":
                    return Somar(valor1, valor2);
                case "-":
                    return Subtrair(valor1, valor2);
                case "x":
                case "*":
                    return Multiplicar(valor1, valor2);
                case "/":
                    return Dividir(valor1, valor2);
                case "^":
                    return Potencia(valor1, valor2);
                default:
                    throw new InvalidOperationException("Operação inválida.");
            }
        }

        
        public void AdicionarNaMemoria(double valor)
        {
            _memoria += valor;
        }

      
        public double RecuperarMemoria()
        {
            return _memoria;
        }

        
        public void LimparMemoria()
        {
            _memoria = 0;
        }
    }
}
