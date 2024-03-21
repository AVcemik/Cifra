namespace UMLCifra_15
{
    public class Electrician : ExpenseHandleBase
    {
        public override AnswerResult ApproveExpense(string task)
        {
            return task switch
            {
                "Монтаж электропроводки" => AnswerResult.Ready,
                "Монтаж электрооборудования" => AnswerResult.Ready,
                "Монтаж розеток" => AnswerResult.Ready,
                "Монтаж осветительных приборов" => AnswerResult.Ready,
                _ => base.ApproveExpense(task),
            };
        }

    }
}
