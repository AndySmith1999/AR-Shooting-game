
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingscript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    
    public void Shoot(){
        RaycastHit hit;
            
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)){

            if(hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)")
            {
                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                // here is the score part
                ScoreScript.x += 1;
                ScoreScript.txt.text = "Score: " + ScoreScript.x;
            }
        }
    }

}
