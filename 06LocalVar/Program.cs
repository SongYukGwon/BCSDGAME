using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{

    //멤버변수 -> 클래스 내부에 있는 변수
    int Att;
    int Hp;

    void Figh0t()
    {
        Console.WriteLine("플레이어가 싸운다.");
    }
}

namespace _06LocalVar
{
    //C#은 객체지향언어 클래스밖에 모름
    // 프로그램의 시작도 클래스안에 있다.

    //밑의 클래스는프로그램을 시작한다는 것.
    class Program
    {

        //시작함수
        static void Main(string[] args)
        {

           

            // 지역변수 -> 함수안에 있는 변수
            // 지역변수는 함수내에서만 쓸수 있다.
            // 선언하는 순간 메모리를 차지한다.
            
            int ATT = 0;
            ATT = 50;


            //객체화라고 하는 굉장히 중요한 작ㄷ업.
            // 클래스는 설계도 이다.

            //Player의 설계도를 통해 새로운 Player를 만든다.
            //NewPlayer라는 이름을 가진 Player를 만든다.


            Player NewPlayer = new Player();
            Player NewPlayer2 = new Player();
        }
    }
}
