using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerText;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        // For time as a whole number (good, but not perfect):
        //timerText.text = "Time: " + Mathf.RoundToInt(time);

        // For time with a padded decimal component:
        // In Unity, string is an alias for System.String.
        // See String.Format docs: 
        //  - https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.8#remarks
        //  - https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting?view=netframework-4.8
        //  - https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        timerText.text = string.Format("Time: {0:n2}", time);
    }
}
