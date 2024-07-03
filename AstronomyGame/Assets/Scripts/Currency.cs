using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public int coins;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
