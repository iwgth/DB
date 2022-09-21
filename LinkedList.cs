using System;
using System.Collections.Generic;

namespace winf
{
    public class LinkedList<T> 
    {
        private class Node
        {
            public T data { get; set; }
            public Node next { get; set; }

            public Node(T nodeData)
            {
                data = nodeData;
                next = null;
            }
        }

        public int Count { get; private set; }
        private Node headNode;
        private Node currentNode;

        public LinkedList()
        {
            Count = 0;
            headNode = currentNode = null;
        }

        public void Push(T newData)
        {
            Node newNode = new Node(newData);
            newNode.next = null;

            if (currentNode == null)
            {
                headNode = newNode;
            }
            else
            {
                currentNode.next = newNode;
            }

            currentNode = newNode;
            this.Count++;
        }

        public T Remove(int index)
        {
            if (headNode == null)
                throw new InvalidOperationException("Stack is empty");
            else if (index >= Count)
                throw new InvalidOperationException("Index is incorrect");

            Node deletedNode = null;
            Node tempNode = headNode;
            Node previousNode = null;
            if (index == 0)
            {
                deletedNode = tempNode;
                headNode = tempNode.next;
                this.Count--;
            }
            else
            {
                for (int i = 0; tempNode != null; i++)
                {
                    if (i == index)
                    {
                        deletedNode = tempNode;
                        previousNode.next = tempNode.next;
                        this.Count--;
                    
                        break;
                    }

                    previousNode = tempNode;
                    tempNode = tempNode.next;
                }
            }

            return deletedNode.data;
        }


        public IEnumerator<T> GetEnumerator()
        {
            Node tempNode = headNode;
            while (tempNode != null)
            {
                yield return tempNode.data;
                tempNode = tempNode.next;
            }
        }
        public T this[int index]
        {
            get { 
                if (headNode == null)
                    throw new InvalidOperationException("Stack is empty");
                else if (index >= Count)
                    throw new InvalidOperationException("Index is incorrect");

                Node currentNode = headNode;
                for (int i = 0; i != index; i++)
                {
                    currentNode = currentNode.next;
                }

                return currentNode.data;
            }
        }
    }
}
