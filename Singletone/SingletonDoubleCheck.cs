using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    // double-check locking 
    public sealed class SingletonDoubleCheck
    {

        private static /*volatile*/ SingletonDoubleCheck instance;
        private static object syncRoot = new Object();

        private SingletonDoubleCheck()
        {
        }

        public static SingletonDoubleCheck Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDoubleCheck();
                        }
                    }
                }

                return instance;
            }
        }

    }

}
