using System.Globalization;

namespace ProductStock
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public double TotalValueInStock()
        {
            return Price * Amount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Amount: {Amount}, Total: R$ {TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void AddProducts(int add)
        {
            Amount += add;
        }

        public void RemoveProducts(int remove)
        {
            Amount -= remove;
        }
    }
}
