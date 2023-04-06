// Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine($"Digite um numero de 0 a 10: ");
int numero = int.Parse(Console.ReadLine());

while (numero < 0 || numero > 10)
{
    Console.WriteLine($"Numero invalido!");
    numero = int.Parse(Console.ReadLine());
}
