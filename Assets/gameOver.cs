using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
	public Text gameOverText;


    // Start is called before the first frame update
    public void setUp()
    {
    	gameOverText.GetComponent<Text>().enabled = false;
    }

    public void displayText()
    {
    	gameOverText.GetComponent<Text>().enabled = true;
    }

    
}
