using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour {

    Text text;
    string firstWord;
    string secondWord;
	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        float rand = Mathf.Floor(Random.Range(1f, 6f));
        if(rand == 1)
        {
            firstWord = "The";
        }
        else if (rand == 2)
        {
            firstWord = "Super";
        }
        else if (rand == 3)
        {
            firstWord = "Extrodinarily";
        }
        else if (rand == 4)
        {
            firstWord = "Extremely";
        }
        else if (rand == 5)
        {
            firstWord = "Amazingly";
        }
        float rand2 = Mathf.Floor(Random.Range(1f, 6f));
        if (rand2 == 1)
        {
            secondWord = "Awesome";
        }
        else if (rand2 == 2)
        {
            secondWord = "Fantastic";
        }
        else if (rand2 == 3)
        {
            secondWord = "Fandoodledistic";
        }
        else if (rand2 == 4)
        {
            secondWord = "Happy";
        }
        else if (rand2 == 5)
        {
            secondWord = "Inspiring";
        }
    }
	
	// Update is called once per frame
	void Update () {
        text.text = firstWord + " " + secondWord + " Procedural Generation System" + "\n" + "Press R to restart";
	}
}
