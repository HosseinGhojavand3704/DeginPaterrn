namespace DeginPaterrn.Interpreter
{
    public interface IExpressionDateTime
    {
        void Interpret(Context context);
    }

    public class CocreateExpressionYers : IExpressionDateTime
    {
        public CocreateExpressionYers()
        {
        }

        public void Interpret(Context context)
        {
            string expression = context.Expression.Trim();
            context.Expression = expression.Replace("YYYY" , context.Date.Year.ToString());
        }
    }

    public class CocreateExpressionMonth : IExpressionDateTime
    {
        public CocreateExpressionMonth()
        {
        }

        public void Interpret(Context context)
        {
            string expression = context.Expression.Trim();
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }

    public class CocreateExpressionDay : IExpressionDateTime
    {
        public CocreateExpressionDay()
        {
        }

        public void Interpret(Context context)
        {
            string expression = context.Expression.Trim();
            context.Expression = expression.Replace("DD", context.Date.Day.ToString());
        }
    }
}
