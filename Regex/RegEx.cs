﻿using System.Collections.Generic;

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
                string message = "Pattern expression not find";
                throw new InputIncorrectPatternException(message);
            }
            return patternEnexpression;
        }
        private void SetChain()
        {
            List<IPatternCreator> patternCreators = new List<IPatternCreator>
            {
                new NoneOfCharsPatternCreator(),
                new AnyOfCharsPatternCreator(),
                new AnyOneCharPatternCreator(),
                new ZeroOrOnePatternCreator()
            };

            ChainCreator creator = new ChainCreator(patternCreators);
            _chain = creator.Create();
        }
    }
}