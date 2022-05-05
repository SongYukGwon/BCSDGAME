using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using _28Partial; //선언함으로써 생략이 가능함.

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();//불편함
        //Player NewPlayer2 = new Player(); //namespace 선언을 안해도됨 using
        NewPlayer.Damage();
        NewPlayer.EventStart();
        NewPlayer.Func();

    }
}

