using Assignment_Session_5_OOP.Interfaces;


namespace Assignment_Session_5_OOP.Classes
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public double DisplayShapeInfo()
        {
            Area = Length * Width;
            return Area;
        }
    }
}
