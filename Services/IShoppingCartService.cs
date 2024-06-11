public interface IShoppingCartService
{
    // Event to notify when the cart has changed.
    event Action OnCartChanged;

    // Method to add an item to the cart.
    void AddItemToCart(Product product, int quantity);

    // Method to remove an item from the cart.
    void RemoveItemFromCart(Product product);

    // Method to update the quantity of a specific item in the cart.
    void UpdateItemQuantity(Product product, int quantity);

    // Method to clear all items from the cart.
    void ClearCart();
    

    // Method to get all items in the cart.
    IEnumerable<CartItem> GetCartItems();

    // Method to get the total price of items in the cart.
    decimal GetTotalPrice();

    // Method to load the cart from local storage.
    Task LoadCartAsync();

    // Method to save the cart to local storage.
    Task SaveCartAsync();
}



