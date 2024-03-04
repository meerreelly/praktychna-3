double y;
Console.WriteLine("x\ty");
for(int x = 100; x <= 200; x ++)
{
    if(x%10!=0)continue;
    y=(Math.Pow(Math.Cos(Math.Pow(x,2)+5),3))/(Math.Sqrt(x-Math.Log(x)));
    string ystring;
    if(y>0)
    {
        ystring=$" {y:f04}";
    }else ystring= $"{y:f04}";
    Console.WriteLine("{0}\t{1}",x,ystring);}
