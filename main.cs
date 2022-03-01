using System;
class Program {
  public static void Main (string[] args) {
  double N1, N2, N3;
           Console.Write("Introduzca el Valor Numerico 1: ");
           N1 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico 2: ");
           N2 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico 3: ");
           N3 = Convert.ToDouble(Console.ReadLine());
    if(N1<N2){
      if(N2<N3){
         Console.WriteLine("El Numero Mayor es: "+N3);
      }else{
       Console.WriteLine("El Numero Mayor es: "+N2);
      }
      
    }else{
    Console.WriteLine("El Numero Mayor es: "+N1);
    }
  }
}