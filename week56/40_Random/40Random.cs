using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _40Random
{
    class Program
    {
        //난수의 환상
        //프로그래밍에서 완전한 유사난수
        //난수란 존재하지 않는다.
        static int PrevValue;

        static int Func()
        {
            Random NewRandom = new Random();
            // 난수를 뽑아내고
            // NewRandom.Next() 0 ~42 억
            // NewRandom.Next() % 10
            // 10 == MaxValue

            while(true)
            {
                int Random = NewRandom.Next(0, 10);
                Console.WriteLine(Random);
            }

            return 1;
        }
    }
}