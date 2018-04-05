using System.Collections.Generic;

namespace Regex
{
    internal class NoneOfChars : NonTerminalExp
    {
        public NoneOfChars(List<IExpression> expressionsSet) : base(expressionsSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            bool isMatch = true;

            while (!context.IsLastPosition())
            {
                foreach (var item in _expressionsSet)
                {
                    if (item.IsMatch(context))
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (!isMatch)
                {
                    break;
                }
                else
                {
                    if (CanAdvance(context))
                    {
                        context.Advance(1);
                    }
                    else
                    {
                        isMatch = true;
                        break;
                    }
                }
            }
            return isMatch;
        }
    }
}
