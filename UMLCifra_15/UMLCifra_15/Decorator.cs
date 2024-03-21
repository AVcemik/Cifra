namespace UMLCifra_15
{
    public class Decorator : ExpenseHandleBase
    {
        public override AnswerResult ApproveExpense(string task)
        {
            return task switch
            {
                "Заливка полов" => AnswerResult.Ready,
                "Облицовка стен" => AnswerResult.Ready,
                "Покраска" => AnswerResult.Ready,
                "Поклейка обоев" => AnswerResult.Ready,
                "Установка дверей" => AnswerResult.Ready,
                "Монтаж оконных рам" => AnswerResult.Ready,
                _ => base.ApproveExpense(task),
            };
        }
    }
}