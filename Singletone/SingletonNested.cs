using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    // Lazy
    public sealed class SingletonNested
    {

        private SingletonNested() { }

        public static SingletonNested Instance
        {
            get { return Nested.Instance; }
        }

        private class Nested
        {

            static Nested() { }

            internal static readonly SingletonNested Instance = new SingletonNested();

        }

    }
}
