int x, y;
double divisao;
int multi;
int soma;
int sub;

Console.WriteLine("Digite o primeiro valor:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
y = Convert.ToInt32(Console.ReadLine());

divisao = (double)x / y;
Console.WriteLine($"O valor da divisão entre {x} e {y} é igual a {divisao}");

multi = x * y;
Console.WriteLine($"O valor da multiplicação entre {x} e {y} é igual a {multi}");

soma = x + y;
Console.WriteLine($"O valor da soma entre {x} e {y} é igual a {soma}");

sub = x - y;
Console.WriteLine($"O valor da subtração entre {x} e {y} é igual a {sub}");