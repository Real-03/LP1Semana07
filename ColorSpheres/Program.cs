using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color = new Color(255,222,92);
            Sphere sphere = new Sphere(color,5);
            Console.WriteLine(Convert.ToString(color.GetGray()));
            Console.WriteLine(Convert.ToString(color.GetAlpha()));

            sphere.Throw();
            sphere.Throw();
            sphere.Throw();
            sphere.Throw();
            sphere.Pop();
            sphere.Throw();
            sphere.Throw();

            Console.Write($"{Convert.ToString(sphere.GetTimesThrown())}, ({Convert.ToString(sphere.GetColor().GetRed())},");
            Console.Write($"{Convert.ToString(sphere.GetColor().GetGreen())},{Convert.ToString(sphere.GetColor().GetBlue())},{Convert.ToString(sphere.GetColor().GetAlpha())})");
        }
    }

    public class Color
    {
        private int Red;
        private int Green;
        private int Blue;
        private int Alpha;

        public Color(int red, int green, int blue)
        {
            if(red>=0 && red <=255)
                Red = red;
            else
                Red = 0;
            
            if(green>=0 && green <=255)
                Green = green;
            else
                Green = 0;
            if(blue>=0 && blue <=255)
                Blue = blue;
            else
                Blue = 0;
            
            Alpha = 255;
        }

        public Color(int red, int green, int blue, int alpha)
        {
            if(red>=0 && red <=255)
                Red = red;
            else
                Red = 0;
            
            if(green>=0 && green <=255)
                Green = green;
            else
                Green = 0;

            if(blue>=0 && blue <=255)
                Blue = blue;
            else
                Blue = 0;
            
            if(alpha>=0 && alpha <=255)
                Alpha = alpha;
            else
                Alpha = 255;
        }



        public int GetRed()
        {
            return Red;
        }
        public int GetGreen()
        {
            return Green;
        }
        public int GetBlue()
        {
            return Blue;
        }
        public int GetAlpha()
        {
            return Alpha;
        }


        public int GetGray()
        {
            return (Red+Green+Blue)/3;
        }



    }

    public class Sphere
    {
        private Color Color;
        private int Raio;

        private int TimesThrow;


        public Sphere(Color color, int raio)
        {
            Color = color;
            Raio = raio;
            TimesThrow = 0;
        }

        public void Pop()
        {
            Raio = 0;
        }
        public void Throw()
        {
            if(Raio >0)
                TimesThrow++;
        }
        public int GetTimesThrown()
        {
            return TimesThrow;
        }
        public Color GetColor()
        {
            return Color;
        }
    }    
}
