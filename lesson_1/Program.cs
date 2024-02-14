
string? readString = "";

while(readString != "q")
{
    double a;
    double b;
    string result = "";

    Console.Clear();
    Console.WriteLine("  КАЛЬКУЛЯТОР  (выход: q)");
    Console.Write("Введите выражение для вычисления (пример: 12+8): ");
    readString = Console.ReadLine();
    if (readString != null)
    {
        readString = readString.Replace('.', ',');
        if (readString.Contains("+"))
        {
            a = Convert.ToDouble(readString.Split('+')[0]);
            b = Convert.ToDouble(readString.Split('+')[1]);
            result = (a + b).ToString();
        }
        if (readString.Contains("-"))
        {
            a = Convert.ToDouble(readString.Split('-')[0]);
            b = Convert.ToDouble(readString.Split('-')[1]);
            result = (a - b).ToString();
        }
        if (readString.Contains("*"))
        {
            a = Convert.ToDouble(readString.Split('*')[0]);
            b = Convert.ToDouble(readString.Split('*')[1]);
            result = (a * b).ToString();
        }
        if (readString.Contains("/"))
        {
            a = Convert.ToDouble(readString.Split('/')[0]);
            b = Convert.ToDouble(readString.Split('/')[1]);
            try
            {
                result = (a / b).ToString();
            }
            catch { result = "ошибка"; }
        }
        if (readString == "q")
        {
            return;
        }
    }
    Console.WriteLine($"Ответ: {result}");
    Console.WriteLine("Для продолжения нажмите \"Enter\".");
    if(Console.ReadLine() == "q")
    {
        return;
    }
}
