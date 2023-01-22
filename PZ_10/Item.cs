using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_10
{
    abstract class Item
    {
        protected long invNumber;
        protected bool taken;

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
            this.taken = true;
        }

        public bool IsAvaible()
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            taken = false;
        }

        abstract public void Return();

        public virtual void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\nИнвертарный номер: {0}\nНаличие: {1}", invNumber, taken);
        }
        public void TakeItem()
        {
            if (this.IsAvaible())
                this.Take();
        }
    }
}

