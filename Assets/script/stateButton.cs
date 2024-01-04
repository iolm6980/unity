using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateButton : MonoBehaviour
{

    public void HPUp(){
        if (Player.point != 0)
        {
            Player.maxHp += 1;
            Player.point -= 1;
        }
    }

    public void STRUp()
    {
        if (Player.point != 0)
        {
            Player.str += 1;
            Player.point -= 1;
        }

    }

    public void DEXUp()
    {
        if (Player.point != 0)
        {
            Player.dex += 1;
            Player.point -= 1;
        }
    }

    public void LUKUp()
    {
        if (Player.point != 0)
        {
            Player.luk += 1;
            Player.point -= 1;
        }
    }
}
