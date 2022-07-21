using System;

public class TriangularPrismCustom
{
    static void Main()
    {
        TriangularPrism triangularPrism = new TriangularPrism(0,0,0);
        Console.WriteLine("三角柱");
        Console.WriteLine("計算方法を選んでください\n1.3辺と高さ\n2.底面の底辺と底面の高さと全体の高さ(1～2)");
        switch(InputInt(1, 2))
        {
            case 1:
                triangularPrism = new TriangularPrism(InputFloat("一辺の長さ(a)を入力してください"), InputFloat("一辺の長さ(b)を入力してください"), InputFloat("一辺の長さ(c)を入力してください"),InputFloat("高さを入力して下さい"));
                break;
            case 2:
                triangularPrism = new TriangularPrism(InputFloat("底面の底辺を入力して下さい"), InputFloat("底面の高さを入力して下さい"), InputFloat("高さを入力して下さい"));
                break;

        }
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
    static int InputInt(int min,int max)
    {
        int input;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input >= min && input <= max)
                {
                    return input;
                }
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
        float temp = (bottom1 + bottom2 + bottom3) / 2.0f;//ヘロンの公式(s)
        bottom = (float)Math.Sqrt(temp * (temp - bottom1) * (temp - bottom2) * (temp - bottom3)); 
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