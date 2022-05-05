using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{

    int HP = 100;

    void Damage( int _HP)
    {
        HP = HP - 10;
    }

    public int Plus(int _Left, int _Right)
    {
        return _Left + _Right;
    }

    bool ReturnTrue()
    {
        return true;
    }
}


namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player;

            int Result = 0;
            int Left = 7;
            int Right = 3;

            // = 대입연산자. 함수에서 리턴된값이나 연산된 값을
            //받을 수 있는 변수에 넣는것.
            // 리터럴 값일때도 받을 수 있다.


            //산술연산자.
            //리턴값이라는 것은 외부에 연산값이나 객체 상태값
            //=연산자가 있다면 오른쪽부터 실행됨
            // 연산자의 우선순위 대입연산자와 산술연산자는 계산연산자가 먼제된다.
            // 산술연산자는 */%가 먼저되고
            // +-가 된다.
            Result = NewPlayer.Plus(Left, Right); //더하기
            Result = Left - Right; // 빼기
            Result = Left * Right; // 곱하기
            Result = Left / Right; // 나누기
            Result = Left % Right; // 나머지

            Result = (Left + Right) * 10;
            //()로 우선순위 지정 가능


            //나누기와 나머지에 0을 넣으면 zerodivision에러 발생
            //주의바람

            //연산자는 함수와 비슷하다.

            //비교 연산자
            //논리형으로 리턴이 됨.
            //true(참) 나 false(거짓)로 리턴가능

           

            bool Bresult = true;
            Bresult = false;

            Bresult = Left > Right; // Left가 right보다큰가?
            Bresult = Left < Right;// Left가 right보다 작은가?
            Bresult = Left <= Right;// Left가 right보다 작거나 같은가?
            Bresult = Left >= Right;// Left가right보다 크거나 같은가?
            Bresult = Left == Right;// Left가 right보다 같은가?
            Bresult = Left != Right;// Left가 right보다 다른가?
            //각각의 결과가 맞는지 틀린지에따라 true false 리턴


            //둘다 맞거나 둘다 틀리거나 둘중 하나이상 맞거나 등
            //Bool 논리 연산자
            Bresult = true && false; //and //둘다 true 면 true
            Bresult = true || false; // or //둘중 하나 true면 true
            Bresult = true ^ false; // xor //둘이 서로 다르면 true
            Bresult = !true; // not  true면 false false면 true

            //축약연산자
            Result = 0;
            Result = Result + 10;
            Result += 10;

            Result /= 10;
            Result *= 10;

        }


    }
}
