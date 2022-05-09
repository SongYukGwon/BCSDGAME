using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GTest<T>
{
    public T Data;
}

namespace DataStructEx
{
    class Program
    {
        static void Main(string[] args)
        {
            GTest<GTest<int>> New;

            Dictionary<string, List<int>> NewDic;

            Dictionary<string, int> DicTest = new Dictionary<string, int>();
            //왠만하면 그냥 순회방식을 사용해라.
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkkedListTest = new LinkedList<int>();

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);


            LinkkedListTest.AddLast(1);
            LinkkedListTest.AddLast(2);
            LinkkedListTest.AddLast(3);
            LinkkedListTest.AddLast(4);
            LinkkedListTest.AddLast(5);

            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            
            //var은 어떤 타입이든 된다.
            //그 시점에서 가장 알맞은 자료형이 된다.
            foreach(var item in ListTest)
            {
                Console.WriteLine(item);
            }
            //foreach는 자동적으로 반복하는 문장으로서
            //in을 통해서 각 배열이든 딕셔너리든 리스트든
            // 내부의 자료를 그대로 순회할수 있게 처리해 준다.
            // in은 자료구조에서 빼온다 라고만 이해해도 된다.
            // 그대신 루프에 대한 제한을 하기가 어렵다.
            foreach (var item in LinkkedListTest)
            {
                if(item == 3)
                {
                    break;
                }
                Console.WriteLine(item);
            }

            foreach (var item in DicTest)
            {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<string, int> item in DicTest)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
