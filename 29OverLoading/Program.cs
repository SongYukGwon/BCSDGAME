using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}

class Player
{
    

    //물리방어
    int AttDef=5;
    //불방어
    int FireDef=5;
    //물방어
    int IceDef=5;

    int HP = 100;

    //생성자 오버로딩
    public Player()
    {

    }

    public Player(int _HP)
    {
        HP = _HP;
    }

    static void Func(int _Value)
    {

    }

    //함수오버로딩
    //매개변수형태,개수에따라 함수의 인식이 달라짐
    //
    public void Damage(int _Damage)
    {
        HP -= _Damage;
    }

    public void Damage(float _Damage)
    {

    }


    public void Damage(float _Damage, int aaa)
    {

    }

    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch(_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }
    }
}

namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(100);


            NewPlayer.Damage(100);
            NewPlayer.Damage(100, DMGTYPE.FIREDMG);
            NewPlayer.Damage(100, DMGTYPE.ICEDMG);
        }
    }
}
