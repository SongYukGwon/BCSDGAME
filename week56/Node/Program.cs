using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Room
{

}

//노드는 단순히 자료구조에선만 사용하는 것은 아니다.
// 자료구조라고 치면
// 자료를 보관해야 하므로
class Node<T>
{

    public T Data;

    //자신안에 자기자신을 또 가지는 형태로
    //되어 있는 크랠스들을 노드라고 할 수 가 있다.
    public Node<T> Next = null;
    public Node<T> Prve = null;

    public Node(T _Data)
    {
        Data = _Data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Node<int> Node1 = new Node<int>(10);
        Node<int> Node2 = new Node<int>(999);
        Node<int> Node3 = new Node<int>(362);

        Node1.Next = Node2;
        Node2.Next = Node3;

        Node<int> CurNode = Node1;
        while(null != CurNode)
        {
            Console.WriteLine(CurNode.Data);
            CurNode = CurNode.Next;
        }

    }
}

