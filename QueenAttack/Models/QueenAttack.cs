using System;
using System.Linq;
using System.Collections.Generic;


namespace QueenAttackA
{
  public static class QueenAttackClass
  {
    public static string CheckAttacking(int qx, int qy, int ox, int oy)
    {
      if(qx==ox || qy==oy){
        return "attacking";
      }else if(Math.Abs(qx-ox)==Math.Abs(qy-oy)){
        return "attacking";
      }else{
        return "not attacking";
      }
    }

    public static void Main()
    {
      Console.WriteLine("Please enter Queen X coordinate: ");
      string userInputQX = Console.ReadLine();
      int qx = int.Parse(userInputQX);
      Console.WriteLine("Please enter Queen Y coordinate: ");
      string userInputQY = Console.ReadLine();
      int qy = int.Parse(userInputQY);
      Console.WriteLine("Please enter Other Chess Piece X coordinate: ");
      string userInputOX = Console.ReadLine();
      int ox = int.Parse(userInputOX);
      Console.WriteLine("Please enter Other Chess Piece Y coordinate: ");
      string userInputOY = Console.ReadLine();
      int oy = int.Parse(userInputOY);
      Console.WriteLine(CheckAttacking(qx,qy,ox,oy));
    }
  }
}
