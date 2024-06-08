
namespace Twitter_Towers
{
    internal class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public string getRectangleDetails()
        {
            if (this.width == this.height || Math.Abs(this.width - this.height) > 5)
            {
                return "The area of the rectangle is " + (this.width * this.height);
            }
            else
            {
                return "The perimeter of the rectangle is " + (this.width + this.height) * 2;
            }
        }
    }
}
