namespace Regex
{
    internal class ZeroOrOnePatternCreator : IPatternCreator
    {
        public Pattern Create()
        {
            return new ZeroOrOnePattern();
        }
    }
}
