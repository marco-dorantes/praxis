using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace House_Robber_II
{
  [TestClass]
  public class HouseRobber_II_Specification
  {
    [TestMethod, TestCategory("Robber")]
    public void Night_0a()
    {
      //Arrange
      int[] house = { };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(0, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night_0b()
    {
      //Arrange
      int[] house = { 10 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(10, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night_0c()
    {
      //Arrange
      int[] house = { 10, 15 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(15, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night_0d()
    {
      //Arrange
      int[] house = { 15, 10 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(15, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night1()
    {
      //Arrange
      int[] house = { 100, 700, 200, 500 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(1200, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night2()
    {
      //Arrange
      int[] house = { 100, 700, 500, 200 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(900, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night3()
    {
      //Arrange
      int[] house = { 300, 700, 500, 20 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(800, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night4()
    {
      //Arrange
      int[] house = { 0, 1, 2, 3, 4, 5, 6, 7 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(16, loot1);
    }

    [TestMethod, TestCategory("Robber"), ExpectedException(typeof(ArgumentNullException))]
    public void Night_1a()
    {
      //Arrange
      int[] house = null;

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.Fail("Exception expected.");
    }

    [TestMethod, TestCategory("Robber"), ExpectedException(typeof(ArgumentNullException))]
    public void Night_1b()
    {
      //Arrange
      int[] house = null;

      //Act
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);

      //Assert
      Assert.Fail("Exception expected.");
    }

    [TestMethod, TestCategory("Robber"), ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Night_2a()
    {
      //Arrange
      int[] house = { 2, 3, -1, 900 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.Fail("Exception expected.");
    }

    [TestMethod, TestCategory("Robber"), ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Night_2b()
    {
      //Arrange
      int[] house = { 2, 3, -1, 900 };

      //Act
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);

      //Assert
      Assert.Fail("Exception expected.");
    }

    [TestMethod, TestCategory("Robber")]
    public void Night5()
    {
      //Arrange
      int[] house = { 0, 1, 99, 3, 4, 99, 6, 7, 1000, 1000 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}:{loot1} | {nameof(loot2)}:{loot2}");
      Assert.AreEqual<int>(1205, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night6()
    {
      //Arrange
      int[] house = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(20, loot1);
    }

    [TestMethod, TestCategory("Robber")]
    public void Night7()
    {
      //Arrange
      int[] house = { 9, 0, 1, 2, 3, 4, 5, 6, 7 };

      //Act
      var loot1 = HouseRobber.HouseRobber_II.Algorithm1(house);
      var loot2 = HouseRobber.HouseRobber_II.Algorithm2(house);

      //Assert
      Assert.IsTrue(loot1 == loot2, $"{nameof(loot1)}={loot1} | {nameof(loot2)}={loot2}");
      Assert.AreEqual<int>(18, loot1);
    }
  }
}