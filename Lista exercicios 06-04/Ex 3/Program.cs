// Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Digite um numero para o calculo de sua tabuada de 1 a 10: ");
int x = int.Parse(Console.ReadLine());
int resultado = 0;

for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
{
    resultado = multiplicador * x;
    Console.WriteLine($"{x} x {multiplicador} = {resultado}");
}