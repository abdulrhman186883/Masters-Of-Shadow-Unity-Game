using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kunai_Text : MonoBehaviour {
    Text text;
    void Start()
    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Kunai.ammoAmount > 0)
        {
            text.text = "Kunai: " + Kunai.ammoAmount;
        }
        else
        {
            text.text = "Kunai: 0";
        }
    }
}
