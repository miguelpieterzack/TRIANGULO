// Verificação e classificação de triângulos
// Criação e inicialização das variáveis
double ladoA, ladoB, ladoC = 0;

// Solicitação de dados do usuário
System.Console.WriteLine("*** Classificação de triângulos ***"); ;
System.Console.Write("Informe o lado A do triângulo: ");
ladoA = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Informe o lado B do triângulo: ");
ladoB = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Informe o lado C do triângulo: ");
ladoC = Convert.ToDouble(Console.ReadLine());

// Condição de existência de triângulo
// A soma de dois lados quaisquer deve ser sempre maior que o terceiro lado
//System.Console.WriteLine($"Os lados do triângulo são {ladoA}, {ladoB} e {ladoC}");
if (ladoA < ladoB + ladoC & ladoB < ladoA + ladoC & ladoC < ladoA + ladoB)
{
    if (ladoA == ladoB & ladoB == ladoC)
    {
        System.Console.WriteLine("Triangulo Equilátero!!!");
    } else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
            {
                System.Console.WriteLine("Triângulo Isósceles!!!");
            } else
    {
        System.Console.WriteLine("Triângulo Escaleno!!!");
    }
}
else
{
    System.Console.WriteLine("Não é triângulo!!");
}