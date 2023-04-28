const string AGUAS_MARINHAS ="M";
const string AGUAS_CONTINENTAIS ="C";

const double LimiteAguasContinentaisEmKg = 10;
const double LimiteAguasMarinhasKg = 15;

const decimal MultaExessoPeso = 1000;
const decimal MUltaPorKGExcedido = 20;

Double PesoDoPescadoEmKg;
String LocalPesca;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("*** PESCA AMADORA ***");
Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Peso (em KG): ");
Console.ResetColor();

PesoDoPescadoEmKg = Convert.ToDouble(Console.ReadLine()!);

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Aguas [C]ontinentais ou [M]arinhas? ");
Console.ResetColor();
LocalPesca = Console.ReadLine()!
                .Trim()
                .Substring(0,1)
                .ToUpper();

if (LocalPesca != AGUAS_CONTINENTAIS
&& LocalPesca != AGUAS_MARINHAS)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Local Não Reconhecido.");
    Console.ResetColor();
    return;
}

if ((LocalPesca == AGUAS_MARINHAS 
&& PesoDoPescadoEmKg <= LimiteAguasContinentaisEmKg)
||
(LocalPesca == AGUAS_MARINHAS
&& PesoDoPescadoEmKg <= LimiteAguasContinentaisEmKg))
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Pescaria Dentro dos Limites Legais.");
    Console.ResetColor();
    return;
}

double PesoPermitido;
if (LocalPesca ==AGUAS_CONTINENTAIS)
{
    PesoPermitido = LimiteAguasContinentaisEmKg;
}
else
{
    PesoPermitido = LimiteAguasMarinhasKg;
}

double PesoEmExcesso = PesoDoPescadoEmKg - PesoPermitido;
decimal Multa = MultaExessoPeso + MUltaPorKGExcedido * Convert.ToDecimal(PesoEmExcesso);

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine($"Pescaria excede os limites legais em {PesoEmExcesso}Kg.");
Console.WriteLine($"Sujeito a multa de {Multa:C2}.");

Console.ResetColor();
