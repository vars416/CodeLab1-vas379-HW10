﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory me;
    public GameObject[] obj;
    // Start is called before the first frame update
    private void Awake()
    {
        me = this;
    }
}
