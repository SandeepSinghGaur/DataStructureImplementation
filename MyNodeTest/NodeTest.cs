using MyLinkList;
using NUnit.Framework;

namespace MyNodeTest
{
    public class NodeTest
    {
        /// <summary>
        /// Test the Order of thr Node 56->30->70
        /// </summary>
        [Test]
    public void given3NumbersWhenLinkedShouldPassToLinkedList()
        {
            MyNode<int> myFirstNode = new MyNode<int>(56);
            MyNode<int> mySecondNode = new MyNode<int>(30);
            MyNode<int> myThirdNode = new MyNode<int>(70);
            myFirstNode.SetNext(mySecondNode);
            mySecondNode.SetNext(myThirdNode);
            bool result = myFirstNode.GetNext().Equals(mySecondNode) && mySecondNode.GetNext().Equals(myThirdNode);
            Assert.AreEqual(result, true);
        }


    }
}