using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkList
{
    /// <summary>
    /// Implement Add Method inside the class
    /// </summary>
        public class MyLinkedList
        {
            public INode<int> head;
            public INode<int> tail;

            public MyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void Add(INode<int> node)
            {
                if (this.tail == null)
                {
                    this.tail = node;
                }
                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    INode<int> tempNode = this.head;
                    this.head = node;
                    this.head.setNext(tempNode);
                }
            }
        }
}
