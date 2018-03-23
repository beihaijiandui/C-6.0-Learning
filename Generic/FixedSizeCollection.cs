using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FixedSizeCollection
    {
        /// <summary>
        /// 构造函数，增加静态计数器的值
        /// 设置数据项最大数量
        /// </summary>
        /// <param name="maxItems"></param>
        public FixedSizeCollection(int maxItems)
        {
            FixedSizeCollection.InstanceCount++;
            this.Items = new object[maxItems];
        }

        /// <summary>
        /// 将一个未知类型的数据项添加到类中
        /// object可以包含任何类型
        /// </summary>
        /// <param name="item">要添加的数据项</param>
        /// <returns>新添加的数据项的索引</returns>
        public int AddItem(object item)
        {
            if (this.ItemCount < this.Items.Length)
            {
                this.Items[this.ItemCount] = item;
                return this.ItemCount++;
            }
            else
                throw new Exception("item queue is full.");
        }

        public object GetItem(int index)
        {
            if (index >= this.Items.Length && index >= 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            return this.Items[index];
        }

        #region Properties
        /// <summary>
        /// 静态的实例计数器，用于标准类型
        /// </summary>
        public static int InstanceCount { get; set; }
        /// <summary>
        /// 类中包含的数据项数量
        /// </summary>
        public int ItemCount { get; private set; }
        /// <summary>
        /// 类中包含的数据项
        /// </summary>
        private object[] Items { get; set; }
        #endregion //Propertis

        /// <summary>
        /// 重写ToString以提供类的详细信息
        /// </summary>
        /// <returns>包含类详细信息、格式化过的字符串</returns>
        public override string ToString()=>
            $"There are {FixedSizeCollection.InstanceCount.ToString()} instances of{this.GetType().ToString()} and this instance contains {this.ItemCount} items...";

    }

    public class FixedSizeCollection<T>
    {
        /// <summary>
        /// 构造函数，增加静态计数器的值
        /// 设置数据项最大数量
        /// </summary>
        /// <param name="maxItems"></param>
        public FixedSizeCollection(int maxItems)
        {
            FixedSizeCollection<T>.InstanceCount++;
            this.Items = new T[maxItems];
        }

        /// <summary>
        /// 将一个未知类型的数据项添加到类中
        /// object可以包含任何类型
        /// </summary>
        /// <param name="item">要添加的数据项</param>
        /// <returns>新添加的数据项的索引</returns>
        public int AddItem(T item)
        {
            if (this.ItemCount < this.Items.Length)
            {
                this.Items[this.ItemCount] = item;
                return this.ItemCount++;
            }
            else
                throw new Exception("item queue is full.");
        }

        public T GetItem(int index)
        {
            if (index >= this.Items.Length && index >= 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            return this.Items[index];
        }
        #region Properties
        /// <summary>
        /// 静态的实例计数器，用于标准类型
        /// </summary>
        public static int InstanceCount { get; set; }
        /// <summary>
        /// 类中包含的数据项数量
        /// </summary>
        public int ItemCount { get; private set; }
        /// <summary>
        /// 类中包含的数据项
        /// </summary>
        private T[] Items { get; set; }
        #endregion //Propertis

        /// <summary>
        /// 重写ToString以提供类的详细信息
        /// </summary>
        /// <returns>包含类详细信息、格式化过的字符串</returns>
        public override string ToString() =>
            $"There are {FixedSizeCollection<T>.InstanceCount.ToString()} instances of{this.GetType().ToString()} and this instance contains {this.ItemCount} items...";
    }
}
