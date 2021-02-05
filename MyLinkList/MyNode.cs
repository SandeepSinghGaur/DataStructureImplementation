using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkList
{
    /// <summary>
    /// By Using Generic Create a LinkList
    /// </summary>
    /// <typeparam name="K"></typeparam>
    public class MyNode<K>
    {
        private K key;
        private MyNode<K> next;

        public MyNode(K key)
        {
            this.key = key;
            this.next = null;
        }

        public MyNode<K> GetNext()
        {
            return next;
        }

        public void SetNext(MyNode<K> next)
        {
            this.next = next;
        }

        public K GetKey()
        {
            return key;
        }

        public void SetKey(K key)
        {
            this.key = key;
        }
    }
}
