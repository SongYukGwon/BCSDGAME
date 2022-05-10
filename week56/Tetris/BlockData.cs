using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Block
{
    //모든 블로그이 모양을 관리하려면
    // 자료구조

    //2차원배열안에 2차원형식의 string이 존재
    List<List<string[][]>> AllBlcok = new List<List<string[][]>>();

    void DataInit()
    {
        for (int BT = 0; BT < (int)BLOCKTYPE.BT_MAX; ++BT)
        {
            AllBlcok.Add(new List<string[][]>());
            for (int BD = 0; BD < (int)BLOCKDIR.BD_MAX; ++BD)
            {
                AllBlcok[BT].Add(null);
            }
        }

        #region S
        {
            //짝대기의 T
            AllBlcok[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_T] = new string[][]
            {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
        };

            //짝대기의 R
            AllBlcok[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_R] = new string[][]
            {
            new string[] { "■", "■", "■", "■" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

            AllBlcok[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_B] = new string[][]
            {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
        };

            AllBlcok[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_L] = new string[][]
            {
            new string[] { "■", "■", "■", "■" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        }
        #endregion

        #region T
        {
            AllBlcok[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_T] = new string[][]
            {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

            AllBlcok[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_R] = new string[][]
            {
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
         };

            AllBlcok[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_B] = new string[][]
            {
            new string[] { "□", "□", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

            AllBlcok[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_L] = new string[][]
            {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        }
        #endregion

        #region J

        AllBlcok[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_T] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_R] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_B] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_L] = new string[][]  {
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion J

        #region L

        AllBlcok[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_T] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_R] = new string[][]  {
        new string[] { "■", "■", "■", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_B] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_L] = new string[][]  {
        new string[] { "□", "□", "■", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion L

        #region S

        AllBlcok[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_T] = new string[][]  {
        new string[] { "□", "■", "■", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_R] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_B] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_L] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion S

        #region Z

        AllBlcok[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_T] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_R] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_B] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_L] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion Z

        #region O

        AllBlcok[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_T] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_R] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_B] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlcok[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_L] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion O
    }
}

