class TestaGerente
{
    static void Main(string[] args)
    {
        OrientacaoAObjetos.Gerente g = new OrientacaoAObjetos.Gerente();
        g.Salario = 1000;

        System.Console.WriteLine("Salário: " + g.Salario);

        System.Console.WriteLine("-------------------------------------------------");

        System.Console.WriteLine("Aumentando o salário em 10%: ");
        g.AumentaSalario();

        System.Console.WriteLine("Salário atualizado: " + g.Salario);

        System.Console.WriteLine("-------------------------------------------------");

        System.Console.WriteLine("Aumentando o salário em 30%: ");
        g.AumentaSalario(0.3);

        System.Console.WriteLine("Salário atualizado: " + g.Salario);

        System.Console.ReadLine();
    }
}