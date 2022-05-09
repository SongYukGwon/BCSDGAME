using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자료구조
//자료구조를 직접 만들어 보는건 게임프로그래머의 언어와 같은 기초소양
//자료구조는 컴퓨터 과학에서 효율적인 접근 및 수저이을 가능케하는
// 자료의 조직, 관리, 저장을 의미

// 

class MyDataStruct<T>{
    
    // 넣는다. ()

    public void Push(T _Data) 
    { 

        //사이즈가 오버하면 사이즈를 늘린다.


    }
    
    // 탐색. ()

    public void Find(T _Data) 
    { 

    }
    
    // 확장한다. () 

    public void Ex(int _Size) 
    {

    }
}


namespace _38DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자료구조라는 건
            // int 10
            // 0 1 2 3 4 5 6 7 8 9

            // 자료구조에는 다음의 구조나 인터페이스를 지원한다.
            // 함수로 표현한다.
            // 넣는다. ()
            // 탐색. ()
            // 확장한다. () (배열은 새로 만들어야됨)

            // 



            // 자료구조에는 보통 컨테이너라는 용어를 사용한다.
            // 시퀸스 컨테이너 자료가 연속적으로 쌓여 있는 것.
            // List (vector C#에는 없음)
            // 연관 컨테이너 자료간에 특별한 연관이 있다. 오름차순 내림차순 등
            // SortedList, Dictionary(해쉬맵), map(c++)
            // 어뎁터 컨테이너(컨테이너에서 기능을 제한한것)로 분류됨.
            // stack queue


            //데이터의 메모리 구조는 배열과 노드형이 대부분


            //자료구조 이다.
            int[] Arr = new int[10];

            //Arr.Length

            Arr[0] = 0;
            Arr[1] = 1;

            int[] Arr2 = Arr;

            Arr = new int[15];

            MyDataStruct<int> MDS = new MyDataStruct<int>();

            //100 넣어
            MDS.Push(100);

            //50 찾아줘
            MDS.Find(50);

            //MDS.EX -> 요즘은 확장이 자동으로 이루어짐.
        }
    }
}
