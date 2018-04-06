using System.Collections.Generic;

namespace Regex
{
    internal class NoneOfChars : NonTerminalExp
    {
        public NoneOfChars(List<IExpression> expressionsSet) :
            base(expressionsSet)
        {
        }

        public override bool IsMatch(Context context)
        {
            bool isMatch = false;

            foreach (var item in _expressionsSet)
            {
                isMatch = !item.IsMatch(context);
                if(isMatch)
                {
                    break;
                }
            }
            return isMatch;
        }
    }
}