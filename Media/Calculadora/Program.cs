/*Esse sistema calcula a media ponderada com suas notas pesando:
 * nota 1 com peso de 2
 * nota 2 com peso de 2
 * nota 3 com peso de 3
 * nota 4 com peso de 3
 */


double nota1, nota2, nota3, nota4, result;


    //Inserindo as notas nas variaveis
Console.WriteLine("Insira a primeira nota");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a terceira nota");
nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a quarta nota");
nota4 = double.Parse(Console.ReadLine());
  
result = ((nota1 * 2) + (nota2 * 2) + (nota3 * 3) + (nota4 * 3)) / 10;

if (result <= 5)
{
    Console.WriteLine("A media final do aluno e: " + result + ", Aluno reprovado");
}
else if (result <= 7)
{
    Console.WriteLine("A media final do aluno e: " + result + ", Aluno tem que refazer o exame");
}
else
{
    Console.WriteLine("A media final do aluno e: " + result + ", Aluno Aprovado");
}