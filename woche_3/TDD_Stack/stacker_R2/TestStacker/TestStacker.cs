using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stacker;

namespace TestStacker
{


    [TestFixture]
    class TestStacker
    {
        private StackClass myStack;

        [SetUp]
        public void Init()
        {
             myStack = new StackClass();
        }

        //T1: Create a Stack and verify that IsEmpty is true.
        [Test]
        public void IsEmptyIsTrue()
        {
            Assert.IsTrue(myStack.IsEmpty);
        }


        //T2: Push a single object on the Stack 
        //    and verify that IsEmpty is false.

        [Test]
        public void PushOne()
        {
            myStack.Push("my first element");
            Assert.IsFalse(myStack.IsEmpty, "IsEmpty muss falsch sein");
        }


        //T3: Push a single object, 
        //    Pop the object, and verify 
        //    that IsEmpty is true.
        [Test]
        public void PopOne()
        {
            myStack.Push("first element");
           myStack.Pop();
            Assert.IsTrue(myStack.IsEmpty);
        }


        //T4: Push a single object, 
        //    remembering what it is; 
        //    Pop the object, and verify that 
        //    the two objects are equal.
        [Test]
        public void PushPopContentEqual()
        {

            int WasIchHabe = 1234;
            myStack.Push(WasIchHabe);
           
            int WasIchBekomme = (int)myStack.Pop();
            Assert.AreEqual(WasIchBekomme, WasIchHabe);
        }


        // T5: Push three objects, 
        // remembering what they are; 
        // Pop the second one, and verify that the third 
        // are removed in the correct order.


        [Test]
        public void PushPopMultipleElements()
        {
            string pushed1 = "1";
            myStack.Push(pushed1);
            string pushed2 = "2";
            myStack.Push(pushed2);
            string pushed3 = "3";
            myStack.Push(pushed3);

            string popped = (string)myStack.Pop();
            Assert.AreEqual(pushed3, popped);
            string popped2 = (string)myStack.Pop();
            Assert.AreEqual(pushed2, popped2);
            string popped3 = (string)myStack.Pop();
            Assert.AreEqual(pushed3, popped3);
        }


        // T6 Pop a Stack that has no elements.
        [Test]
        public void PopEmptyStack()
        {
            Assert.Throws<InvalidOperationException>(() => myStack.Pop());
        }
    }
}
