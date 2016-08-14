using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Lists {
    public class SLinkedListNode<T> : IComparable<SLinkedListNode<T>> where T : IComparable<T> {

        private T data;
        private SLinkedListNode<T> next;

        public SLinkedListNode() : this(default(T), null) { }
        public SLinkedListNode(T data) : this(data, null) { }
        public SLinkedListNode(T data, SLinkedListNode<T> next) {
            this.data = data;
            this.next = next;
        }

        public T Data {
            get { return data; }
            set { data = value; }
        }

        public SLinkedListNode<T> Next {
            get { return next; }
            set { next = value; }
        }


        public int CompareTo(SLinkedListNode<T> other) {
            if (other == null)
                return -1;
            return this.data.CompareTo(other.Data);
        }
    }
}
