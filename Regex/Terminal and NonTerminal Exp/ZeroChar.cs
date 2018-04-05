using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    internal class ZeroChar : NonTerminalExp
    {
        public ZeroChar(List<IExpression> expressionsSet) : base(expressionsSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            bool isMatch = true;
            for (int i = 0; i < _expressionsSet.Count; ++i)
            {
                if (_expressionsSet[i].IsMatch(context))
                {
                    if (CanAdvance(context))
                    {
                        context.Advance(1);
                    }
                    else
                    {
                        if (i != _expressionsSet.Count - 1)
                        {
                            isMatch = false;
                            break;
                        }
                    }
                }
                else
                {
                    isMatch = false;
                    break;
                }
            }
            return isMatch;
        }
    }
}
