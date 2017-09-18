class TestaMetodosConta
{
    static void Main(string[] args)
    {
        OrientacaoAObjetos.Agencia a = new OrientacaoAObjetos.Agencia("123");
        OrientacaoAObjetos.Conta c = new OrientacaoAObjetos.Conta(a);

        System.Console.WriteLine("Chamando o método deposita passando o valor 1000: ");
        c.Deposita(1000);
        c.ImprimeExtrato();

        System.Console.WriteLine("---------------------------------------------------------");

        System.Console.WriteLine("Chamando o método saca passando o valor 100");
        c.Saca(100);
        c.ImprimeExtrato();

        System.Console.WriteLine("---------------------------------------------------------");

        double saldoDisponivel = c.ConsultaSaldoDisponivel();

        System.Console.WriteLine("SALDO DISPONÍVEL: " + saldoDisponivel);

        System.Console.ReadLine();
    }
}