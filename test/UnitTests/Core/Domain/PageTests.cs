using Domain.Entities;
using Xunit;

namespace Domain;

public class PageTests
{
    [Fact]
    public void CreatePage_ValidateParameters_ShouldCreatePage()
    {
        //arrange
        var id = 1;
        var title = "Home title";
        var content = "Welcome to the page";
        var created = DateTime.UtcNow;
        var updated = DateTime.UtcNow;
        var parentPageId = 1;

        //act   
        var page = new Page
        {
            PageId = id,
            Title = title,
            Content = content,
            UpdatedAt = updated,
            ParentPageId = parentPageId
        };

        Assert.Equal(id, page.PageId);
        Assert.Equal(title, page.Title);
        Assert.Equal(content, page.Content);
        Assert.Equal(updated, page.UpdatedAt);
        Assert.Equal(parentPageId, page.ParentPageId);
    }
    [Fact]
    public void SetTitle_ValidateParameters_ShouldSetTitle()
    {
        //Arrange
        var page = new Page
        {
            PageId = 1,
            Title = "Home title",
            Content = "Welcome to the page",
            ParentPageId = 1
        };

        // Act
        page.Title = "New title";

        // Then
        Assert.Equal("New title", page.Title);
    }
}
