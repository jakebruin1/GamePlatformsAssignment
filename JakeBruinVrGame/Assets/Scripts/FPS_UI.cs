using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FPS_UI : MonoBehaviour
{
    public TextMeshProUGUI FpsText;

    private float pollingTime = 1f;
    private float time;
    private int Frames;
    void Update()
    {
        time += Time.deltaTime;

        Frames++;
        if(time >= pollingTime)
        {
            int FrameRate = Mathf.RoundToInt(Frames / time);
            FpsText.text = FrameRate.ToString() + " FPS";

            time -= pollingTime;
            Frames = 0;
        }
    }
}
