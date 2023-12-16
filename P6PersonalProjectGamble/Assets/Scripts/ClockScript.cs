using UnityEngine;

public class ClockScript : MonoBehaviour
{
    [SerializeField]
    private GameObject secondsHandle, minutesHandle, hoursHandle;
    private float secondsMultiplier = 1f;
    private int inGameSeconds;
    private int timeAtStart = 23500;

    void Update()
    {
        inGameSeconds = Mathf.RoundToInt(Time.time * secondsMultiplier) + timeAtStart;
        secondsHandle.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 60, 0);
        minutesHandle.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 3600, 0);
        hoursHandle.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 43200, 0);
    }
}