int[] rgbnums = {123, -255, 9000 };
Console.WriteLine(RGBConvertTo16x(rgbnums));

string RGBConvertTo16x(int[] rgb)
{
    string result = "";
    for (int index = 0; index < rgb.Length; index++)
    {
        if (rgb[index] < 0)
        {
            rgb[index] = 0;
        }
        if (rgb[index] > 255)
        {
            rgb[index] = 255;
        }
        string temp = Convert.ToString(rgb[index], 16);
        if (temp.Length < 2)
        {
            result += 0;
        }
        result += temp;
    }
    return result;
}


