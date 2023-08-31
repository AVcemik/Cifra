string defaultPath = @"C:\Users\Print01\Desktop";

PrintDirectory(new DirectoryInfo(defaultPath), "", true);
static void PrintDirectory(DirectoryInfo directory, string indent, bool lastDirectory)
{
    Console.Write(indent);
    if (lastDirectory) { Console.Write("└─"); indent += " "; }
    else { Console.Write("├─"); indent += "│ "; }
    Console.WriteLine(directory.Name);

    DirectoryInfo[] subDirectory = directory.GetDirectories();
    for (int i = 0; i < subDirectory.Length; i++)
    {
        PrintDirectory(subDirectory[i], indent, i == subDirectory.Length - 1);
    }
}