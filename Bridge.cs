using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class Bridge : MonoBehaviour
{

    #if UNITY_WEBGL && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void ShowMessage2(string message);
    #endif


    // Start is called before the first frame update
    void Start()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        WebGLInput.captureAllKeyboardInput = false;
        SendToJS();
        #endif
    }


    public void SendToJS() {
        string MessageToSend = "XXXXX";
        Debug.Log("Sending message to JavaScript: " + MessageToSend);
        #if UNITY_WEBGL && !UNITY_EDITOR
                ShowMessage2(MessageToSend);
        #endif
    }


}
