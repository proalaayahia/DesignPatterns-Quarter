using ObserverPattern.Core;

Store store = new Store();

Customer customer1 = new Customer("Alice", "iPhone");
Customer customer2 = new Customer("Bob", "Samsung Galaxy");


store.Subscribe(customer1);
store.Subscribe(customer2);

store.AddProduct("iPhone");

store.AddProduct("Samsung Galaxy");

store.Unsubscribe(customer1);

store.AddProduct("Google Pixel");