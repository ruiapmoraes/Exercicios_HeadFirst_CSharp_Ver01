using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag_244_Heranca
{
    class Locksmith
    {
        private string writtenDownCombination = null;

        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        private void ReturnContents(Jewels safeContents, Owner owner)
        {
            throw new NotImplementedException();
        }

        internal void WriteDownCombination(string safeCombination)
        {
            throw new NotImplementedException();
        }
    }
}
