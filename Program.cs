using System;
using System.Threading;
using System.Threading.Tasks;

namespace FirstProgram
{
  class Program
  {
    static bool exit = false;
    static void Main(string[] args)
    {
      Task t = Task.Run(() =>
      {
        ImprimeSegundo(1000, 10);
      });



      //   Parallel.For(0,10, (s,e) => {
      //       ImprimeSegundo(1000, (int)s);
      //   });
      //   int i = 0;
      //   for (i = 0; i < 500; i++)
      //   {
      //     Console.WriteLine(i);
      //   }
      //   Thread t = new Thread(new ParameterizedThreadStart(ImprimeSegundo));
      //   t.Start(3000);
      //   Console.ReadLine(); // ler
      //   exit = true;
      //   Console.ReadLine();

    }

    public Task ImprimeSegundoAsync()
    {
      return Task.Run(() =>
      {
        ImprimeSegundo(1000, 10);
      });
    }

    public async void GerenciadorTask()
    {
      await ImprimeSegundoAsync();
    }

    public static void ImprimeSegundo(object value, int t)
    {
      int i = 0;
      while (!exit)
      {
        Console.WriteLine("Thread " + t + " Valor " + i++);
        Thread.Sleep((int)value);

        // Console.WriteLine(i++);
        // Thread.Sleep((int)value);
      }
    }
  }
}
