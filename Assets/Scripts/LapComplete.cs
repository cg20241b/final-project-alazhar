using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
        if (LapTimeManager.SsecondCount <= 9)
        {
            SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.SsecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.SsecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ":";
        }
        else
        {
            MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ":";
        }

        MilliDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.MilliDisplay;

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SsecondCount = 0;
        LapTimeManager.MilliCount = 0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);



    }
}
