using Assignment_Session_5_OOP.Interfaces;

namespace Assignment_Session_5_OOP.Classes
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius; 
            }
        }

        public void DisplayShapeInfo()
        {
          Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");

        }
    }
}
