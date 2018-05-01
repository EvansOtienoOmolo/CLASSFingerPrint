using System;

namespace CLASSFingerPrint
{
    internal class Sqlconnection
    {
        internal readonly object Open;
        private string v;

        public Sqlconnection(string v)
        {
            this.v = v;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}