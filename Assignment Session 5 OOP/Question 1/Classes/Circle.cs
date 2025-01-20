using Assignment_Session_5_OOP.Interfaces;

namespace Assignment_Session_5_OOP.Classes
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }
        public double Radius { get; set; }


        public double DisplayShapeInfo()
        {
            Area = (Math.PI * Math.Pow(Radius, 2));
            return Area;
        }
    }
}
