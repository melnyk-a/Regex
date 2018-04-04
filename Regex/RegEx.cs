namespace Regex
{
    internal class RegEx
    {
        private IExpression _patternExpression;
        private Pattern _chain;
        public RegEx(string pattern)
        {
            SetChain();
            _patternExpression = ConvertToPatternExpression(pattern);
        }
        public bool IsMatch(string input)
        {
            return _patternExpression.IsMatch(new Context(input));
        }
        public void SetPattern(string pattern)
        {
            _patternExpression = ConvertToPatternExpression(pattern);
        }
        private IExpression ConvertToPatternExpression(string pattern)
        {
            IExpression patternEnexpression = null;
            patternEnexpression = _chain.GetPattern(pattern);
            if (patternEnexpression == null)
            {
                throw new InputIncorrectPatternException("Pattern expression not find");
            }
            return patternEnexpression;
        }
        private void SetChain()
        {
            NoneOfCharsPattern none = new NoneOfCharsPattern();
            AnyOfCharPattern any = new AnyOfCharPattern();
            AnyOneCharPattern anyOne = new AnyOneCharPattern();
            ZeroOrOnePattern zeroOrOne = new ZeroOrOnePattern();

            _chain = none;
            none.SetNext(any);
            any.SetNext(anyOne);
            anyOne.SetNext(zeroOrOne);
        }
    }
}
