using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            TETRISGAMESCREEN NewSC = new TETRISGAMESCREEN(8, 15, true);
            ACCSCREEN NewASC = new ACCSCREEN(NewSC);

            Block NewBlock = new Block(NewSC, NewASC);

            while(true)
            {
                for (int i = 0; i < 30000000; i++)
                {
                    int a = 0;
                }

                Console.Clear();
                NewSC.Render();
                NewSC.Clear();
                // 두개의 프레임을 사용하면 편함.
                NewASC.DestroyCheck();
                NewSC.Clear();
                NewBlock.Move();
            }



           
        }
    }


}
