using Assignment_Session_5_OOP.Interfaces;


namespace Assignment_Session_5_OOP.Classes
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");

        }
    }
}
