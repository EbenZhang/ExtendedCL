using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedCL
{
    public class ScopeDisposer : IDisposable
    {
        private Action _exit;
        public ScopeDisposer(Action enter, Action exit)
        {
            enter();

            _exit = exit;
        }

        public ScopeDisposer(Action exit)
        {
            _exit = exit;
        }
        public void Dispose()
        {
            _exit();
            _exit = null;
        }
    }
}
