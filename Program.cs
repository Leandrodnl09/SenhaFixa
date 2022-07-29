// Exercício site URI "Senha Fixa"
// Esse programa iremos digitar uma senha de 4 numeros, caso ela seja invalida mostar "senha invalida" saso seja a senha correta mostrar "Acesso Permitido"

int Senha = int.Parse(Console.ReadLine());

Senha = 0;

while(Senha != 2002)
{
    Console.WriteLine("Senha invalida");
    Senha = int.Parse(Console.ReadLine());
}
if (Senha == 2002)
{
    Console.WriteLine("Acesso Permitido");
}
