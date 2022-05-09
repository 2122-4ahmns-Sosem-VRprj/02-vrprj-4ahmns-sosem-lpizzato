using UnityEngine;
using UnityEngine.UI;

public class checkpoints : MonoBehaviour
{
    Text countingUpText;
    Button countingUp;
    Button confirm;

    int number = 0;

    private void Awake()
    {
        countingUpText = GameObject.Find("CountingUpText").GetComponent<Text>();
        countingUp = GameObject.Find("CountingUp").GetComponent<Button>();
        confirm = GameObject.Find("Confirm").GetComponent<Button>();
    }

    private void Start()
    {
        countingUp.onClick.AddListener(CountingUp);
        confirm.onClick.AddListener(Confirm);
    }

    private void Update()
    {
        switch (number)
        {
            case 1:
                countingUpText.text = number.ToString();
                break;
            case 2:
                countingUpText.text = number.ToString();
                break;
            case 3:
                countingUpText.text = number.ToString();
                break;
            case 4:
                countingUpText.text = number.ToString();
                break;
            case 5:
                countingUpText.text = number.ToString();
                break;
            case 6:
                countingUpText.text = number.ToString();
                break;
            case 7:
                countingUpText.text = number.ToString();
                break;
            case 8:
                countingUpText.text = number.ToString();
                break;
            case 9:
                countingUpText.text = number.ToString();
                number = 0;
                break;
        }
    }

    void CountingUp()
    {
        number++;
    }

    void Confirm()
    {
        countingUp.enabled = false;
    }
}