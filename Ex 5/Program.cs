// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

// Algoritmo

// Receber idade
// Receber peso
// Receber sexo

// Calcular total de homens
// Calcular total de mulheres
// Tirar media da idade dos homens
// Tirar media da idade das mulheres

int idade = 0;
int idadeHomem = 0;
int idadeMulher = 0;
float peso = 0;
char sexo;
int totalHomem = 0;
int totalMulher = 0;

for (var i = 1; i <= 10; i++)
{
    Console.WriteLine(@$"
    Informe o sexo da pessoa:
    (m) - Masdculino
    (f) - Feminino");
    
    sexo = char.Parse(Console.ReadLine().ToLower());

    Console.WriteLine($"Informe o peso da pessoa: ");
    peso = float.Parse(Console.ReadLine());

    Console.WriteLine($"Informe a idade da pessoa: ");
    idade = int.Parse(Console.ReadLine());

    if (sexo == 'f')
    {
        totalMulher++;
        idadeMulher = idadeMulher + idade;
    }
    else
    {
        totalHomem++;
        idadeHomem = idadeHomem + idade;
    }
}

Console.WriteLine($"O total de mulheres: {totalMulher}");
Console.WriteLine($"O total de homens: {totalHomem}");

Console.WriteLine($"A media da idade dos homens: {idadeHomem / totalHomem}");
Console.WriteLine($"A media da idade das mulheres: {idadeMulher / totalMulher}");
