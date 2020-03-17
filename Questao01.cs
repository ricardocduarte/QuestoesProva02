using System.Collections.Generic;
using static System.Console;
using static System.Int32;

namespace Algoritmos
{
  public class Program
  {
    static void Main(string[] args)
    {
      Target();
    }

    static void Target()
    {
      var listaTemp = new List<int>();
      var resultado = new List<int>();

      Write("Target: ");
      var target = Parse(ReadLine());

      var nums = new List<int>();
      WriteLine("Digite o tamanho do array: ");
      var total = Parse(ReadLine());

      WriteLine("Digite os números: ");
      for (var i = 0; i < total; i++)
      {
        var numero = Parse(ReadLine());
        listaTemp.Add(numero);
      }
      listaTemp.Sort();

      for (int i = 0; i < listaTemp.Count; i++)
      {
        if (listaTemp[i] + listaTemp[i + 1] == target)
        {
          resultado.Add(i);
          resultado.Add(i + 1);
          Write($"[{i},{i + 1}]");
          break;
        }
      }
    }
  }
}
