namespace Interfaces1
{
    class Car : IComparable<Car>, IComparer<Car>
    {
        public string Make {  get; set; }
        public string Model {  get; set; }
        public double Price {  get; set; }

        public Car(string make, string model, double price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        public int CompareTo(Car? other)
        {
            return Compare(this, other);
        }

        public int Compare(Car? x, Car? y)
        {
            if(x == null || y == null)
            {
                return 0;
            }
            if (x.Make.CompareTo(y.Make) == 0)
            {
                if(x.Model.CompareTo(y.Model) == 0)
                {
                    return x.Price.CompareTo(y.Price);
                }
                else
                {
                    return x.Model.CompareTo(y.Model);
                }
            }
            else
            {
                return x.Make.CompareTo(y.Make);
            }

        }

        private int CompareMake(string x, string y)
        {
            return x.CompareTo(y);
        }

        private int CompareModel(Car x, Car y)
        {
            return x.CompareTo(y);
        }

        private int ComparePrice(double x, double y)
        {
            return x.CompareTo(y);
        }
    }
}