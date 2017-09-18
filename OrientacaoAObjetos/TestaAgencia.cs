class TestaAgencia
{
    static void Main(string[] args)
    {
        OrientacaoAObjetos.Agencia a1 = new OrientacaoAObjetos.Agencia("123456");
        OrientacaoAObjetos.Agencia a2 = new OrientacaoAObjetos.Agencia("789011");

        System.Console.WriteLine("Dados da primeira agência: ");
        System.Console.WriteLine("Número: " + a1.Numero);

        System.Console.WriteLine("-------------------------------------------------");

        System.Console.WriteLine("Dados da segunda agência: ");
        System.Console.WriteLine("Número: " + a2.Numero);

        System.Console.ReadLine();
    }
}