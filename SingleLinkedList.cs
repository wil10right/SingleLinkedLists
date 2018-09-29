using System;

namespace SingleLinkedLists
{
    public class SingleLinkedList
    {
        public SllNode Head;
        public void Sll()
        {
            this.Head = null;
        }

        public void Add(int value)
        {
            SllNode newNode = new SllNode(value);
            if(this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }
        public void Remove(SllNode deadNode)
        {
            SllNode runner = Head;
            while(runner.Next.Value != deadNode.Value)
            {
                runner = runner.Next;
            }
            SllNode kill = runner.Next;
            // runner.Next.Next = null;
            runner.Next = runner.Next.Next;
            kill.Next = null;
        }

        public void PrintValues()
        {
            SllNode runner = Head;
            while(runner.Next != null)
            {
                System.Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }

        public SllNode Find(int waldo)
        {
            SllNode runner = Head;
            while(runner.Next.Value != waldo)
            {
                runner = runner.Next;
            }
            return runner.Next;
        }
    }
}