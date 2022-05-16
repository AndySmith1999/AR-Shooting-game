using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyCondition : MonoBehaviour {

    public int hp;
    public int HPInfo = 2;
    public Transform target;
    public float speed;
    private Vector3 vec;
    public GameObject explosion;
    private EnemyHP hpscript;
    public NewGameController ngc;

    // Use this for initialization
    void Start () {
        target = GameObject.Find("CameraPosition").transform;
        hp = HPInfo;
        hpscript = GetComponentInChildren<EnemyHP>();
        ngc = GameObject.Find("GameController").GetComponent<NewGameController>();
    }
	
	// Update is called once per frame
	void Update () {
		if (hp <= 0)
        {
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            hpscript.SetDisable();
            ngc.SetScore(1);
            
        }

    }
    public int GetHp()
    {
        return hp;
    }
    public int GetHPInfo()
    {
        return HPInfo;
    }

    void FixedUpdate()
    {

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);
        transform.position += transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "ball":
                hp -= 1;
                hpscript.UpdateHPValue();
                break;

            case "Player":
                Destroy(gameObject);
                Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
                hpscript.SetDisable();
                break;

        }

    }


}
