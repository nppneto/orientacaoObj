class TesteContaEAgencia
{
    static void Main(string[] args)
    {
        OrientacaoAObjetos.Agencia a = new OrientacaoAObjetos.Agencia("654321");
        OrientacaoAObjetos.Conta c = new OrientacaoAObjetos.Conta(a);

        c.Numero = "123";
        c.Saldo = 1000;
        c.Limite = 500;

        System.Console.WriteLine("Dados da agência");
        System.Console.WriteLine("Número: " + a.Numero);

        System.Console.WriteLine("-------------------------------------------------");

        System.Console.WriteLine("Dados da conta");
        System.Console.WriteLine("Número: " + c.Numero);
        System.Console.WriteLine("Saldo: " + c.Saldo);
        System.Console.WriteLine("Limite: " + c.Limite);

        System.Console.WriteLine("-------------------------------------------------");

        c.Agencia = a;

        System.Console.WriteLine("Dados da agência através da conta");
        System.Console.WriteLine("Número: " + c.Agencia.Numero);

        System.Console.ReadLine();
    }
}