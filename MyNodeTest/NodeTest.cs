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
        public void Given3NumbersWhenLinkedShouldPassToLinkedList()
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
        public void Given3NumbersWhenAddedToLinkedListShouldAddedToTop()
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
        ///<summary>
        ///Ability to create Linked List by appending 30 and 70 to 56
        ///</summary>
        [Test]
    public void Given3NumbersWhenAppendedToLinkedListShouldAddedToLast()
        {
            MyNode<int> myFirstNode = new MyNode<int>(56);
            MyNode<int> mySecondNode = new MyNode<int>(30);
            MyNode<int> myThirdNode = new MyNode<int>(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add((INode<int>)myFirstNode);
            myLinkedList.append((INode<int>)mySecondNode);
            myLinkedList.append((INode<int>)myThirdNode);
            bool result = myLinkedList.head.Equals(myFirstNode) && myLinkedList.head.GetNext().Equals(mySecondNode) && myLinkedList.tail.Equals(myThirdNode);
            Assert.AreEqual(result,false);

        }
        /// <summary>
        /// Ability to Insert30 Between 56 and 70
        /// </summary>
        [Test]
    public void Given3NumbersWhenInsertingSecondInBetweenShouldPassLinkedListResult()
        {
            MyNode<int> myFirstNode = new MyNode<int>(56);
            MyNode<int> mySecondNode = new MyNode<int>(30);
            MyNode<int> myThirdNode = new MyNode<int>(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.append((INode<int>)myFirstNode);
            myLinkedList.append((INode<int>)myThirdNode);
            myLinkedList.insert((INode<int>)myFirstNode, (INode<int>)mySecondNode);
            bool result = myLinkedList.head.Equals(myFirstNode) &&
                    myLinkedList.head.GetNext().Equals(mySecondNode) &&
                    myLinkedList.tail.Equals(myThirdNode);
            Assert.AreEqual(result,true);

        }
        /// <summary>
        /// Ability to delete the first  element in the LinkedList of sequence 56->30->70
        /// </summary>
        [Test]
        public void Given3FirstElementWhenDeletedShouldPassLinkedListResult()
        {
            MyNode<int> myFirstNode = new MyNode<int>(56);
            MyNode<int> mySecondNode = new MyNode<int>(30);
            MyNode<int> myThirdNode = new MyNode<int>(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.append((INode<int>)myFirstNode);
            myLinkedList.append((INode<int>)mySecondNode);
            myLinkedList.append((INode<int>)myThirdNode);
            myLinkedList.pop();
            bool result = myLinkedList.head.Equals(mySecondNode) &&
                    myLinkedList.tail.Equals(myThirdNode);
            Assert.AreEqual(result,result);
        }
        /// <summary>
        /// Ability to delete the last  element in the LinkedList of sequence 56->30->70
        /// </summary>
        [Test]
    public void GivenLastElementWhenDeletedShouldPassLinkedListResult()
        {
            MyNode<int> myFirstNode = new MyNode<int>(56);
            MyNode<int> mySecondNode = new MyNode<int>(30);
            MyNode<int> myThirdNode = new MyNode<int>(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.append((INode<int>)myFirstNode);
            myLinkedList.append((INode<int>)mySecondNode);
            myLinkedList.append((INode<int>)myThirdNode);
            myLinkedList.popLast();

            bool result = myLinkedList.head.Equals(myFirstNode) &&
                    myLinkedList.tail.Equals(mySecondNode);
            Assert.AreEqual(result,true);
        }
        /// <summary>
        ///  Search the given Node
        /// </summary>
        [Test]
    public void Given3ElementCheckPerticularElementPresentOrNot()
        {
            MyNode<int> firstNode = new MyNode<int>(56);
            MyNode<int> secondNode = new MyNode<int>(30);
            MyNode<int> thirdNode = new MyNode<int>(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.append((INode<int>)firstNode);
            myLinkedList.append((INode<int>)secondNode);
            myLinkedList.append((INode<int>)thirdNode);
            bool result = myLinkedList.searchNode((INode<int>)secondNode);
            Assert.AreEqual(true, result);

        }
    }
}