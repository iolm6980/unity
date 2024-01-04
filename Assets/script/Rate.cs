using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Rate : MonoBehaviour
{
    public Text sText;
    public static int goblinStr;
    public static int sRate;
    public static int rate;
    public static int rRate;
    public static int dRate;

    void Start()
    {
        if(SceneManager.GetActiveScene().name == "0")
            rate = rateText(40, Player.str, 10, 15);
        if (SceneManager.GetActiveScene().name == "2")
            rate = rateText(50, Player.str, 20, 30);
        if (SceneManager.GetActiveScene().name == "3")
            rate = rateText(40, Player.str, 25, 35);
        if (SceneManager.GetActiveScene().name == "8 - 0 - 0")
            rate = rateText(30, Player.str, 40, 50);
        if (SceneManager.GetActiveScene().name == "9")
            rate = rateText(20, Player.luk, 30, 50);

    }


    void Update()
    {
        
        
        if (rate <= 100 && rate > 0)
        {
            sText.text = "성공확률:" + rate;
        }
        else if(rate <= 0)
        {
            sText.text = "성공확률:0";
        }
        else
        {
            sText.text = "성공확률:100";
        }
        
    }

    public int rateText(int fRate, int Pstate, int min, int max)
    {

        int eventRate = Random.Range(min, max);
        int r = eventRate - Pstate;
        if (r > 0)
        {
            fRate -= r;
        }
        else if (r <= 0)
        {
            fRate += r*(-1);
        }
        return fRate;

    }
}
