
public void Questao03(int[] itens, bool deveComprar, int lucroEsperado)
{
    int lucro;
    bool compra;

    itens = CompraAcao(itens, out lucro, out compra);
    if(compra)
	   Console.WriteLine("Comprar em "  + itens[0] + " -- " + itens[1]);

    
}


public static int[] CompraAcao(int[] itens, out int lucro, out bool compra)
{
    do
    {
        if (Array.IndexOf(itens, itens.Max()) < Array.IndexOf(itens, itens.Min()))
        {
            int numIndex = Array.IndexOf(itens, itens.Max());
            itens = itens.Where((val, idx) => idx != numIndex).ToArray();
        }
    } while (Array.IndexOf(itens, itens.Max()) < Array.IndexOf(itens, itens.Min()));


    lucro = 0;
    compra = false;
    if (Array.IndexOf(itens, itens.Max()) > Array.IndexOf(itens, itens.Min()))
    {
        compra = true;
        lucro = itens.Max() - itens.Min();
    }

    return itens;
}
