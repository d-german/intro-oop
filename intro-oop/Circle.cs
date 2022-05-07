namespace intro_oop
{
    public class Circle
    {
        private double _radius = 0;
        public Location Location { get; set; } = new();

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}