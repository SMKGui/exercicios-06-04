// // Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

// Algoritmo

// Saber o sexo do entrevistado
// Saber se a pessoa gostou do produto

// Saber o numero de pessoas que responderam sim
// Saber o numero de pessoas que responderam nao

// Saber o numero de mulheres que responderam
// Saber o numero de mulheres que responderam sim

// Saber o numero de homens que responderam
// Saber o numero de homens que responderam nao

// Saber a porcentagem de homens que responderam nao

// Declarar as variaveis

char sexo;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulher = 0;
int totalMulherSim = 0;

int totalHomem = 0;
int totalHomemNao = 0;

double porcentagemHomemNao = 0;

//var i = 0; --------- inicializador
//i < length; -------- condicional
//i++        --------- iterador

for (var i = 1; i <= 10; i++)
{
    //Entrada de dados
    Console.WriteLine(@$"
    Informe o sexo da pessoa:
    (m) - Masculino
    (f) - Feminino
    ");
    
    sexo = char.Parse(Console.ReadLine());

    //processamento
    if (sexo == 'f')
    {
        totalMulher++;
    }
    else
    {
        totalHomem++;
    }

    Console.WriteLine(@$"
    A pessoa gostou do lancamento?
    (s) - Sim
    (n) - Nao
    ");
    
    gostouDoProduto = char.Parse(Console.ReadLine().ToLower());

    if (gostouDoProduto == 's')
    {
        totalSim++;

        if (sexo == 'f')
        {
            totalMulherSim++;
        }
    }
    else
    {
        totalNao++;

        if (sexo == 'm')
        {
            totalHomemNao++;
        }
    }
}

porcentagemHomemNao = Math.Round(((double)totalHomemNao/(double)totalHomem)*100,2);

Console.WriteLine($"A porcentagem de homens que responderam que nao gostaram do produto e de: {porcentagemHomemNao}%");
