﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TETRISGAMESCREEN

{
    // 블록을 표현하는부분
    // 메모리를 더 할당해서 정보를 분리하면
    // 대부분의 문제는 해결이 된다.
    List<List<string>> BlockList = new List<List<string>>();


    public void SetBlock(int _y, int _x, string _Type)
    {
        //회전만 봐
        BlockList[_y][_x] = _Type;
    }

    public void Clear()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                if (y == 0 || y == BlockList.Count-1)
                {
                    BlockList[y][x] = "▣";
                    continue;
                }
                BlockList[y][x] = "□";
            }
        }
    }

    public void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                Console.Write(BlockList[y][x]);
            }
            Console.WriteLine();
        }
    }
    public TETRISGAMESCREEN(int _X, int _Y)
    {
        //0,0을 넣어주는것 방지

        for (int y = 0; y < _Y; y++)
        {
            BlockList.Add(new List<string>());
            for (int x = 0; x < _X; x++)
            {
                BlockList[y].Add("□");
            }
        }

        for (int i = 0; i < BlockList[0].Count; i++)
        {
            BlockList[0][i] = "▣";
        }

        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
        {
            BlockList[BlockList.Count - 1][i] = "▣";
        }

    }
}