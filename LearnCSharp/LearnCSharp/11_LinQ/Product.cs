namespace LearnCSharp._11_LinQ
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public int Brand { get; set; }

        public Product(int id, string name, double price, string[] colors, int brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }

        override public string ToString()
        {
            return $"{Id,3}  {Name,12} {Price,5} {string.Join(", ", Colors)} {Brand,2}";
        }
    }
}