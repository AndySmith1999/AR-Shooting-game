// Learned from https://blog.csdn.net/Z_hongli/article/details/113469814
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour {

    // Get the information of the HP
    private Slider HPInfo;
    private EnemyCondition es;
    
	// Use this for initialization
	void Start (){
        es = transform.root.GetComponent<EnemyCondition>();
        HPInfo = transform.Find("HPbar").GetComponent<Slider>();
        HPInfo.value = UpdateHP(es);
	}
	
	// Update is called once per frame
	void Update (){
        transform.rotation = Camera.main.transform.rotation;
	}

    public void SetDisable(){
        gameObject.SetActive(false);
    }
    public void UpdateHPValue(){
        HPInfo.value = (float)es.GetHp() / (float)es.GetHPInfo();
    }
    public float UpdateHP(EnemyCondition es)
    {
        return ((float)es.GetHPInfo() / (float)es.GetHPInfo());
    }
}
