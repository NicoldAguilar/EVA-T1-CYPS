namespace CalidadT1;

public class BookStore
{
    private List<Book> shoppingCart;

    public BookStore()
    {
        shoppingCart = new List<Book>();
    }

    public void AddToCart(Book book)
    {
        shoppingCart.Add(book);
    }
    
    public decimal GetTotal()
    {
        return shoppingCart.Sum(x => x.Price);
    }
}