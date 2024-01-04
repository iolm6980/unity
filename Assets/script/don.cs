using UnityEngine;
using System.Collections;

public class don : MonoBehaviour
{
    public GameObject obj;
    void Awake()
    {
        DontDestroyOnLoad(obj);
    }
    void Update()
    {
        if (Player.currentHp <= 0)
        {
            Destroy(obj);
        }
    
    }
}
