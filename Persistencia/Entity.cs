using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Persistencia
    {
        internal class Entity<T>
        {
            private T id;

            public Entity(T item)
            {
                this.id = item;
            }
            public T Id
            {
                get { return this.id; }
            }
        }
    }

