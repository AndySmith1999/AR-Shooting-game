using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript: MonoBehaviour
{
    public GameObject text;
    public int TotalTime = 60;
    public GameObject gameover;

    void Start()
    {
        StartCoroutine(time());
    }

    IEnumerator time()
    {
        while (TotalTime >= 0)
        {
            text.GetComponent<Text>().text = TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;
        }

        if (TotalTime == -1)
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
}