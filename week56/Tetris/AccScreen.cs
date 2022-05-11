using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ACCSCREEN : TETRISGAMESCREEN
{
    TETRISGAMESCREEN Parent;
    //부모님의 생성자를 호출할 수 있다.
    public ACCSCREEN(TETRISGAMESCREEN _Parent) : base(_Parent.X, _Parent.Y-2, false)
    {
        Parent = _Parent;
    }

    public override void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                    Parent.SetBlock(y+1, x, BlockList[y][x]);
            }
            Console.WriteLine();
        }
    }

    public void DestroyCheck()
    {
        for (int y = (BlockList.Count - 1); y >= 0; y--)
        {
            bool IsDestory = true;
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                if ("□" == BlockList[y][x])
                {
                    IsDestory = false;
                }
            }
            if (true == IsDestory)
            {
                //내려앉히는 작업
                List<string> NewLine = new List<string>();

                for (int i = 0; i < X; i++)
                {
                    NewLine.Add("□");
                }

                BlockList.RemoveAt(BlockList.Count - 1);
                BlockList.Insert(0, NewLine);
                y = BlockList.Count - 1;
            }
        }


    }
}