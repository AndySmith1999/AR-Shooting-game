using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour {

    public GameObject player;
    private PlayerCondition ps;
    private Slider hpSlider;

	// Use this for initialization
	void Start () {
        ps = player.GetComponent<PlayerCondition>();
        hpSlider = transform.Find("HP").GetComponent<Slider>();
        hpSlider.value = (float)ps.GetMaxHp() / (float)ps.GetMaxHp();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateHPValue()
    {
        hpSlider.value = (float)ps.GetHp() / (float)ps.GetMaxHp();
    }
}
