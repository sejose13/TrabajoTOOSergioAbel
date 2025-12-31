using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Persistencia
{
    internal class Tabla<T, U> : KeyedCollection<T, U> where U : Entity<T>
    {
        public Tabla() { }
        protected override T GetKeyForItem(U item)
        {
            return item.Id;
        }
        public Tabla(IEqualityComparer<T> ieq) : base(ieq) { }
    }
}