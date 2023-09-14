using Biblioteca.Controller;
using Biblioteca.Data;
using Biblioteca.View;

internal class Program
{
    private static void Main()
    {
        var contexto = new BibliotecaContexto();
        var input = new Input();
        var validacao = new Validacao();

        var menu = new Menu(contexto, input, validacao);

        var opt = 1;
        while (opt != 0)
        {
            opt = menu.MenuPrincipal();
        }
    }
}