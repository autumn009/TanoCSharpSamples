using System;
using System.Linq;

abstract class ErrorReporter
{
    public abstract void SendMessage(string message);
}

class ConsoleReporter : ErrorReporter
{
    public override void SendMessage(string message)
    {
        Console.WriteLine("{0}をコンソールに送信します。", message);
    }
}

class LogReporter : ErrorReporter
{
    public override void SendMessage(string message)
    {
        Console.WriteLine("{0}をログファイルに書き込みます。", message);
    }
}

class MailReporter : ErrorReporter
{
    public override void SendMessage(string message)
    {
        Console.WriteLine("{0}を電子メールで送信します。", message);
    }
}

class Program
{
    private static void sample(ErrorReporter r)
    {
        r.SendMessage("エラー発生");
    }

    static void Main(string[] args)
    {
        var r1 = new ConsoleReporter();
        sample(r1);
        var r2 = new LogReporter();
        sample(r2);
        var r3 = new MailReporter();
        sample(r3);
    }
}
