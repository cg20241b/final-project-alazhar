using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SsecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public static float RawTime;

    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<TMPro.TextMeshProUGUI>().text = "" + MilliDisplay;

        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SsecondCount += 1;
        }

        if (SsecondCount <= 9)
        {
            SecondBox.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + SsecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<TMPro.TextMeshProUGUI>().text = "" + SsecondCount + ".";
        }

        if (SsecondCount >= 60)
        {
            SsecondCount = 0;
            MinuteCount += 1;
        }

        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<TMPro.TextMeshProUGUI>().text = "" + MinuteCount + ":";
        }
    }
}
