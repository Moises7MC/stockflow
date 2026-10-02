using StockFlow.Domain.Entities;

namespace StockFlow.Application.Tests.Domain;

public class ProductTests
{
    [Theory]
    [InlineData(5, 10, true)]   // stock por debajo del mínimo
    [InlineData(10, 10, true)]  // stock igual al mínimo
    [InlineData(11, 10, false)] // stock por encima del mínimo
    public void IsLowStock_ComparaStockConMinimo(int stock, int minStock, bool esperado)
    {
        var product = new Product { Name = "Martillo", Sku = "FER-004", Stock = stock, MinStock = minStock };

        Assert.Equal(esperado, product.IsLowStock);
    }
}