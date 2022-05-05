using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    //객체지향의 캡슐화 은닉화를 대표하는 문법.
    // 접근제한 지정자.
    // 접근제한 지정자라를 문법을 사용하지 않으면
    // 기본적으로 외부에는 보여지지 않음.
    // 모두에게 공개하는 것은 남들이 마음대로 사용하게끔 함으로써 에러가 터진다.
   


    public int ATT; //모두에게 보여짐
    protected int HP; //자식에게만 보여짐
    private int MP; //자신에게만 보여짐

    public void Fight() //반환값 형식 이전에 접근제한지정자를 사용
    {
        Console.WriteLine("싸운다.");
    }
}

namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //만들어진 객체의 내용을 사용하기 위해서는
            //객체의 이름.을 사용

            //잘못쓰기도 힘들게 만들어놓는것이 좋다.



            NewPlayer.ATT = 100;
            //public으로 선언되어있어서 클래스의 외부에서 변경가능.

            NewPlayer.Fight();
           
        }
    }
}
