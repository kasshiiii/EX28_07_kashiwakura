using System;

public class TriangularPrismCustom
{
    static void Main()
    {
        Console.WriteLine("三角柱");
        TriangularPrism triangularPrism = new TriangularPrism(InputFloat("底面の底辺を入力して下さい"), InputFloat("底面の高さを入力して下さい"), InputFloat("高さを入力して下さい"));
        Console.WriteLine("表面積 = " + triangularPrism.GetSurface());
        Console.WriteLine("体積 = " + triangularPrism.GetVolume());

    }

    static float InputFloat(string outputString)
    {
        float input;
        while (true)
        {
            Console.WriteLine(outputString);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
class TriangularPrism
{
    float bottom1, bottom2, bottom3, bottomHeight, height;
    float bottom, side;
    public TriangularPrism(float bottom1, float bottomHeight, float height)
    {
        this.bottom1 = bottom1;
        this.bottomHeight = bottomHeight;
        this.height = height;
        bottom = this.bottom1 * this.bottomHeight / 2.0f;
        side = (float)(bottom1 + bottomHeight + Math.Sqrt(bottom1 * bottom1 + bottomHeight * bottomHeight)) * height;
    }
    public TriangularPrism(float bottom1, float bottom2, float bottom3, float height)
    {
        this.bottom1 = bottom1;
        this.bottom2 = bottom2;
        this.bottom3 = bottom3;
        this.height = height;
        //float temp1 = 
        //bottom = 
        side = (bottom1 + bottom2 + bottom3) * height;
    }
    public double GetSurface()
    {
        return bottom * 2 + side;
    }
    public float GetVolume()
    {
        return bottom * height;
    }
}