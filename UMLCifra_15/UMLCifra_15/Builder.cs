namespace UMLCifra_15
{
    public class Builder : ExpenseHandleBase
    {
        public override AnswerResult ApproveExpense(string task)
        {
            return task switch
            {
                "Залить фундамент" => AnswerResult.Ready,
                "Возвести стены" => AnswerResult.Ready,
                "Уложитькровлю" => AnswerResult.Ready,
                _ => base.ApproveExpense(task),
            };
        }
    }
}
