using ObserverPattern.Core;


//TicketStockService ticketStockService = new();
//TicketResellerService ticketResellerService = new();
//OrderService orderService = new();

//// add two observers
//orderService.AddObserver(ticketStockService);
//orderService.AddObserver(ticketResellerService);

//// notify
//orderService.CompleteTicketSale(1, 2);

//// remove one observer
//orderService.RemoveObserver(ticketResellerService);

//// notify
//orderService.CompleteTicketSale(2, 4);

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

// Customer 1 is interested in iPhone and will be notified
// Customer 2 is not interested in iPhone and won't be notified

// Add another product
store.AddProduct("Samsung Galaxy");

// Customer 2 is interested in Samsung Galaxy and will be notified

// Unsubscribe Customer 1
store.Unsubscribe(customer1);

// Add another product
store.AddProduct("Google Pixel");