using Domain.Entities;
using Xunit;

namespace Domain;

public class ElementTests
{
    [Fact]
    public void Create_validateparamenters_shouldcreateelement()
    {
        var ElementId = Guid.NewGuid();
        var Type = "Text";
        var Properties = "Text";
        var PageId = 1;
        var UpdatedAt = DateTime.UtcNow;

        var element = new Element
        {
            ElementId = ElementId,
            Type = Type,
            Properties = Properties,
            PageId = PageId,
            UpdatedAt = UpdatedAt
        };
        Assert.Equal(ElementId, element.ElementId);
        Assert.Equal(Type, element.Type);
        Assert.Equal(Properties, element.Properties);
        Assert.Equal(PageId, element.PageId);
        Assert.Equal(UpdatedAt, element.UpdatedAt);

    }
}

