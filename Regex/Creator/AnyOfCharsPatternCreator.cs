namespace Regex
{
    internal class AnyOfCharsPatternCreator : IPatternCreator
    {
        public Pattern Create()
        {
            {
                return new AnyOfCharsPattern();
            }
        }
    }
}