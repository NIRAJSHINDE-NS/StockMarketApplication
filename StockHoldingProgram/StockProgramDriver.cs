namespace StockHoldingProgram
{

    class StockProgramDriver
    {
        private static List<Stock> portfolio = new List<Stock>();
        private static List<Transaction> transactions = new List<Transaction>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Add Stock");
                Console.WriteLine("2. Show Transactions");
                Console.WriteLine("3. View Portfolio");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStock();
                        break;
                    case "2":
                        ShowTransactions();
                        break;
                    case "3":
                        ViewPortfolio();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        
        static void AddStock()
        {
            Console.WriteLine("Enter stock information:");
            Console.Write("Symbol: ");
            string symbol = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Stock stock = new Stock(symbol, name, price, quantity);
            portfolio.Add(stock);

            Transaction transaction = new Transaction(DateTime.Now, $"Added stock: {stock.Symbol} - Quantity: {stock.Quantity}");
            transactions.Add(transaction);

            Console.WriteLine("Stock added successfully!");
        }

        static void ShowTransactions()
        {
            Console.WriteLine("Transaction History:");
            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }

        static void ViewPortfolio()
        {
            if (portfolio.Count > 0)
            {
                Console.WriteLine("Portfolio:");
                foreach (Stock stock in portfolio)
                {
                    Console.WriteLine(stock.ToString());
                }
            }
            else
            {
                Console.WriteLine("Portfolio is empty.");
            }
        }
    }
   }

