using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//사용자 정의 자료형
interface QuestUnit
{
    //멤버변수가 안됨.


    //함수의 형태만 물려 줄 수 있는 문법
    //형태만 물려준다는 것은 선언만하고 정의를 하지 않는다는것.
    //무조건 public
    void Talk(QuestUnit _OtherUnit);

    void Event(QuestUnit _OtherUnit);
}

interface QuestUnit2
{
    //멤버변수가 안됨.


    //함수의 형태만 물려 줄 수 있는 문법
    //형태만 물려준다는 것은 선언만하고 정의를 하지 않는다는것.
    //무조건 public
    void Talk(QuestUnit _OtherUnit);

    void Event(QuestUnit _OtherUnit);
}


class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}

//인터페이스는 함수구현을 강제할 수 있다.
//인터페이스는 상속이라고 안하는 사람도 있다.
//포함의 개념이라고 볼수도 있다.
//인터페이스를 상속받았다고 치면
//
class Player: FightUnit, QuestUnit, QuestUnit2
{
    public void Event(QuestUnit _OtherUnit)
    {
        
    }

    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class NPC : FightUnit, QuestUnit, QuestUnit2
{
    public void Event(QuestUnit _OtherUnit)
    {
        
    }

    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNpc = new NPC();
        //인터페이스는 객체생성 불가
        //QuestUnit questUnit = new QuestUnit();

        QuestUnit NewQuestUnit = NewNpc;


        // 업캐스팅이 된다.
        NewPlayer.Talk(NewNpc);
        NewNpc.Talk(NewPlayer);
    }
}

