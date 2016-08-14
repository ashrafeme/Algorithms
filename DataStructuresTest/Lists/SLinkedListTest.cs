

using System;
using Xunit;

namespace DataStructuresTest.Lists {
    
    public class SLinkedListTest {


        public SLinkedListTest() {
            // Arrange the 
        }

        [Fact]
        public void LinkedListSize_ShouldBeZero() {
            // arrange 
          var oslist = new DataStructures.Lists.SLinkedList<int>();

            Assert.Equal(0, oslist.Size);

        }

        [Fact]
        public void LinkedList_Add_NewNodeSize_ShouldBeOne() {
            // arrange 
            var oslist = new DataStructures.Lists.SLinkedList<int>();
            oslist.Push(3);
            Assert.Equal(1, oslist.Size);
        }
        [Fact]
        public void LinkedList_Add_2NewNode_DisplayData2() {

            var oslist = new DataStructures.Lists.SLinkedList<int>();
            oslist.Push(3);
            oslist.Push(7);

            Assert.Equal(7, oslist.Header.Data);
        }

        [Fact]
        public void LinkedList_DisplayList_Empty() {

            var oslist = new DataStructures.Lists.SLinkedList<int>();
            Assert.Equal("[Empty List.]", oslist.ToString());
        }

        [Fact]
        public void LinkedList_DisplayList_2Value() {

            var oslist = new DataStructures.Lists.SLinkedList<int>();
            oslist.Push(3);
            oslist.Push(4);
            oslist.Push(7);
            Assert.Equal("[7,4,3]", oslist.ToString());
        }

        [Fact]
        public void LinkedList_Remove_Empty() {

            var oslist = new DataStructures.Lists.SLinkedList<int>();
            //var node = ;
            var exception = Record.Exception(() => oslist.Pop());
            Assert.NotNull(exception);
            Assert.IsType<IndexOutOfRangeException>(exception);

           // Assert.Throws<>
        }

        [Fact]
        public void LinkedList_Remove_WithData() {

            var oslist = new DataStructures.Lists.SLinkedList<int>();
            oslist.Push(3);
            oslist.Push(7);
            Assert.Equal(2, oslist.Size);
            var da = oslist.Pop();
            Assert.Equal(7, da);
            Assert.Equal(1, oslist.Size);

             da = oslist.Pop();
            Assert.Equal(3, da);
            Assert.Equal(true, oslist.IsEmpty);


            var exception = Record.Exception(() => oslist.Pop());
            Assert.NotNull(exception);
            Assert.IsType<IndexOutOfRangeException>(exception);
        }


    }
}
