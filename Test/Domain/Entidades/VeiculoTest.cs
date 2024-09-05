using MinimalApi.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Id = 1;
            veiculo.Nome = "Fusca";
            veiculo.Marca = "Volkswagen";
            veiculo.Ano = 1985;

            // Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Fusca", veiculo.Nome);
            Assert.AreEqual("Volkswagen", veiculo.Marca);
            Assert.AreEqual(1985, veiculo.Ano);
        }
    }
}