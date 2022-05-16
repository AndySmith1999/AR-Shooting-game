using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Random generate enemys
public class RandomAppear : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public GameObject obj;
    public float TimeOut = 4;
    public float timer;
    public int MaxNum = 5;

    void Start()
    {

    }


    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= TimeOut)
        {
            if (MaxNum > enemies.Count)
            {
                float x = Random.Range(-8.0f, 8.0f);
                float y = Random.Range(0.0f, 3.0f);
                float z = Random.Range(-8.0f, 8.0f);

                GameObject enemy = Instantiate(obj, new Vector3(x, y, z), Quaternion.identity);
                enemies.Add(enemy);
                timer = 0.0f;
            }
            else
            {
                if (!GameObject.Find("Enemy(Clone)"))
                {
                    enemies.Clear();
                }

            }

        }

    }

}