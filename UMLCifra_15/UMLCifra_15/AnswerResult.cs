using System.ComponentModel;

namespace UMLCifra_15
{
    public enum AnswerResult
    {
        [Description("Работа выполнена")]
        Ready,
        [Description("У нас нет специалистов для данной работы")]
        Denied
    }
}
