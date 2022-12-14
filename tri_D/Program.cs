using System;
 
class GFG
{
     

static void distance(float x1, float y1,
                     float z1, float x2,
                     float y2, float z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine("Distance is \n" + d);
    return;
}
 
public static void Main()
{
    float x1 = 2;
    float y1 = -5;
    float z1 = 7;
    float x2 = 3;
    float y2 = 4;
    float z2 = 5;
   
    distance(x1, y1, z1,
             x2, y2, z2);
}
}
 
