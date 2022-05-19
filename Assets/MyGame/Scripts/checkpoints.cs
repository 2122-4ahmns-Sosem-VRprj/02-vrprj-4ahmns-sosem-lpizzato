using UnityEngine;
using UnityEngine.UI;

public class checkpoints : MonoBehaviour
{
    public Text numberText;
    public Button countingUp;
    public Button confirm;

    int number = 0;

    private void Awake()
    {
        /* countingUpText = GameObject.Find("CountingUpText").GetComponent<Text>();
        countingUp = GameObject.Find("CountingUp").GetComponent<Button>();
        confirm = GameObject.Find("Confirm").GetComponent<Button>(); */
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
                numberText.text = number.ToString();
                break;
            case 2:
                numberText.text = number.ToString();
                break;
            case 3:
                numberText.text = number.ToString();
                break;
            case 4:
                numberText.text = number.ToString();
                break;
            case 5:
                numberText.text = number.ToString();
                break;
            case 6:
                numberText.text = number.ToString();
                break;
            case 7:
                numberText.text = number.ToString();
                break;
            case 8:
                numberText.text = number.ToString();
                break;
            case 9:
                numberText.text = number.ToString();
                number = 0;
                break;
        }
    }

    public void CountingUp()
    {
        number++;
    }

    public void Confirm()
    {
        countingUp.enabled = false;
    }
}