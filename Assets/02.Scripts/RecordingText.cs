using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IBM.Watsson.Examples;

using TMPro;
public class RecordingText : MonoBehaviour
{
    [Header("WatSon")]
    [Tooltip("WatsonResultsText")]
    [SerializeField]
    private Text WatsonResults;


    private TextMeshProUGUI textRec; 
    void Start()
    {
        textRec = this.GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textRec.text = ExampleStreaming.text;
        
    }

}
