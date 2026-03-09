//Requisito 1: Soma
//Requisito 2: Subtração
//Requisito 3: Multiplicação
//Requisito 4: Divisão
//Requisito 5: Deve permitir a execução de múltiplas operações
//Requisito 6: Tabuada
//Requisito 7: Deve mostrar o histórico de operações realizadas

string[] historicoOperacoes = new string[100]; //array
int totalOperacoes = 0;

while(true) // true = true, ou seja, o programa vai rodar para sempre, até que o usuário escolha a opção de sair (S ou s)
{ 
    
    Console.Clear();

    Console.WriteLine("------------------------------");
    Console.WriteLine("Calculadora Simples");
    Console.WriteLine("------------------------------");

    Console.WriteLine("\nEscolha a operação desejada: ");
    Console.WriteLine("1 - Soma");  
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico de operações");
    Console.WriteLine("S - Sair");

    string? Opcao = Console.ReadLine();

    if(Opcao == "S" || Opcao == "s")
    {
        return;
    }

    if(Opcao == "5")
    {
        Console.Write("Digite o número desejado para a tabuada: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nTabuada do " + numeroTabuada + ":\n");

        for(int cont = 1; cont <= 10; cont++)
        {
            int resultadoTabuada = numeroTabuada * cont;

            Console.WriteLine(numeroTabuada + " x " + cont + " = " + resultadoTabuada);
        }

        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();

        continue;
    }

    else if(Opcao == "6")
    {
        Console.WriteLine("------------------------------"); 
        Console.WriteLine("Historico de operações: \n");
        
        if(totalOperacoes == 0)
        {
            Console.WriteLine("Sem operações no histórico!");
            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            continue;    
        }

        else 
        for(int cont = 0; cont < totalOperacoes; cont++) //historicoOperacoes.Length no lugar de 10
        {
            Console.WriteLine(historicoOperacoes[cont]);
        }
            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            continue;
    }    


    Console.Write("Digite o primeiro número: ");
    string? strNumero1 = Console.ReadLine();
    Console.Write("Digite o segundo número: ");
    string? strNumero2 = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + strNumero1);
    Console.WriteLine("O segundo número digitado foi: " + strNumero2);

    bool Numero1Vazio = string.IsNullOrEmpty(strNumero1);
    bool Numero2Vazio = string.IsNullOrEmpty(strNumero2);

    if(Numero1Vazio == true || Numero2Vazio == true)
    {
        Console.WriteLine("\nPor favor, digite um número válido!\n");
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    
        continue;
    }

    decimal Numero1 = Convert.ToDecimal(strNumero1);
    decimal Numero2 = Convert.ToDecimal(strNumero2);

    decimal Resultado;

    switch(Opcao)
    {
        case "1":
            Resultado = Numero1 + Numero2;
            break;

        case "2":
            Resultado = Numero1 - Numero2;
            break;

        case "3":
            Resultado = Numero1 * Numero2;
            break;

        case "4":
            if(Numero2 == 0)
            {
                Console.WriteLine("\nNão é possível dividir por zero!");
                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();

                continue;
            }

            Resultado = Numero1 / Numero2;
            break;

        default:
            Console.WriteLine("\nOpção inválida! Por favor, escolha uma opção válida.\n");
            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();

            continue;
    }

    if(totalOperacoes < historicoOperacoes.Length)
    {  
        if(Resultado == Numero1 + Numero2)
        {
            historicoOperacoes[totalOperacoes] = $"{Numero1} + {Numero2} = {Resultado}"; 
        }
        else if(Resultado == Numero1 - Numero2)
        {
            historicoOperacoes[totalOperacoes] = $"{Numero1} - {Numero2} = {Resultado}";
        }
        else if(Resultado == Numero1 * Numero2)
        {
            historicoOperacoes[totalOperacoes] = $"{Numero1} x {Numero2} = {Resultado}";
        }
        else 
        {
            historicoOperacoes[totalOperacoes] = $"{Numero1} / {Numero2} = {Resultado}";
        }
        totalOperacoes ++;
    }
    
    Console.WriteLine("\nO resultado dos dois numeros é: " + Resultado + "\n");
    Console.WriteLine("\nPressione Enter para continuar...");
    Console.ReadLine();
}