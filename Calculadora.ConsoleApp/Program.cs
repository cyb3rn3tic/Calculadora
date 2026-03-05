//Requisito 1: Soma
//Requisito 2: Subtração
//Requisito 3: Multiplicação
//Requisito 4: Divisão
//Requisito 5: Deve permitir a execução de múltiplas operações

bool Executar = true;

while(Executar == true){ 

    //Console.Clear();

    Console.WriteLine("------------------------------");
    Console.WriteLine("Calculadora Simples");
    Console.WriteLine("------------------------------");

    Console.Write("Digite o primeiro número: ");
    string? strNumero1 = Console.ReadLine();
    Console.Write("Digite o segundo número: ");
    string? strNumero2 = Console.ReadLine();

    int Numero1 = Convert.ToInt32(strNumero1);
    int Numero2 = Convert.ToInt32(strNumero2);

    //string ResultadoSoma = Numero1 + Numero2;

    //int ResultadoSoma = Numero1 + Numero2;

    //int ResultadoSubtracao = Numero1 - Numero2;

    Console.WriteLine("\nEscolha a operação desejada: ");
    Console.WriteLine("1 - Soma");  
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("S - Sair");

    //string strOpcao = Console.ReadLine();

    string? Opcao = Console.ReadLine();

    if(Opcao == "S")
    {
        Executar = false;

        continue;
    }

    Console.WriteLine("O primeiro número digitado foi: " + strNumero1);
    Console.WriteLine("O segundo número digitado foi: " + strNumero2);

    //int Opcao = Convert.ToInt32(strOpcao);
    int Resultado;

    if(Opcao == "1")
    {
        Resultado = Numero1 + Numero2;
    }

    else if(Opcao == "2")
    {
        Resultado = Numero1 - Numero2;
    }

    else if(Opcao == "3")
    {
        Resultado = Numero1 * Numero2;
    }

    else
    {
        if(Numero2 == 0)
        {
            Console.WriteLine("\nNão é possível dividir por zero!");
            return;
        } 

            Resultado = Numero1 / Numero2;
    }
    
    Console.WriteLine("\nO resultado dos dois numeros é: " + Resultado + "\n");
}   

