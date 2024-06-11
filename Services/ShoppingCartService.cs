// using Blazored.LocalStorage;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// public class ShoppingCartService : IShoppingCartService
// {
//     // Dependency on the local storage service to manage cart persistence.
//     private readonly ILocalStorageService _localStorageService;

//     // Key for saving/retrieving the cart from local storage.
//     private const string CartStorageKey = "shoppingCart";

//     // In-memory storage for the current state of the shopping cart.
//     private List<CartItem> _cartItems;

//     // Event to notify subscribers when the cart changes.
//     public event Action OnCartChanged;

//     // Constructor: initializes the service with an empty cart and local storage dependency.
//     public ShoppingCartService(ILocalStorageService localStorageService)
//     {
//         _localStorageService = localStorageService;
//         _cartItems = new List<CartItem>();
//         LoadSeedData(); // Call the method to load seed data
//     }

//     private void LoadSeedData()
//     {
//         // Seed data
//         var products = new List<Product>
//         {
//             new Product { Id = 1, Name = "Item 1", Price = 10M },
//             new Product { Id = 2, Name = "Item 2", Price = 15M },
//             // Add more products as needed
//         };

//         foreach (var product in products)
//         {
//             _cartItems.Add(new CartItem { Product = product, Quantity = 1 });
//         }

//         OnCartChanged?.Invoke();
//     }

//     // Adds an item to the cart or updates the quantity if it already exists.
//     public void AddItemToCart(Product product, int quantity)
//     {
//         var existingItem = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
//         if (existingItem != null)
//         {
//             existingItem.Quantity += quantity;
//         }
//         else
//         {
//             _cartItems.Add(new CartItem { Product = product, Quantity = quantity });
//         }
//         OnCartChanged?.Invoke(); // Notify subscribers of changes.
//     }

//     // Removes an item from the cart based on the product.
//     public void RemoveItemFromCart(Product product)
//     {
//         _cartItems.RemoveAll(item => item.Product.Id == product.Id);
//         OnCartChanged?.Invoke(); // Notify subscribers of changes.
//     }

//     // Updates the quantity of a specific item in the cart.
//     public void UpdateItemQuantity(Product product, int quantity)
//     {
//         var existingItem = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
//         if (existingItem != null)
//         {
//             existingItem.Quantity = quantity;
//         }
//         OnCartChanged?.Invoke(); // Notify subscribers of changes.
//     }

//     // Clears all items from the cart.
//     public void ClearCart()
//     {
//         _cartItems.Clear();
//         OnCartChanged?.Invoke(); // Notify subscribers of changes.
//     }

//     // Gets all items in the cart.
//     public IEnumerable<CartItem> GetCartItems()
//     {
//         return _cartItems;
//     }

//     // Gets the total price of items in the cart.
//     public decimal GetTotalPrice()
//     {
//         return _cartItems.Sum(item => item.Product.Price * item.Quantity);
//     }

//     // Asynchronously loads the cart from local storage.
//     public async Task LoadCartAsync()
//     {
//         _cartItems = await _localStorageService.GetItemAsync<List<CartItem>>(CartStorageKey) ?? new List<CartItem>();
//         OnCartChanged?.Invoke(); // Notify subscribers of changes.
//     }

//     // Asynchronously saves the cart to local storage.
//     public async Task SaveCartAsync()
//     {
//         await _localStorageService.SetItemAsync(CartStorageKey, _cartItems);
//     }
// }
