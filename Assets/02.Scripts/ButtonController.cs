using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Watsson.Examples;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    public ExampleStreaming onoffRec;
    public Image buttonImg;
    private void Start()
    {
        onoffRec = FindObjectOfType<ExampleStreaming>();
      
    }


    public void onRecordingClick()
    {
        onoffRec.Active = !onoffRec.Active;
        if(onoffRec.Active == true)
        {
            buttonImg.color = Color.red;

        }
        else
        {
            buttonImg.color = Color.white;

        }
    }

    
}
