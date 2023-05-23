namespace StockHoldingProgram
{
    class Transaction
    {
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public Transaction(DateTime dateTime, string description)
        {
            DateTime = dateTime;
            Description = description;
        }

        public override string ToString()
        {
            return $"{DateTime} - {Description}";
        }
    }
    }
