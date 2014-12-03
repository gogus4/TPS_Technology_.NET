using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeParametre
{
    class NamedObject<T>
    {
        public readonly string Name;
        T Value;

        public NamedObject(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public static explicit operator T(NamedObject<T> obj) { return obj.Value; }

        public override string ToString()
        {
            return String.Format("{0} = {1}", Name, Value);
        }
    }
}