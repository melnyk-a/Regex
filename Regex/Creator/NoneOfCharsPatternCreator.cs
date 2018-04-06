namespace Regex
{
    internal class NoneOfCharsPatternCreator : IPatternCreator
    {
        public Pattern Create()
        {
            return new NoneOfCharsPattern();
        }
    }
}