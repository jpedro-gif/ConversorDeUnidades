while (true)
{
    Console.WriteLine("\n=== CONVERSOR DE UNIDADES ===");
    Console.WriteLine("1. Temperatura (Celsius ↔ Fahrenheit)");
    Console.WriteLine("2. Distância (Km ↔ Milhas)");
    Console.WriteLine("3. Peso (Kg ↔ Libras)");
    Console.WriteLine("4. Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine("\n1. Celsius para Fahrenheit");
        Console.WriteLine("2. Fahrenheit para Celsius");
        Console.Write("Escolha: ");
        string tipo = Console.ReadLine();

        Console.Write("Digite o valor: ");
        double valor = double.Parse(Console.ReadLine());

        if (tipo == "1")
        {
            double resultado = (valor * 9 / 5) + 32;
            Console.WriteLine($"\n{valor}°C = {resultado:F2}°F");
        }
        else if (tipo == "2")
        {
            double resultado = (valor - 32) * 5 / 9;
            Console.WriteLine($"\n{valor}°F = {resultado:F2}°C");
        }
    }
    else if (opcao == "2")
    {
        Console.WriteLine("\n1. Km para Milhas");
        Console.WriteLine("2. Milhas para Km");
        Console.Write("Escolha: ");
        string tipo = Console.ReadLine();

        Console.Write("Digite o valor: ");
        double valor = double.Parse(Console.ReadLine());

        if (tipo == "1")
        {
            double resultado = valor * 0.621371;
            Console.WriteLine($"\n{valor} km = {resultado:F2} milhas");
        }
        else if (tipo == "2")
        {
            double resultado = valor / 0.621371;
            Console.WriteLine($"\n{valor} milhas = {resultado:F2} km");
        }
    }
    else if (opcao == "3")
    {
        Console.WriteLine("\n1. Kg para Libras");
        Console.WriteLine("2. Libras para Kg");
        Console.Write("Escolha: ");
        string tipo = Console.ReadLine();

        Console.Write("Digite o valor: ");
        double valor = double.Parse(Console.ReadLine());

        if (tipo == "1")
        {
            double resultado = valor * 2.20462;
            Console.WriteLine($"\n{valor} kg = {resultado:F2} libras");
        }
        else if (tipo == "2")
        {
            double resultado = valor / 2.20462;
            Console.WriteLine($"\n{valor} libras = {resultado:F2} kg");
        }
    }
    else if (opcao == "4")
    {
        Console.WriteLine("Encerrando...");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}