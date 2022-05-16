using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame1 : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Game1");
    }
}