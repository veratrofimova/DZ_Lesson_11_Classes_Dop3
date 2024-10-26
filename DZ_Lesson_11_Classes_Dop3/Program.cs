using DZ_Lesson_11_Classes_Dop3;

Console.WriteLine("Добро пожаловать в программу: Реализация класс коллекции - Стэк!");
Console.WriteLine("Создадим коллекцию. Можно добавить несколько значений через запятую. Например: первый,второй,третий");
Console.WriteLine("Коллекция добавляется методом LIFO");

Console.WriteLine("\r\nВведите значения");
string textFromConsole = Console.ReadLine();
string[] elementsFromConsole = textFromConsole.Split(',');

var stack = new Stack(elementsFromConsole);

Console.WriteLine($"Size = {stack.Size}, Top = '{stack.Top}'");

Console.WriteLine("\r\nВам доступны следующие команды: /Add, /Pop, /Exit");
Console.WriteLine("Команда /Add - добавит значение в стек. Например: /Add новый");
Console.WriteLine("Команда /Pop - извлечет верхний элемент и удалит его из стека. ");

try
{
    do
    {
        Console.WriteLine("\r\nВведите команду:");

        textFromConsole = Console.ReadLine().Trim();
        string[] commandText = textFromConsole.Split(new char[] { ' ' });

        switch (commandText[0])
        {
            case "/Add":
                string elementFromConsole = textFromConsole.Replace(commandText[0], "").Trim();

                stack.Add(elementFromConsole);

                Console.WriteLine($"Size = {stack.Size}, Top = '{stack.Top}'");
                break;
            case "/Pop":
                var deleted = stack.Pop();
                Console.WriteLine($"Извлечен верхний элемент '{deleted}' Size = {stack.Size}");
                Console.WriteLine($"Size = {stack.Size}, Top = '{stack.Top}'");
                break;
        }
    } while (!textFromConsole.Contains("/Exit"));

    Console.WriteLine("\r\nРабота программы завершена");
}
catch (EmptyStackException ex)
{
    Console.WriteLine(ex.Message);
}
catch
{
    throw;
}
