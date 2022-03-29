using System;

public class Program
{
    static void Main(string[] args)
    {
        //Создание экземпляра обработчика
        var keyPressHandler = new KeyPressHandler();

        //Создание обработчика события. При совершении события - выводим на экран введённый символ
        keyPressHandler.OnKeyPressed += (sender, key) =>
            Console.WriteLine($"Введённый символ: {key}");

        //Запускаем обработчик
        keyPressHandler.Run();
    }
}

class KeyPressHandler
{
    //Определение события
    public event EventHandler<char>? OnKeyPressed;

    public void Run()
    {
        char key;
        do
        {
            key = Console.ReadKey().KeyChar;
            OnKeyPressed?.Invoke(this, key); //Вызов события
        } while (char.ToLower(key) != 'c' && char.ToLower(key) != 'с');
    }
}