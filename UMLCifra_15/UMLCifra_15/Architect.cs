namespace UMLCifra_15
{
    public class Architect : ExpenseHandleBase
    {
        public override AnswerResult ApproveExpense(string task)
        {
            return task switch
            {
                "Составить план здания" => AnswerResult.Ready,
                "Оформить чертеж" => AnswerResult.Ready,
                _ => base.ApproveExpense(task),
            };
        }
    }
}
