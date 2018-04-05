namespace Regex
{
    internal class AnyOneCharPatternCreator : IPatternCreator
    {
        public Pattern Create()
        {
            return new AnyOneCharPattern();
        }
    }
}