 using System;

public class Canon : PrinterWindows
{
    public override void Show()
    {
      Console.WriteLine("Canon display dimension : 9.5*12");  
    }
    public override void Print()
    {
        Console.WriteLine("Canon Printer is Printing ...");
    }

}