using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeTest : MonoBehaviour
{

    private string _microphoneID = null;
    private AudioClip _recording = null;
    private int _recordingBufferSize = 1;
    private int _recordingHZ = 22050;

    void Start()
    {
         _recording = Microphone.Start(_microphoneID, true, _recordingBufferSize, _recordingHZ);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_recording);
    }
}
