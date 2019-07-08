using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public spawner albaba;
    int x;
    public Text stext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x=albaba.seviye/3-3;
        if(x<0) x=0;
        if(!albaba.gameEnded)
        stext.text="Score: " + x;
        else{//game ended
            stext.text = "Game Has Finished\nYour Score is " + x + "\nCongragulations" + "\nPress Space to Contunie";
        }
        
    }
}
