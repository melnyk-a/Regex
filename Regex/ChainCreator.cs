using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    internal class ChainCreator
    {
        private List<IPatternCreator> _list;
        public ChainCreator(List<IPatternCreator> creators)
        {
            _list = creators;
        }
        public Pattern Create()
        {
            Pattern firstChain = _list[0].Create();

            Pattern currentChain = firstChain;
            Pattern nextChain;
            for (int i = 1; i < _list.Count; ++i)
            {
                nextChain = _list[i].Create();
                currentChain.SetNext(nextChain);
                currentChain = nextChain;
            }
            return firstChain;
        }
    }
}
