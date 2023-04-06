// Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

Console.WriteLine($"Digite seu nome de usuario: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua senha: ");
string senha = Console.ReadLine();

while (nome == senha)
{
    Console.WriteLine($"Invalido! Digite um nome de usuario diferente da senha.");
    nome = Console.ReadLine();
    Console.WriteLine($"Redigite a senha: ");
    senha = Console.ReadLine();
}
