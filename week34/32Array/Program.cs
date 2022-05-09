using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    class Item
    {
        public string Name;
        public int AT;
        public int DF;
    }

    static void Main(string[] args)
    {
        //배열은 기본적으로 자료형이라고 할 수 있으며
        //기본자료형에 속한다.
        // 선언 방식은 어떤 자료형 []


        // 모든 자료형은 구조체 아니면 클래스에 가까운데,
        // 기본 자료형도 마찬가지이다.

        // [0][0][0][0][0][0][0][0][0][0]
        // int가 10개 생겼다.
        int[] ArrInt = new int[10];

        //ArrInt는 int의 배열형
        //ArrInt[0]은 무슨 자료형 ? int형

        // c#에서는 모든 자료형은 클래스 혹은 구조체에 가깝다.
        // -> 멤버변수와 멤버 함수가 있다.

        //

        for(int i = 0; i<ArrInt.Length; i++)
        {
            Console.WriteLine(ArrInt[i]);   
        }
        //배열을 언제 사용하느냐?
        
        //클래스도 자료형이 될 수 있다.
        //기본자료형과는 다른게 아이템이라는 참조형을 담을수 있는 공간이 10개 생김
        //아이템이라는 메모리를 가리킬 수 있는 참조형이 10개 생김
        //선언 된것이 아님.
        Item[] ArrItem = new Item[10];

        for(int i =0; i<ArrItem.Length; i++)
        {
            //클래스는 배열을 일일이 new로 선언해줘야함.
            ArrItem[i] = new Item();
        }

        ArrItem[0].Name = "철검";
        ArrItem[1].Name = "전설의검";
        ArrItem[2].Name = "멋진갑옷";
        ArrItem[3].Name = "ㅇㅇㅇㅇ";


        for(int i =0; i<ArrItem.Length; i++)
        {
            Console.WriteLine(ArrItem[i].Name);
        }
        // ************
        // ************
        // ************

        

    }
}

