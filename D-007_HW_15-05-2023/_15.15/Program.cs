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
    StringBuilder sbnew = new StringBuilder();
    StringBuilder result = new StringBuilder();

    for (int i = 0, line = 1; i < sb.Length; i++) // Задание а
    {
        sbnew.Append(sb[i]);
        if (sb[i] == '\n')
        {
            line++;
            if (line == 5)
            {
                sbnew.AppendLine("------------");
            }
        }
    }
    int _line = 1;
    for (int i = 0; i < sbnew.Length; i++)     // так я узнал кол-во строк в файле
    {
        if (sbnew[i] == '\n')
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
            if (sbnew[i] == '\n')
            {
                _countLine[i] = count;
                count = 0;
            }
        }
    }

    for (int i = 0, j = 0, count = 0; i < sbnew.Length; i++)  // Так я узнал кол-во пробелов в каждой строке
    {           
        if (_countLine[j] == 1)
        {
            _probel[j] = 1;
            j++;
            continue;
        }
        else if (sbnew.Length == '\n')
        {
            j++;
            continue;
        }
        else if (sbnew.Length == ' ')
        {
            _probel[j] = _probel[j]++;
        }
    }
    int _nLine = _probel.Length-1;
    for (; _nLine >= 0; _nLine--)
    {
        if (_probel[_nLine] == 1)
        {
            for (int j = 0, count = 0; j < sbnew.Length; j++)
            {
                result.Append(sbnew[j]);
                if (count == _line)
                {
                    result.Append("------------\n");
                    continue;
                }
                if (sbnew[j] == '\n') count++;
            }
        }
    }
    using (FileStream fswhrite = new FileStream(nameFileNew, FileMode.Create, FileAccess.Write))
    {
        byte[] bufferwr = Encoding.Default.GetBytes(sbnew.ToString());
        await fswhrite.WriteAsync(bufferwr, 0, bufferwr.Length);
    }

}