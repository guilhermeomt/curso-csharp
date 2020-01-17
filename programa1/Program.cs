using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Entre com as medidas do Triangulo X");
            float aX = float.Parse(Console.ReadLine());
            float bX = float.Parse(Console.ReadLine());
            float cX = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com as medidas do Triangulo Y");
            float aY = float.Parse(Console.ReadLine());
            float bY = float.Parse(Console.ReadLine());
            float cY = float.Parse(Console.ReadLine());
            
            float areaX = calculaArea(aX,bX,cX);
            float areaY = calculaArea(aY,bY,cY);

            System.Console.WriteLine("Area de X = " + areaX);
            System.Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if(areaX > areaY)
                System.Console.WriteLine("Maior area: X");
            else
                System.Console.WriteLine("Maior area: Y");

        }

        static float calculaArea(float a, float b, float c)
        {
            float area = 0f, p = 0f;

            p = (a + b + c) / 2f;
            area = (float) Math.Sqrt(p * (p-a) * (p-b) * (p-c));
            
            return area;
        }
    }
