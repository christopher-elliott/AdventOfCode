using System;
using System.Collections;
using System.Drawing;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            string[] wire1_directions = lines[0].Split(","); 
            string[] wire2_directions = lines[1].Split(","); 
            int minDistance = WireIntersectCalculator.ShortestWireLengthIntersectionDistance(wire1_directions, wire2_directions);
            
            Console.WriteLine($"minDistance: {minDistance}");
        }
    }

    public class WireIntersectCalculator
    {
        public static int ShortestIntersectionDistance(string[] wire1_directions, string[] wire2_directions)
        {
            Hashtable coordinatesCovered1 = CreateCoordinateHash(wire1_directions);
            Hashtable coordinatesCovered2 = CreateCoordinateHash(wire2_directions);
            int minDistance = -1;
            foreach(Point key in coordinatesCovered1.Keys)
            {
                key.GetHashCode();
                if (coordinatesCovered2.ContainsKey(key))
                {
                    int manhattanDistance = Math.Abs(key.X) + Math.Abs(key.Y);
                    if (manhattanDistance > 0) 
                    {
                        if (minDistance == -1)
                            minDistance = manhattanDistance;
                        if (minDistance > manhattanDistance)
                            minDistance = manhattanDistance;
                        
                        Console.WriteLine($"collision at: {key.ToString()}");
                        Console.WriteLine($"minDistance at: {minDistance}");
                    }
                }
            }
            return minDistance;
        }

        
        public static int ShortestWireLengthIntersectionDistance(string[] wire1_directions, string[] wire2_directions)
        {
            Hashtable coordinatesCovered1 = CreateCoordinateHash(wire1_directions);
            Hashtable coordinatesCovered2 = CreateCoordinateHash(wire2_directions);
            int minDistance = -1;
            foreach(Point key in coordinatesCovered1.Keys)
            {
                key.GetHashCode();
                if (coordinatesCovered2.ContainsKey(key))
                {
                    int wireDistance = (int)(coordinatesCovered1[key]) + (int)(coordinatesCovered2[key]);
                    if (wireDistance > 0) 
                    {
                        if (minDistance == -1)
                            minDistance = wireDistance;
                        if (minDistance > wireDistance)
                            minDistance = wireDistance;
                        
                        Console.WriteLine($"collision at: {key.ToString()}");
                        Console.WriteLine($"minDistance at: {minDistance}");
                    }
                }
            }
            return minDistance;
        }

        public static Hashtable CreateCoordinateHash(string[] wire1_directions)
        {
            Point current_position = new Point(0,0);
            Hashtable coordinatesCovered = new Hashtable();
            int currentWireLength = 0;
            for (int i=0; i < wire1_directions.Length; i++)
            {
                int distance = Int32.Parse(wire1_directions[i].Substring(1));
                switch (wire1_directions[i][0])
                {
                    case 'U':
                        Console.WriteLine($"Moving up {distance}");
                        
                        for (int j=0; j < distance; j++)
                        {
                            current_position.Y -= 1;
                            currentWireLength++;
                            if (!coordinatesCovered.ContainsKey(current_position))
                            {
                                coordinatesCovered.Add(new Point(current_position.X, current_position.Y), currentWireLength);
                            }
                        }
                        break;
                    case 'D':
                        Console.WriteLine($"Moving down {distance}");
                        for (int j=0; j < distance; j++)
                        {
                            current_position.Y += 1;
                            currentWireLength++;
                            if (!coordinatesCovered.ContainsKey(current_position))
                            {
                                coordinatesCovered.Add(new Point(current_position.X, current_position.Y), currentWireLength);
                            }
                        }
                        break;
                    case 'L':
                        Console.WriteLine($"Moving left {distance}");
                        for (int j=0; j < distance; j++)
                        {
                            current_position.X -= 1;
                            currentWireLength++;
                            if (!coordinatesCovered.ContainsKey(current_position))
                            {
                                coordinatesCovered.Add(new Point(current_position.X, current_position.Y), currentWireLength);
                            }
                        }
                        break;
                    case 'R':
                        Console.WriteLine($"Moving right {distance}");
                        for (int j=0; j < distance; j++)
                        {
                            current_position.X += 1;
                            currentWireLength++;
                            if (!coordinatesCovered.ContainsKey(current_position))
                            {
                                coordinatesCovered.Add(new Point(current_position.X, current_position.Y), currentWireLength);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            return coordinatesCovered;
        }
    }
}
