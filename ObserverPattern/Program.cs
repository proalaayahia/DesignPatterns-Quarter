using ObserverPattern.Core;


// Create the store
Store store = new Store();

// Create customers who are interested in different products
Customer customer1 = new Customer("Alice", "iPhone");
Customer customer2 = new Customer("Bob", "Samsung Galaxy");

// Customers subscribe to the store notifications
store.Subscribe(customer1);
store.Subscribe(customer2);

// Add a product to the store
store.AddProduct("iPhone");


store.AddProduct("Samsung Galaxy");

// Unsubscribe Customer 1
store.Unsubscribe(customer1);

// Add another product
store.AddProduct("Google Pixel");