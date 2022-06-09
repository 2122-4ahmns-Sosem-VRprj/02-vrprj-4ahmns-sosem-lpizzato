using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    Text numberText;
    public Material disabled;
    int number = 1;

    private void OnTriggerEnter(Collider other)
    {
        OnButtonClick(other, "CountingUp", "Confirm", "number");
        OnButtonClick(other, "CountingUp1", "Confirm1", "number1");
        OnButtonClick(other, "CountingUp2", "Confirm2", "number2");
        OnButtonClick(other, "CountingUp3", "Confirm3", "number3");
    }

    void OnButtonClick(Collider other, string countingUp, string confirm, string numberTag)
    {
        if (GameObject.FindGameObjectWithTag(numberTag) == null) return;
        // print(GameObject.FindGameObjectWithTag(numberTag));
        numberText = GameObject.FindGameObjectWithTag(numberTag).GetComponent<Text>();
        numberText.text = number.ToString();

        if (other.gameObject.tag == countingUp)
        {
            number++;
            if (number > 9)
            {
                number = 1;
            }
        }

        if (other.gameObject.tag == confirm)
        {
            GameObject.FindGameObjectWithTag(countingUp).GetComponent<Renderer>().material = disabled;

            GameObject.FindGameObjectWithTag(countingUp).tag = "button";
            GameObject.FindGameObjectWithTag(confirm).tag = "button";
            GameObject.FindGameObjectWithTag(numberTag).tag = "button";
            Debug.Log("disabled");
            number = 1;
        }
    }
}