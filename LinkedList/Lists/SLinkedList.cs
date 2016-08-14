using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Lists {

    
    public class SLinkedList<T> : IEnumerable<T> where T : IComparable<T> {

        SLinkedListNode<T> header;
        public SLinkedList() {

        }

        

        public SLinkedListNode<T> Header {
            get { return header; }
            set { header = value; }
        }


        private int size;

        public int Size {
            get { return size; }
            set { size = value; }
        }

        public bool IsEmpty {
            get { return size == 0; }
        }


        public void Push(T data) {
            var node = new SLinkedListNode<T>(data);
            if (header == null)
                header = node;
            else {
                node.Next = header;
                header = node;
            }
            size++;
        }

        public T Pop() {
            if (IsEmpty) {
                throw new IndexOutOfRangeException("the list is empty.");
            }
            var result = header;
            header = header.Next;
            size--;
            return result.Data;
        }


        public override string ToString() {
            StringBuilder os = new StringBuilder("[");
            
            if (IsEmpty)
                os.Append("Empty List.");
            else {
                foreach (T d in this) {
                    os.Append(d.ToString()+",");
                }
              os=  os.Remove(os.Length - 1, 1);
            }

            return os.Append("]").ToString();
        }

        public IEnumerator<T> GetEnumerator() {
            var current = header;
            while (current != null) {
                var da = current.Data;
                current = current.Next;
                yield return da;
                
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();

        }
    }
}
