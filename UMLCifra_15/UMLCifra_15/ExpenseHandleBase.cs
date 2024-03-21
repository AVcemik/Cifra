namespace UMLCifra_15
{
    public class ExpenseHandleBase : IExpenseHandler
    {
        private IExpenseHandler? _expense;
        public virtual AnswerResult ApproveExpense(string task)
        {
            if (_expense != null)
            {
                return _expense.ApproveExpense(task);
            }
            else
            {
                return AnswerResult.Denied;
            }
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _expense = next;
        }
    }
}
