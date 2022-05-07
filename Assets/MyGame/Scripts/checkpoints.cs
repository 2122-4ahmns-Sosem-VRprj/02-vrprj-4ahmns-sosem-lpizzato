using UnityEngine;
using UnityEngine.UI;

public class checkpoints : MonoBehaviour
{
    Button countingUp;
    Button confirm;

    private void Awake()
    {
        countingUp = GameObject.Find("CountingUp").GetComponent<Button>();
        confirm = GameObject.Find("Confirm").GetComponent<Button>();
    }
}
