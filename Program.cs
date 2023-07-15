
        double DistanceBetweenPoints(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
            return distance;
        }

        // Пример использования функции для расчета расстояния между двумя точками

        double x1 = 3;
        double y1 = 6;
        double z1 = 8;

        double x2 = 2;
        double y2 = 1;
        double z2 = -7;

        double distance1 = DistanceBetweenPoints(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("Расстояние между точками A и B: " + distance1.ToString("F2"));

        x1 = 7;
        y1 = -5;
        z1 = 0;

        x2 = 1;
        y2 = -1;
        z2 = 9;

        double distance2 = DistanceBetweenPoints(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("Расстояние между точками A и B: " + distance2.ToString("F2"));