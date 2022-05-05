using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //접근제한 지정자를 선언하지 않으면 default로 선언되는데
    // 기본은 private이다.
    // 일반적으로 외부에서 접근하지 못하게 한느것이 기본적으로 좋다.

    // 공격력은 공격력 그자체만으로 의미가 있지만
    // 의미가 명확해지지는 않는다.
    // 공격력이 증가한다.


    private int LV = 1;
    private int AT = 10;
    private int HP = 100;


    //프렐이어의 레벨이 얼마인지 알고 싶다.
    //리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용
    //외부에 알려줘야 하기 때문에 알려주는 순간 함수가 끝남
    //return이라는 문장을 사용하면 함수는 무조건 종료한다.
    public int GetLv()
    {

        //return 이후의 코드는 무시된다.
        return LV;

        LV = 200;
    }

    public void SetHP(int Hp)
    {

        //내가 HP가 0이되는 순간만 체크할수잇으며
        //내가 정지되는 것도 지켜볼수 있다.
        // 가장 큰 핵심은 디버깅 되는것.
        // 매번 수정되는 곳에서 확인할 필요 없다.

        HP = Hp;
    }

    // 상태라는 것은 멤버변수
    //어떤 상태가 변화하는 순간
    // 어떻게 처리하는 것은 나의 마음
    public void LVUP()
    {
        AT = 100;
        HP = 1000;
    }

    //함수는 보통 선언과 내용으로 나뉜다.


    //void (리턴값) Func[이름 혹은 식별자]()[인자값]
    //int Dmg는 외부에서 값을 받아서 함수에서 사용하겠다.
    //받는 값은 여러개가 될 수 있음.

    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    public int DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }

    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }

    //함수란 보통 클래스 외부와의 소통을 위해서 만든다.
    //만든건 아니다.

}

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // 그래서 필요한 것은 함수

            //뭔가 증가하는 코드를 쳐줘야 하는데
            //NewPlayer.Hp = NewPlayer.HP + 1;

            
            

            NewPlayer.SetHP(0);
            NewPlayer.LVUP();


            // 외부의 값을 받아서 객체의 내부의 상태를
            //변화시키기 위해서 함수를선언하는 경우가 많음.
            NewPlayer.SetHP(1000);
            NewPlayer.Damage1(100);
            NewPlayer.Damage2(100, 10);

            Console.WriteLine(NewPlayer.GetLv());
            Console.WriteLine(NewPlayer.DamageToHPReturn(10));
        }
    }
}
