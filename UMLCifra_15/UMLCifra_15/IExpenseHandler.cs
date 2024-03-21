namespace UMLCifra_15
{
    public interface IExpenseHandler
    {
        AnswerResult ApproveExpense(string task);
        void RegisterNext(IExpenseHandler next);
    }
}
