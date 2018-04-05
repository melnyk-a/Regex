namespace Regex
{
    internal interface IExpression
    {
        bool IsMatch(Context context);
    }
}