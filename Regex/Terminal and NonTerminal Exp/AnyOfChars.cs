using System.Collections.Generic;

namespace Regex
{
    internal class AnyOfChars : NonTerminalExp
    {
        public AnyOfChars(List<IExpression> expressionsSet) : base(expressionsSet)
        {
        }

        public override bool IsMatch(Context context)
        {
            bool isMatch = false;

            while (!context.IsLastPosition())
            {
                foreach (var item in _expressionsSet)
                {
                    if (item.IsMatch(context))
                    {
                        isMatch = true;
                        break;
                    }
                }
                if (isMatch)
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
                        isMatch = false;
                        break;
                    }
                }
            }
            return isMatch;
        }
    }
}