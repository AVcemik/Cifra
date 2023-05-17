// Лубенец - 15.15 (sbornik_zadach)

// Имеется текстовый файл.
// Добавить в него строку из двенадцати черточек (------------), разместив ее:
// а) после пятой строки;
// б) после последней из строк, в которых нет пробела. Если таких строк нет, то  новая строка должна быть добавлена после всех строк имеющегося файла.
// В обоих случаях результат записать в другой файл

using System.Text;


string nameFile = "File.txt";
string nameFileNew = "newFile.txt";

using (FileStream fs = new FileStream(nameFile, FileMode.Open, FileAccess.Read))
{
    byte[] buffer = new byte[fs.Length];
    await fs.ReadAsync(buffer, 0, buffer.Length);
    StringBuilder sb = new StringBuilder();
    string readText = Encoding.Default.GetString(buffer);
    sb.Append(readText);

    for (int i = 0, line = 1; i < sb.Length; i++) // Задание а
    {
        if (sb[i] == '\n')
        {
            line++;
            if (line == 5)
            {
                sb.Append("------------\n");
                break;
            }
        }
    }
    int _line = 1;
    for (int i = 0; i < sb.Length; i++)     // так я узнал кол-во строк в файле
    {
        if (sb[i] == '\n')
        {
            _line++;
        }
    }
    int[] _countLine= new int[_line];
    int[] _probel = new int[_line];

    for (int i = 0; i < _countLine.Length; i++)     // Так я узнал сколько символов в каждой строке
    {
        for (int j = 0, count = 0; j < sb.Length; j++, count++)
        {
            if (sb[i] == '\n')
            {
                _countLine[i] = count;
                count = 0;
            }
        }
    }

    for (int i = 0, j = 0, count = 0; i < sb.Length; i++)  // Так я узнал кол-во пробелов в каждой строке
    {           
        if (_countLine[j] == 1)
        {
            _probel[j] = 1;
            j++;
            continue;
        }
        else if (sb.Length == '\n')
        {
            j++;
            continue;
        }
        else if (sb.Length == ' ')
        {
            _probel[j] = _probel[j]++;
        }
    }
    for (int i = _probel.Length; i >= 0; i--)
    {
        if (_probel[i] == 1)
        {
            for (int j = 0, count = 0; j < sb.Length; j++)
            {
                if (count == _line)
                {
                    sb.Append("------------\n");
                    break;
                }
                if (sb[j] == '\n') count++;
            }
        }
    }
    using (FileStream fswhrite = new FileStream(nameFileNew, FileMode.Create, FileAccess.Write))
    {

    }

}