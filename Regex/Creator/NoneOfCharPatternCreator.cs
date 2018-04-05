namespace Regex
{
    internal class NoneOfCharPatternCreator : IPatternCreator
    {
        public Pattern Create()
        {
            return new NoneOfCharsPattern();
        }
    }
}