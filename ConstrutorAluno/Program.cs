using ConstrutorAluno;

internal class Program
{
    private static void Main(string[] args) //static não é necessário instanciar;
    {
        // Criar a Classe Aluno, com os atributos 
        // matricula, nome.
        /* Utilize o atributo static para criar as matriculas de forma automática a cada instância seguindo o padrão Fatec 1570482313000
        O atributo matricula não será static, utilizar uma variavel a parte para auxiliar a contagem, pois cada aluno da fatec tem sua matricula prórpria.

        Criar o método Mostrar e chamar após cada instância.

        Instancie pelo menos 2 objetos de construtores diferentes

        Entregar pelo Teams o arquivo Aluno.cs e Program.cs
        Até dia 19/09
        */

        Aluno aluno1 = new Aluno("João");
        aluno1.Mostrar();

        Aluno aluno2 = new Aluno("Maria");
        aluno2.Mostrar();
        Aluno aluno3 = new Aluno("Maria");
        aluno3.Mostrar();
    }
}