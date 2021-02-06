using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkList
{
    /// <summary>
    /// Created Interface
    /// </summary>
    /// <typeparam name="K"></typeparam>
    public interface INode<K>
    {
        K GetKey();
        void SetKey(K key);
        INode<K> GetNext();
        void setNext(INode<K> next);

    }
}
