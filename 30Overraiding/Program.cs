using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected String Name = "None";
    protected int AT=5;
    protected int HP=5;

/*    public static virtual void Test()
    {
       //this가 없어서 안됨 
    }*/

    //이문법의 핵심은
    //자식에서 만약 나의 GetAt를 재구현하였다면
    //자식의 형태의 GetAT를 호출해라. -> virtual
    // 이걸 오버라이딩
    //다형성(동적바인딩)의 핵심 문법중에 하나
    // 같은 기능은 사용하지만 각자의 기능 사용법이 다를때
    public virtual int GetAT()
    {
        Console.WriteLine("FIGHTUNIT의 GetAT");
        return AT;
    }
    //생성자는 오버라이딩 못함.

    public virtual int TestVirtual(int v1, int v2)
    {
        return AT;
    }


    //프로퍼티는 Virtual
    public virtual int DMGAT
    {
        get
        {
            Console.WriteLine("FIGHTUNIT의 DMGAT");
            return AT;
        }
    }


    //업캐스팅
    // 상속의 개념을 지키기 위해서
    // 코드의 재활용성 - 코드를 적게치고 최대한의 효과를 누리고싶다.

    public void Damage(FightUnit _OtherFightUnit)
    {
        //각자 플레이어면 플레이어의 것
        // _OtherFightUnit.AT
        int AT = _OtherFightUnit.DMGAT;

        Console.WriteLine(_OtherFightUnit + "에게 " + AT + "만큼의 데이미지를 입습니다.");

        HP -= _OtherFightUnit.AT;
    }
}

class Player : FightUnit
{

    int ItemAt = 5;

    // 나는 부모클래스의 GetAT를 재구현했다. - override
    public override int GetAT()
    {
        Console.WriteLine("Player의 GetAT");
        return AT + ItemAt;
    }

    public Player(String _Name)
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public override int DMGAT
    {
        get{
            Console.WriteLine("Monster의 DMGAT");
            return AT + MonsterLv;
        }
    }

    public Monster(String _Name)
    {
        Name = _Name;
    }

}

namespace _30Overraiding
{
    class Program
    {
        static void Main(string[] args)
        {
            //기본생성자를 못씀 안만들어서
            //생성자를 정의함으로써 강제할수 있음
            Player NewPlayer = new Player("플레이어");

            Monster NewMonster = new Monster("몬스터");

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
