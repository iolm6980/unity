using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Event : MonoBehaviour
{
    public int pubCount;
    public void goblinBattle()
    {

        int w = Random.Range(0, 101);
        if (w > Rate.rate)
        {
            Player.currentHp -= 30;
            SceneManager.LoadScene("0 - 1");
        }
        else
        {
            Player.currentExp += 50;
            SceneManager.LoadScene("0 - 0");
        }
    }
    public void golemBattle()
    {

        int w = Random.Range(0, 101);
        if (w > Rate.rate)
        {
            Player.currentHp -= 50;
            SceneManager.LoadScene("2 - 1");
        }
        else
        {
            Player.currentExp += 80;
            SceneManager.LoadScene("2 - 0");
        }
    }

    public void Cemetry()
    {
        int w = Random.Range(0, 101);
        if (w < Rate.rate)
        {
            Player.gold += 500;
            SceneManager.LoadScene("4 - 1");
        }
        else
        {
            Player.str -= 3;
            SceneManager.LoadScene("4 - 0");
        }
    }

    public void skeletonBattle()
    {

        int w = Random.Range(0, 101);
        if (w > Rate.rate)
        {
            Player.currentHp -= 80;
            SceneManager.LoadScene("3 - 1");
        }
        else
        {
            Player.currentExp += 100;
            SceneManager.LoadScene("3 - 0");
        }
    }


    public void HPrecovery()
    {
        if (Player.gold >= 100)
        {
            Player.currentHp = Player.maxHp;
            Player.gold -= 100;
            SceneManager.LoadScene("1 - 1");
        }
    }

    public void pub()
    {

        if (Player.gold >= 200)
        {
            Player.currentHp = Player.maxHp;

            int w = Random.Range(0, 101);
            if (w > 80)
            {
                pubCount = 1;
                SceneManager.LoadScene("5 - 1");
            }
            else
            {
                Player.currentHp -= 50;
                SceneManager.LoadScene("5 - 0");
            }
            
        }
    }

    public void plunder()
    {
        int w = Random.Range(0, 101);
        if (w > 50)
        {
            Player.currentHp -= 50;
            Player.gold -= 300;
            SceneManager.LoadScene("6 - 1");
        }
        else
        {
            Player.currentExp += 50;
            Player.gold += 300;
            SceneManager.LoadScene("6 - 0");
        }
    }

    public void fire()
    {
        SceneManager.LoadScene("7 - 0");
    }
    public void fire2()
    {
        Player.gold = 0;
        SceneManager.LoadScene("7 - 0 - 0");
    }

    public void NpcPlunder()
    {
        SceneManager.LoadScene("8 - 0");
    }
    public void NpcPlunderY()
    {
        SceneManager.LoadScene("8 - 0 - 0");
    }
    public void NpcPlunderN()
    {
        SceneManager.LoadScene("8 - 0 - 1");
    }

    public void NpcPlunderL()
    {
        SceneManager.LoadScene("8 - 1");
    }


    public void NpcPlunderB()
    {
        int w = Random.Range(0, 101);
        if (w > Rate.rate)
        {
            Player.gold = 0;
            Player.currentHp = 1;
            SceneManager.LoadScene("8 - 0 - 0 - 0");
        }
        else
        {
            Player.gold += 1000;
            SceneManager.LoadScene("8 - 0 - 0 - 1");
        }
    }
    public void deer()
    {
        if (Player.deerCount == 0)
        {
            int w = Random.Range(0, 101);
            if (w < Rate.rate)
            {
                Player.point += 20;
                SceneManager.LoadScene("9 - 2");
            }
            else
            {
                SceneManager.LoadScene("9 - 0");
            }
        }
        else {
            SceneManager.LoadScene("9 - 5");
        }
        
    }
    public void deerB()
    {

        if (Player.deerCount == 0)
        {
            Player.deerCount++;
            int w = Random.Range(0, 101);
            if (w < Rate.rate)
            {
                SceneManager.LoadScene("9 - 4");
            }
            else
            {
                SceneManager.LoadScene("9 - 1");
            }
        }
        else
        {
            SceneManager.LoadScene("9 - 5");
        }
    }

    
}
