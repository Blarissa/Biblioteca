using Biblioteca.Controller;
using Biblioteca.Data;
using Biblioteca.View;

internal class Program
{
    private static void Main()
    {       
        var opt = 1;
        while (opt != 0)
        {
            Menu.MenuPrincipal(ref opt);
        }
    }
}