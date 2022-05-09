using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//협업을 할때 클래스 이름이 겹쳐서 에러나는것을 방지하기위해ㅣ
//namespace라는 것으로 클래스를 묶는다.

//namespace에 접근할때는 namespcae.클래스명 으로 한다.
//네임스페이스는 개념의 표현이라기보다 개념의 분류



//A프로그래머
//HP포션

//B프로그래머
//MP포션



//A프로그래머
namespace APRO
{
    class Potion //HP포션 클래스
    {

    }
}

//B프로그래머
namespace BPRO
{
    class Potion //MP포션 클래스
    {

    }
}
namespace _02NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
