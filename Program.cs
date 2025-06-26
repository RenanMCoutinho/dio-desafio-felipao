using System;
class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Digite o nome do Herói: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a quantidade de XP: ");
        int xp = int.Parse(Console.ReadLine());

        // Lógica de decisão
        string nivel;

        switch (xp)
        {
            case < 1000:
                nivel = "Ferro";
                break;
            case <= 2000:
                nivel = "Bronze";
                break;
            case <= 5000:
                nivel = "Prata";
                break;
            case <= 7000:
                nivel = "Ouro";
                break;
            case <= 8000:
                nivel = "Platina";
                break;
            case <= 9000:
                nivel = "Ascendente";
                break;
            case <= 10000:
                nivel = "Imortal";
                break;
            default:
                nivel = "Radiante";
                break;
        }
        // Saída
        Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");
    }
}
