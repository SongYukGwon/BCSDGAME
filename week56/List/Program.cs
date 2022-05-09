using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{

}

class MyList<T>
{
    int[] Arr = new int[0];
    int Capa = 00;
    int Count = 0;

    public void Add(T a)
    {
        if (Count + 1 >= Capa)
        {
            Capa += 4;
        }
    }
}

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //<>가 있으면 Generic class
            //이미 만들어 진것을 활용하는 것.
            //배열형, 시퀸스
            // 메모리구조는 배열
            // 내가 관리해달라고 요청하는것이 매번 바뀌는것
            // 제네릭 클래스 : 관리해주는 것이 매번 바꿀수 있는 것.
            MyList<int> NewInt = new MyList<int>();

            NewInt.Add(100);


            List<int> NewList = new List<int>();

            //자료 : 넣어준 int

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((NewList.Count + 1).ToString() + " Add");
                Console.WriteLine("Capa :" + NewList.Capacity); //배열의 크기
                Console.WriteLine("Count : " + NewList.Count); // 자료의 크기
                NewList.Add(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Con");

            //탐색에는 유리하지 않은 자료구조라고 본다.
            //인덱스로 표현할 수 있다면 탐색에 가장 유리한 자료구조
            // 내부에 자료가 있는지 확인
            if(NewList.Contains(8))
            {
                Console.WriteLine("내부에 8이 있습니다.");
            }


            if (NewList.Contains(99999))
            {
                Console.WriteLine("내부에 99999이 있습니다.");
            }
            else
                Console.WriteLine("없습니다.");

            // 인덱서 혹은 연산자 겹지정이라고 부름
            Console.WriteLine(NewList[5]);

            NewList.Remove(10); //10이 있다면 지운다. 없으면 안지움
            NewList.Remove(5); //5이 있다면 지운다. 없으면 안지움


            NewList.RemoveAt(1); //1번째를 지운다.

            //다른 리스트 혹은 배열과 비교해서 중복되는 것을 지운다.
            //NewList.RemoveAll();

            NewList.RemoveRange(0, 2); //0~2번째꺼 지워라

            //배열로 바꿔서 반환
            int[] Arr = NewList.ToArray();

            //넣는 함수
            //찾는 함수
            //지우는 함수

            //OutofRange
            // 자료의 개수로 판단하지 배열의 크기는 중요하지 않다.
            //Console.WriteLine(NewList[999]);

            List<Item> NewList2 = new List<Item>();


        }
    }
}
