
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */

using FixacaoConceitosBasicos1.Model;

//Console.WriteLine(SomaDoisNumeros.Somar(1, 3));

//Console.WriteLine(MetrosMilimetros.MetroMili(5));

//Console.WriteLine(CalculaAumento.CalculaAument(5000, 1200));

//Console.WriteLine(CalculaAumento.CalculaDesconto(1200));


//while (true)
{
//try
{
//Console.WriteLine("Informe o primeiro valor");
// int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe o segundo valor");
//int num2 = int.Parse(Console.ReadLine());

//onsole.WriteLine(SomaDoisNumeros.Somar(num1, num2));
       // break;
}

//catch(Exception)
{
//        Console.WriteLine("Digite um valor válido");
};

}



public class SomaNum
{

    static void Calculos()
    {
        int numConv;

        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Somar dois números");
        Console.WriteLine("2 - Converter um número para milimetros");
        numConv = int.Parse(Console.ReadLine());


        while (numConv != 0)
        {
        switch(numConv)
        {
            case 0:
                break;

            case 1:
                Console.WriteLine("Informe o primeiro valor");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo valor");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(SomaDoisNumeros.Somar(num1, num2));
                break;

            case 2:
                Console.WriteLine("Digite um valor para ser convertido");
                int numConvert = int.Parse(Console.ReadLine());
                    break;

        }

        }
        
    }


}






        
    









