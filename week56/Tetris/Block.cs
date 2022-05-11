using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum BLOCKDIR
{
    BD_T,
    BD_R,
    BD_B,
    BD_L,
    BD_MAX,
}
enum BLOCKTYPE
{
    BT_I, //짝대기
    BT_L, // 오른쪽갈고리 
    BT_J, // 왼쪽갈고리
    BT_Z, // 오른쪽 삐뚤이
    BT_S, // 왼쪽 삐뚤이
    BT_T, // 법규
    BT_O, // 네모
    BT_MAX,
}

partial class Block
{
    int X = 0;
    int Y = 0;
    string[][] Arr = null;

     Random NewRandom = new Random();
    List<List<string>> BlockData = new List<List<string>>();

    BLOCKTYPE CurBlockType = BLOCKTYPE.BT_T;
    BLOCKDIR CurDirType = BLOCKDIR.BD_T;
    TETRISGAMESCREEN Screen = null;
    ACCSCREEN AccScreen = null;
    public Block(TETRISGAMESCREEN _Screen, ACCSCREEN _AccScreen)
    {
        if(_Screen == null || null == _AccScreen)
        {
            return;
        }
        Screen = _Screen;
        AccScreen = _AccScreen;
        DataInit();
        //바꿀수 있는 인터페이스는 이것하나다.

        //인터페이스 분리원칙
        //자잘한 함수를 많이 만들고
        //그걸 조합해서 새기능을 만들어라.
        RandomBlockType();
        SettingBlock(CurBlockType, CurDirType);
    }

    public void RandomBlockType()
    {

        //int RandomIndex = NewRandom.Next((int)BLOCKTYPE.BT_I, (int)BLOCKTYPE.BT_MAX);
        int RandomIndex = (int)BLOCKTYPE.BT_I;
        CurBlockType = (BLOCKTYPE)RandomIndex;
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlcok[(int)_Type][(int)_Dir];
    }
    public void DownCheck()
    {

    }
    public void Down()
    {
        //아래를 확인하고
        //내려가다가 더이상 내려갈수 없으면
        //ACCSCREEN에 쌓이고
        if(true== DownCheck())
        {

        }
        //블록을 보내던것은 새로운것으로 바뀌면서 올라가야한다.
        Y+=1;
    }

    private void Input()
    {
        

        //키를 눌렀다.
        //Consle.ReadKey()가 리턴된다.

        if (false == Console.KeyAvailable)
        {
            return;
        }

        switch (Console.ReadKey().Key)
        {

            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.S:
                Down();
                break;
            case ConsoleKey.Q:
                //왼쪽으로 돌리기
                --CurDirType;
                if (0> CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_L;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.E:
                //오른쪽으로 돌리기
                ++CurDirType;
                if ( CurDirType == BLOCKDIR.BD_MAX)
                {
                    CurDirType = BLOCKDIR.BD_T;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            default:
                break;
        }
    }
    public void Move()
    {
        //내가 어떤 키든 눌렀을때만
        Input();

        for (int y = 0; y < 4; ++y)
        {
            for (int x = 0; x < 4; ++x)
            {
                if (Arr[y][x] == "□")
                {
                    continue;
                }

                Screen.SetBlock(Y + y, X + x, Arr[y][x]);
            }
        }
    }
    // protected BLOCKTYPE _TYPE
}

