string IntersectionPoint(float[] array)
{
    float x = 0;
    float y = 0;
    string final = "";
    Console.WriteLine("Сначала введите значения k1, k2, b1, b2: ");
    for (int i = 0; i < 4; i++) float.TryParse(Console.ReadLine(), out array[i]);
    x = (array[3] - array[2])/(array[0] - array[1]);
    y = array[0] * x + array[2];
    final = $"({x}, {y})";
    return final;

}



float[] Array = new float[4];
Console.Write(IntersectionPoint(Array));