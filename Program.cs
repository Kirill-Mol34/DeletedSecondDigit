int num = new Random().Next(100,999);
int NewNum = 0;
int NumWithoutSecDig()
{
    NewNum = num / 100 * 10 + num % 10;
    return NewNum;
}
NumWithoutSecDig();
System.Console.WriteLine($"После удаления второй цифры из чмсла {num},получится {NewNum}");