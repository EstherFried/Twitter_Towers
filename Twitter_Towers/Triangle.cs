using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Towers
{
    internal class Triangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public double getPerimeter()
        {
            double side = Math.Sqrt(Math.Pow(this.width / 2, 2) + Math.Pow(this.height, 2));
            return (this.width + side * 2);
        }
        public string printTriangle()
        {
            string triangleByStars = "";

            if (this.width % 2 == 0 || this.width > this.height * 2)
            {
                return "The triangle cannot be printed";
            }
            else
            {
                int spaceInLine = (int)(this.width) / 2;
                int starsInLine;
                int numberOfDiffGroups = (int)(this.height - 2) / ((int)(this.width + 1) / 2 - 2);
                for (int i = 1; i <= this.height; i++)
                {
                    if (i == 1)
                    {
                        for (int j = 1; j <= this.width; j++)
                        {
                            if (j == (int)(this.width + 1) / 2)
                            {
                                triangleByStars += "*";
                            }
                            else
                            {
                                triangleByStars += " ";
                            }
                        }
                        spaceInLine--;
                    }
                    else
                    {
                        if (i == this.height - numberOfDiffGroups * (spaceInLine - 1))
                        {
                            spaceInLine--;
                        }
                        starsInLine = (int)this.width - spaceInLine * 2;
                        for (int j = 0; j < spaceInLine; j++)
                        {
                            triangleByStars += " ";
                        }
                        for (int j = 0; j < starsInLine; j++)
                        {
                            triangleByStars += "*";
                        }
                    }
                    triangleByStars += "\n";
                }
            }
            return triangleByStars;
        }
    }
}

