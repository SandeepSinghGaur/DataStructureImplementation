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
        /// <summary>
        /// Implement Add Method
        /// </summary>
        /// <param name="node"></param>

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
        /// <summary>
        /// Implement Append Method
        /// </summary>
        /// <param name="myNode"></param>
        public void append(INode<int> myNode)
        {
            if (this.head == null)
            {
                this.head = myNode;
            }
            if (this.tail == null)
            {
                this.tail = myNode;
            }
            else
            {
                this.tail.SetNext(myNode);
                this.tail = myNode;
            }
        }
        /// <summary>
        /// Implement Insert Method
        /// </summary>
        /// <param name="myNode"></param>
        /// <param name="newNode"></param>
        public void insert(INode<int> myNode, INode<int> newNode)
        {
            INode<int> tempNode = myNode.GetNext();
            myNode.setNext(newNode);
            newNode.setNext(tempNode);

        }
        /// <summary>
        /// Implement Pop First Element Method
        /// </summary>
        public void pop()
        {
            INode<int> tempNode = this.head;
            this.head = head.GetNext();
        }
        /// <summary>
        /// Implement Pop Last Element Method
        /// </summary>
        /// <returns></returns>
        public INode<int> popLast()
        {
            INode<int> tempNode = head;
            while (!tempNode.GetNext().Equals(tail))
            {
                tempNode = tempNode.GetNext();
            }
            this.tail = tempNode;
            tempNode = tempNode.GetNext();
            return tempNode;
        }
        /// <summary>
        /// Search the Given Node
        /// </summary>
        /// <param name="findNode"></param>
        /// <returns></returns>
        public bool searchNode(INode<int> findNode)
        {
            INode<int> tempNode = head;
            while (tempNode != tail)
            {
                if (tempNode.GetKey() == findNode.GetKey())
                {
                    Console.WriteLine(findNode.GetKey());
                    Console.WriteLine(" " + "is present in LinkList");
                    return true;
                }
                tempNode = tempNode.GetNext();
            }
            if (tempNode.GetKey() == findNode.GetKey())
            {
                Console.WriteLine(findNode.GetKey());
                Console.WriteLine(" " + "is present in LinkList");
                return true;
            }
            return false;
        }
    }
}
