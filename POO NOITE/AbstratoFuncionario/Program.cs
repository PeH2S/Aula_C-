using AbstratoFuncionario;

class Program
{
    public static void Main(string[] args)
    {
        Dependente dep1 = new Dependente(1, "João", 12);
        Dependente dep2 = new Dependente(2, "Ana", 17);

        Assalariado assalariado = new Assalariado(1, "Carlos", 3000);
        Comissionado comissionado = new Comissionado(2, "Lucia", 2500, 0.1);

        assalariado.AdicionarDependente(dep1);
        comissionado.AdicionarDependente(dep2);

        Departamento deptTI = new Departamento(101, "Tecnologia da Informação");
        Departamento deptRH = new Departamento(102, "Recursos Humanos");

        deptTI.Admitir(assalariado);
        deptRH.Admitir(comissionado);

        Console.WriteLine("\nDepartamento de TI:");
        deptTI.Listar();

        Console.WriteLine("\nDepartamento de RH:");
        deptRH.Listar();
    }
}