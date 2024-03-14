using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestTimer : MonoBehaviour
{
    Timer cameraTimer;
    // Start is called before the first frame update
    void Start()
    {
        cameraTimer = gameObject.AddComponent<Timer>();
        cameraTimer.setTimer(3);
        cameraTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraTimer.Finish())
        {
            Debug.Log("Object ran for " + cameraTimer.ElapsedTime);
        }
    }
}
