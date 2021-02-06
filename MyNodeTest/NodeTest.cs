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
        /// <summary>
        /// Ability to create Linked  List by adding 30 and 56 to 70
        /// Node with data 70 is First Created
        /// Next 30 is added to 70
        /// - Finally 56 is added to 30
        /// </summary>
        [Test]
        public void given3NumbersWhenAddedToLinkedListShouldAddedToTop()
        {
            MyNode<int> myFirstNode = new MyNode<int>(70);
            MyNode<int> MySecondNode = new MyNode<int>(30);
            MyNode<int> myThirdNode = new MyNode<int>(56);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add((INode<int>)myFirstNode);
            myLinkedList.Add((INode<int>)MySecondNode);
            myLinkedList.Add((INode<int>)myThirdNode);
            bool result = myLinkedList.head.Equals(myThirdNode) && myLinkedList.head.GetNext().Equals(MySecondNode) && myLinkedList.tail.Equals(myFirstNode);
            Assert.AreEqual(result, true);


        }
    }
}