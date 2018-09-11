using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour {

    private void OnGUI()
    {
        if(GUI.Button(new Rect(320, 590, 125, 50), "Karma up"))
        {
           GameControl.control.karma += 1;
        }
        if(GUI.Button(new Rect(580, 590, 125, 50), "Karma down"))
        {
            GameControl.control.karma -= 1;
        }
        if (GUI.Button(new Rect(100, 0, 140, 50), "Save"))
        {
            GameControl.control.Save();
        }
        if (GUI.Button(new Rect(100, 50, 140, 50), "Load"))
        {
            GameControl.control.Load();
        }
    }

}
