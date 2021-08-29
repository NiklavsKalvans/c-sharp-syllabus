using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hierarchy;

namespace Polymorphism.Tests
{
    [TestClass]
    public class PolymorphismTests
    {
        Meat meat = new Meat(1);
        Vegetable vegetable = new Vegetable(1);

        [TestMethod]
        public void EatFood_CatEatsMeat_FoodEatenIncreased()
        {
            //Arrange
            Cat cat = new Cat("Cat", "Gray", 1.1, "Home", "Persian");
            var expected = 1;

            //Act
            cat.EatFood(meat);
            var result = cat._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_CatEatsVegetable_FoodEatenIncreased()
        {
            //Arrange
            Cat cat = new Cat("Cat", "Gray", 1.1, "Home", "Persian");
            var expected = 1;

            //Act
            cat.EatFood(vegetable);
            var result = cat._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_TigerEatsMeat_FoodEatenIncreased()
        {
            //Arrange
            Tiger tiger = new Tiger("Tiger", "Typcho", 167.7, "Asia");
            var expected = 1;

            //Act
            tiger.EatFood(meat);
            var result = tiger._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_TigerEatsVegetable_FoodEatenStaysAt0()
        {
            //Arrange
            Tiger tiger = new Tiger("Tiger", "Typcho", 167.7, "Asia");
            var expected = 0;

            //Act
            tiger.EatFood(vegetable);
            var result = tiger._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_ZebraEatsMeat_FoodEatenStaysAt0()
        {
            //Arrange
            Zebra zebra = new Zebra("Zebra", "Lenny", 152.7, "Madagascar");
            var expected = 0;

            //Act
            zebra.EatFood(meat);
            var result = zebra._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_ZebraEatsVegetable_FoodEatenIncreased()
        {
            //Arrange
            Zebra zebra = new Zebra("Zebra", "Lenny", 152.7, "Madagascar");
            var expected = 1;

            //Act
            zebra.EatFood(vegetable);
            var result = zebra._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_MouseEatsVegetable_FoodEatenIncreased()
        {
            //Arrange
            Mouse mouse = new Mouse("Mouse", "Pika", 1.2, "Cage");
            var expected = 1;

            //Act
            mouse.EatFood(vegetable);
            var result = mouse._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_MouseEatsMeat_FoodEatenStaysAt0()
        {
            //Arrange
            Mouse mouse = new Mouse("Mouse", "Pika", 1.2, "Cage");
            var expected = 0;

            //Act
            mouse.EatFood(meat);
            var result = mouse._foodEaten;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MakeSound_CatMakesSound_Meow()
        {
            //Arrange
            Cat cat = new Cat("Cat", "Gray", 1.1, "Home", "Persian");
            var expected = "Meow!";

            //Act
            var result = cat.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MakeSound_TigerMakesSound_Rawrrr()
        {
            //Arrange
            Tiger tiger = new Tiger("Tiger", "Typcho", 167.7, "Asia");
            var expected = "Rawrrr!";

            //Act
            var result = tiger.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MakeSound_ZebraMakesSound_Uuuhh()
        {
            //Arrange
            Zebra zebra = new Zebra("Zebra", "Lenny", 152.7, "Madagascar");
            var expected = "Uuu-h-h!";

            //Act
            var result = zebra.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MakeSound_MouseMakesSound_skrpskrp()
        {
            //Arrange
            Mouse mouse = new Mouse("Mouse", "Pika", 1.2, "Cage");
            var expected = "skrp-skrp!";

            //Act
            var result = mouse.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
