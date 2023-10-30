/*
 *              Домашнее задание №26
 *          Введение в многопоточность
 */


Counter counters1 = new();
Counter counters2 = new();


Thread thread1 = new Thread(counters1.UpCounterTo100);
Thread thread2 = new Thread(counters2.DownCounterTo100);

thread1.Start();
thread2.Start();



public class Counter
{
    private static readonly object _lockObject = new object();
    private int _counters = 0;

    public void UpCounterTo100()
    {
        for (int i = 0; i < 100; i++)
        {
            lock (_lockObject)
            {
                _counters++;
                GetCounter(0, 0);
                Thread.Sleep(250);
            }
        }
    }

    public void DownCounterTo100()
    {
        for (int i = 0; i < 100; i++)
        {
            lock (_lockObject)
            {
                _counters--;
                GetCounter(4, 0);
                Thread.Sleep(250);
            }
        }
    }
    public void GetCounter(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(_counters);
    }
}