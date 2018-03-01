using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    public interface IShallowCopy<T>
    {
        T ShallowCopy();
    }

    public interface IDeepCopy<T>
    {
        T DeepCopy();
    }

    public class ShallowClone : IShallowCopy<ShallowClone>
    {
        public int data = 1;
        public string str = "abc";
        public List<string> listData = new List<string>();
        public object objData = new object();
        public class inClass
        {
            int a = 1;
        }
        public ShallowClone ShallowCopy() => (ShallowClone)this.MemberwiseClone();
    }

    [Serializable]
    public class DeepClone : IDeepCopy<DeepClone>
    {
        public int data = 1;
        public string str = "abc";
        public List<string> listData = new List<string>();
        public object objData = new object();


        public DeepClone DeepCopy()
        {
            BinaryFormatter BF = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            BF.Serialize(memStream, this);
            memStream.Flush();
            memStream.Position = 0;
            return (DeepClone)BF.Deserialize(memStream);
        }
    }
}
