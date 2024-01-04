using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int maxHp;
    public static int currentHp;
    public static int str;
    public static int dex;
    public static int luk;
    public static int exp;
    public static int currentExp;
    public static int point;
    public static int lv;
    public static int gold;
    public static int deerCount;


    public Button[]inventory = new Button[14];
    public Text uiText;
    public Text stText;
    public Text pText;
    public Text lvText;
    public Text goldText;
    public Slider sd;


    void Start()
    {
        maxHp = 200;
        currentHp = 200;
        currentExp = 0;
        lv = 1;
        str = 5;
        dex = 5;
        luk = 5;
        point = 5;
        gold = 500;
        deerCount = 0;
        for(int i=0; i < 6; i++) 
            inventory[i].image.sprite = Resources.Load<Sprite>("point") as Sprite;
    }

    void Update()
    {
        exp = lv * 30;

        stText.text = "HP " + maxHp + "\nSTR " + str + "\nDEX " + dex + "\nLUK " + luk + "\n exp" + exp + "/" + currentExp;
        uiText.text = "HP " + maxHp + " / " + currentHp;
        pText.text = "Point: " + point;
        lvText.text = "Lv: " + lv;
        goldText.text = "Gold: " + gold;
        sd.maxValue = maxHp;
        sd.value = currentHp;

        if (Input.GetKey(KeyCode.H))
        {
            currentHp -= 50;
           gold += 1000;
            point += 100;
        }

        if(currentExp >= exp)
        {
            Debug.Log("Level Up!");
            lv++;
            point += 5;
            currentExp = 0;
        }
        
        if(currentHp <= 0)
        {
            SceneManager.LoadScene("die");
        }
    }

}
