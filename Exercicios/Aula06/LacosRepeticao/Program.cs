
namespace LacosRepeticao;

class Program
{

    /*------------------------------------------------------------/
    /                                                             /
    /   Aula 06 - C# Laços de Repetição  (For, While, Do While)   /
    /                                                             /
    /------------------------------------------------------------*/

    static void Main()
    {
        var Menu = new Program();
        Menu.Inicio();
    }

    void Inicio()
    {
        int Lista;
        string Retorno = string.Empty;

        Console.WriteLine("Escolha o número do exercício: 1-For | 2-While | 3-Do While:  ");

        Retorno = Console.ReadLine();
        TrataRetorno(Retorno);

        Lista = Convert.ToInt32(Retorno);

        if (Lista == 1) Lista01();       // Lista 01 — Laço de Repetição For: Camada Repeticao For
        else if (Lista == 2) Lista02();  // Lista 02 — Laço de Repetição While: Camada Repeticao While
        else Lista03();                  // Lista 03 — Laço de Repetição Do: Camada Repeticao Do
    }

    protected void TrataRetorno(string consoleRet)
    {
        consoleRet = "";

    }

    protected void Lista01()
    {
    }


    protected void Lista02()
    {

    }

    protected void Lista03()
    {
    }
}
