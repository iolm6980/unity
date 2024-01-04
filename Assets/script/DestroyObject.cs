using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] GameObject obj;
    public void Destroyobj()
    {
        Destroy(obj);
    }
}
