﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
}
