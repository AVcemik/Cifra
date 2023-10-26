using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface ITask
    {
        string Title { get; set; } // Название задачи или события
        DateTime DueDate { get; set; } // Дата выполнение задачи или события.
        Priority Priority { get; set; } // Приоритет задачи или события


        void Display(); // Метод для отображения информации о задачи или событии.
    }
}
