using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{ 

    private void Start()
    {
        static void MyMethod()
        {
            Debug.Log("Ilove you");
        }
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
        }
    }
}

