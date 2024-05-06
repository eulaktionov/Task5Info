List<int> numbers = new List<int>();
for(int i=1;i<=50;i++)
{
    Console.WriteLine($"I:{i} R={SeacrhR(i)}");
    if(SeacrhR(i) > 151)
    {
        numbers.Add(SeacrhR(i));
    }
}
Console.WriteLine(numbers.Min());
Console.ReadKey();
int SeacrhR(int number)
{
    int R = 0;
    int ost = number % 3;
    switch(ost)
    {
        case 0:
            R = number * 8 + number%8;
            break;
        case 1:
            R = number * 4 + 3;
            break;
        case 2:
            R = number * 8 + 6;
            break;
    }
    return R;
}
