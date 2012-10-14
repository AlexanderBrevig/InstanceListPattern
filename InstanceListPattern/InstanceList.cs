using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstanceListPattern
{
    public class InstanceList<T> : IDisposable where T : class
    {
        public static List<T> Instances { get; set; }

        public InstanceList()
        {
            if (Instances == null) { Instances = new List<T>(); }
            Instances.Add(this as T);
        }
    
        public void Dispose()
        {
            Instances.Remove(this as T);
        }
    }
}
