using ArrayFuncionario;

//Criar um vetor de 3 elementos
//Cadastrar / Digitar

//Calcule o total de salarios de todos os funcionários
//Pesquise se há algum funcionário com 100 de salário, informe se encontrou ou não

Funcionario[] funcionarios = new Funcionario[3];

for (int i = 0; i < funcionarios.Length; i++)
{
    funcionarios[i] = new Funcionario();
    Console.Write("Cadastre o código: ");
    funcionarios[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o nome: ");
    funcionarios[i].nome = Console.ReadLine();
    Console.Write("Cadastre o salario: ");
    funcionarios[i].salario = Convert.ToDouble(Console.ReadLine());
    
    System.Console.WriteLine("");
}
double somaSalario = 0;
bool achei = false;
foreach (Funcionario f in funcionarios)
{
    somaSalario += f.salario;
    if (f.salario == 100)
        achei = true;
if (achei)
{
    System.Console.WriteLine("Funcionário encontrado!");
    System.Console.WriteLine("");
    f.MostrarAtributos();
    System.Console.WriteLine("");
}
else
{
    System.Console.WriteLine("Funcionário não encontrado!");
}
}
System.Console.WriteLine($"O total de salários de todos os funcionários é: {somaSalario:c}");