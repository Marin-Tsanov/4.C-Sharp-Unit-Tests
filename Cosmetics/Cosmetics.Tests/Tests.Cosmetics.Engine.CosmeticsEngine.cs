using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Moq;


using Cosmetics.Contracts;
using Cosmetics.Engine;
using Cosmetics.Products;
using Cosmetics.Tests.Engine.Mocks;


namespace Cosmetics.Tests
{
	[TestFixture]
   public class Tests2
    {
		[Test]
		public void Start_WhenInputStringIsValidCreateCategoryCommand_CategoryShouldBeAddedToList()
        {
            // Arrange
            var categoryName = "ForMale"; 

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedconsoleCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            var mockedCategory = new Mock<ICategory>();


            mockedCommand.SetupGet(x => x.Name).Returns("CreateCategory");
            mockedCommand.SetupGet(y => y.Parameters).Returns(new List<string> { categoryName });
            mockedconsoleCommandParser.Setup(p => p.ReadCommands()).Returns(new List<ICommand> { mockedCommand.Object });

            mockedCategory.Setup(x => x.Name).Returns(categoryName);
            mockedFactory.Setup(z => z.CreateCategory(categoryName)).Returns(mockedCategory.Object);

            var mockedCosmeticsEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedconsoleCommandParser.Object);
			
			// Act
            mockedCosmeticsEngine.Start();

            // Assert
            Assert.IsTrue(mockedCosmeticsEngine.Categories.ContainsKey(categoryName));
            Assert.AreSame(mockedCategory.Object, mockedCosmeticsEngine.Categories[categoryName]);
        }

		[Test]
		public void Start_WhenInputStringIsValidAddToCategoryCommand_ProductShouldBeAddedToCategory()
        {
			// Arrange

            var categoryName = "ForMale";
			var productName = "White+";

            var mockedCategory = new Mock<ICategory>();
            var mockedShampoo = new Mock<IShampoo>();

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand_0 = new Mock<ICommand>();
            var mockedCommand_1 = new Mock<ICommand>();

            mockedCommand_0.SetupGet(x => x.Name).Returns("CreateCategory");
            mockedCommand_0.SetupGet(y => y.Parameters).Returns(new List<string>() { categoryName });
            mockedCommand_1.SetupGet(a => a.Name).Returns("AddToCategory");
            mockedCommand_1.SetupGet(b => b.Parameters).Returns(new List<string>() { categoryName, productName });

            mockedCommandParser.Setup(z => z.ReadCommands()).Returns(new List<ICommand>() { mockedCommand_0.Object, mockedCommand_1.Object });

            mockedCategory.Setup(c => c.Name).Returns(categoryName);
            mockedFactory.Setup(d => d.CreateCategory(categoryName)).Returns(mockedCategory.Object);
			
            var engine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
			
            engine.Categories.Add(categoryName, mockedCategory.Object);
            engine.Products.Add(productName, mockedShampoo.Object);

            // Act

            engine.Start();

            // Assert

            mockedCategory.Verify(x => x.AddProduct(mockedShampoo.Object), Times.Once);

        }
    }
}
