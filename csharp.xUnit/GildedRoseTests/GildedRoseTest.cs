using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void UpdateQuality_OfNormalItem_WithZeroQuality_Returns_NeverNegative()
    {
        var name = "foo";
        var quality = 0;

        IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = 0, Quality = quality } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();

        Assert.Equal(name, Items[0].Name);
        Assert.Equal(quality, Items[0].Quality);
    }

    [Fact]
    public void UpdateQuality_OfAgedBrie_Returns_AppropriateUpdate()
    {
        var name = "Aged Brie";
        var quality = 5;
        var sellIn = 5;
        var expectedQuality = 6;
        var expectedSellIn = 4;

        IList<Item> Items = new List<Item> { new Item { Name = name, Quality = quality, SellIn = sellIn } };
        GildedRose app = new GildedRose(Items);

        app.UpdateQuality();

        Assert.Equal(expectedQuality, Items[0].Quality);
        Assert.Equal(expectedSellIn, Items[0].SellIn);
    }

}