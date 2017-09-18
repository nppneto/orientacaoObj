class TestaFuncionario
{
    static void Main(string[] args)
    {
        OrientacaoAObjetos.Funcionario f = new OrientacaoAObjetos.Funcionario();
        f.Nome = "Nelson";
        f.Salario = 1000;

        System.Console.WriteLine("Dados do funcionário: ");
        System.Console.WriteLine("Nome: " + f.Nome);
        System.Console.WriteLine("Salário: " + f.Salario);

        System.Console.WriteLine("-------------------------------------------------");

        System.Console.WriteLine("Chamando o método aumenta salário: ");
        f.AumentaSalario(1000);

        System.Console.WriteLine("------------------------------------------------");

        System.Console.WriteLine("Chamando o método de consulta: ");
        f.ConsultaFuncionario();

        System.Console.ReadLine();
    }
}