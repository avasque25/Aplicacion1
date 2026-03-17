//Cajero automatico basico que permita al usuario las siguientes opciones:
// 1.verificar saldo disponible en la cuenta
// 2. depositar dinero en la cuenta
// 3. retirar dinero de la cuenta
// 4. salir del programa
// debe utilizar conceptos de programación orientada a objetos definiendo clases y metodos


class Program
{
    static void Main(string[] args)
    {
        Cuenta cuenta = new Cuenta(1000);
        CajeroAutomatico cajero = new CajeroAutomatico(cuenta);

        cajero.Inicio();
    }
}
