using System;
using System.Collections.Generic;
using System.Text;

namespace GrabageCollection
{

    //implement dispose pattern

    public interface IDisposable
    {
        void Dispose();
    }
    internal class DisposeMethodUse:IDisposable
    {
        private bool _disposed=false;

        ~DisposeMethodUse()
        {
            Dispose(false);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                //disponse the manahed resource of the class
            }
            //dispose the un-managed resource of the class
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
