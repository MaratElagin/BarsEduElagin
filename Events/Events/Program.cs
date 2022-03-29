using System;

public class Program
{
    static void Main(string[] args)
    {
        //Создание экземпляра обработчика
        var handler = new KeyPressHandler();
        
        //Создание обработчика события. При совершении события - выводим на экран введённый символ
        handler.OnKeyPressed += symbol => Console.WriteLine(symbol);
        
        //Запускаем обработчик
        handler.Run();
    }
}
class KeyPressHandler
{
    //Создание делегата для события
    public delegate void EventHandler(char symbol);

    //Определение события
    public event EventHandler? OnKeyPressed; 
    
    public void Run()
    {
        char symbol;
        do
        {
            symbol = (char) Console.Read();
            OnKeyPressed?.Invoke(symbol); //Вызов события
        } while (symbol != 'c');
    }
}