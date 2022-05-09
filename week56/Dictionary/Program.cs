using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
{
    public Dictionary<string, int> m_NewDic = new Dictionary<string, int>();

    public void Add(string _Name, int Value)
    {
        if (true == m_NewDic.ContainsKey(_Name))
        {
            return;
        }

        m_NewDic.Add(_Name, Value);
    }

    public void Print(string _Name)
    {
        if (false == m_NewDic.ContainsKey(_Name))
        {
            return;
        }

        Console.WriteLine(m_NewDic[_Name]);
    }
}

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //연관 복합
            //string 키
            //int 밸류(데이터)
            Dictionary<string, int> NewDic = new Dictionary<string, int>();

            if (false == NewDic.ContainsKey("일이에요"))
            {
                NewDic.Add("일이에요", 1);
            }
            NewDic.Add("이에요", 2);
            NewDic.Add("뭘까요", 123124);
            //같은 키를 두번 넣어주는 것은 불가능하다.
            //딕셔너리는 같은 키를 넣어줄 일이 있다면
            // 사용하지 마라.
            NewDic.Add("재밌다", 123124);

            string Key = "뭘까요";
            //인덱서
            //연산자 겹지정
            //딕셔너리는 찾는다는 작업에 특화된 녀석.

            NewDic.Remove("재밌다");

            if (NewDic.ContainsKey(Key))
            {
                Console.WriteLine(NewDic[Key]);
            }

            //딕셔너리는 예외처리때문에 다른클래스로 감싸는 것이 좋다,
            Test NewTest = new Test();

            NewTest.Add("하하하", 123);
            NewTest.Add("하하하", 456);
            NewTest.Add("하하하", 7899123);
            NewTest.Add("키입니다", 999);

            NewTest.Print("키입니다");
            NewTest.Print("하하하");


        }
    }
}
