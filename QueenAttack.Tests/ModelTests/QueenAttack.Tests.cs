using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttackA;

namespace QueenAttackA.Tests
{
  [TestClass]
  public class QueenAttackClassTest
  {
    [TestMethod]
    public void queenAttack_Queen_coordinate_Vertical()
    {
        // QueenAttackClass testQueenAttack = new QueenAttackClass();
        Assert.AreEqual("attacking", QueenAttackClass.CheckAttacking(4,2,5,2));

    }
    [TestMethod]
    public void queenAttack_Queen_coordinate_Horizontal()
    {
        // QueenAttackClass testQueenAttack = new QueenAttackClass();
        Assert.AreEqual("attacking", QueenAttackClass.CheckAttacking(4,2,4,4));

    }
    [TestMethod]
    public void queenAttack_Queen_coordinate_diagonal()
    {
        // QueenAttackClass testQueenAttack = new QueenAttackClass();
        Assert.AreEqual("attacking", QueenAttackClass.CheckAttacking(4,2,3,3));

    }
    [TestMethod]
    public void queenNotAttack()
    {
        // QueenAttackClass testQueenAttack = new QueenAttackClass();
        Assert.AreEqual("not attacking", QueenAttackClass.CheckAttacking(4,2,5,4));

    }

  }
}
