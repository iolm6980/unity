using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneActive : MonoBehaviour
{
    [SerializeField] GameObject obj;
    void Start()
    {
        obj.SetActive(false);
    }
    
    public void SceneEixt()
    {
        obj.SetActive(false);
    }

    public void SceneOn()
    {
        obj.SetActive(true);
    }
}
