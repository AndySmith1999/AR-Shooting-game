﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart: MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}