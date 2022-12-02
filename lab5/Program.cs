namespace lab5;


using lab5.Pages;

public static class Program
{
    public static void Main(string[] args)
    {

        var simplePage = new SimplePage(new JsonRenderer())
        {
            Title = "Simple page title",
            Content = "Simple page content"
        };

        simplePage.Render();

        simplePage.Renderer = new HtmlRenderer();
        simplePage.Render();


        var productPage = new ProductPage(new XmlRenderer())
        {
            Product = new Product
            {
                Id = ProdId.NewProdId(),
                Title = "Product title",
                Description = "Product description",
                Image = "Image link"
            }
        };

        productPage.Render();

        productPage.Renderer = new JsonRenderer();
        productPage.Render();
    }
}
