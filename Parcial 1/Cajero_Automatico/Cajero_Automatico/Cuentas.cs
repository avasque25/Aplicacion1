class Cuenta
{
    private double saldo;

    public Cuenta(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public double VerSaldo()
    {
        return saldo;
    }

    public void Depositar(double cantidad)
    {
        saldo += cantidad;
        Console.WriteLine("Depósito realizado.");
    }

    public void Retirar(double cantidad)
    {
        if (cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine("Retiro realizado.");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes.");
        }
    }
}