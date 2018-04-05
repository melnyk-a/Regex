namespace Regex
{
    internal class AnyOfCharPatternCreator : IPatternCreator
    {
        public Pattern Create()
        {
            return new AnyOfCharPattern();
        }
    }
}
