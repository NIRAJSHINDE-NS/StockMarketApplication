namespace StockHoldingProgram
{
    class Stock
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Stock(string symbol, string name, decimal price, int quantity)
        {
            Symbol = symbol;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Symbol: {Symbol}\nName: {Name}\nPrice: {Price:C}\nQuantity: {Quantity}\n";
        }
    }
    }
