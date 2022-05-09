using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ItemInven
{
    public void Clear()
    {

    }
}

class SkillInven
{
    public void AllRemove()
    {

    }
}

class Zone
{
    public string Name = "None";
    //이렇게 하면 여러개랑 연결될 수 있다.
    public List<Zone> LinkZone = new List<Zone>();

    public Zone(string _Name)
    {
        Name = _Name;
    }
}

class Node<T>
{
    //보통 노드는 게임 맵에서 많이 사용됨.
    //몇개가 되던 상관이 없다.
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkList<T>
{
    public Node<T> First;
    
}

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //시퀀스 배열 list
            //시퀸스 노드형 LinkedList
            LinkedList<int> LList = new LinkedList<int>();

            //노드들을 관리해주는 애
            //LinkedList<int>;
            //LList.First
            //LList.Last()

            //처음에는 뭘로하든 의미없다
            LList.AddFirst(10);
            //LList.AddLast(10);
            LList.AddFirst(20);
            LList.AddLast(90);
            LList.AddFirst(30);
            LList.AddLast(50);
            LList.AddFirst(40);

            LinkedListNode<int> Cur = LList.First;

            Cur = Cur.Next;

            LList.AddAfter(Cur, 999);

            for(LinkedListNode<int> StartNode = LList.First; 
                null != StartNode;
                StartNode = StartNode.Next)
            {
                Console.WriteLine(StartNode.Value);
            }


  




        }
    }
}
