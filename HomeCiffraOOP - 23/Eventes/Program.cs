




Keyboard keyboard = new Keyboard();
keyboard.KeyPressed += OnKeyPressed;

while (true)
{
    keyboard.SimulateKeyPress(Console.ReadKey().Key);
}



static void OnKeyPressed(object sender, KeyPressedEventArgs e)
{
    Console.WriteLine($" нажата клавиша - \"{e.Key}\"");
}

    class Keyboard
{
    public event EventHandler<KeyPressedEventArgs> KeyPressed;

    public void SimulateKeyPress(ConsoleKey key)
    {
        char character = GetConsoleKey(key);
        OnKeyPressed(new KeyPressedEventArgs(character));
    }

    private char GetConsoleKey(ConsoleKey key)
    {
        if (key >= ConsoleKey.A && key <= ConsoleKey.Z)
        {
            return (char)('A' + (key - ConsoleKey.A));
        }
        else if (key >= ConsoleKey.D0 && key <= ConsoleKey.D9)
        {
            return (char)('0' + (ConsoleKey.D0));
        }
        else
        {
            return '\0';
        }
    }

    protected virtual void OnKeyPressed(KeyPressedEventArgs e)
    {
        KeyPressed?.Invoke(this, e);
    }
}

class KeyPressedEventArgs : EventArgs
{
    public char Key { get; }

    public KeyPressedEventArgs(char key)
    {
        Key = key;
    }
}