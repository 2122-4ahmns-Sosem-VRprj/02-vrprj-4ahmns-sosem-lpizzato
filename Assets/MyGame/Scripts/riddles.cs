using UnityEngine;

public class Riddles : MonoBehaviour
{

}

// Riddle 1:
/* float a = 4.5f;
float b = 3.2f;
float answer;

private void Start()
{
    if (a < b)
    {
        answer = 5f;
    }
    else
    {
        answer = 2f;
    }
} */

// Riddle 2:
/* bool buttonPressed;
int answer;

private void Start()
{
    if (buttonPressed)
    {
        answer++;
    }
}

private void Update()
{
    switch (answer)
    {
        case 1:
            answer += 4;
            break;
        case 2:
            // The answer would be 6
            break;
        case 3:
            Debug.Log(8);
            break;
    }
} */

// Riddle 3:
/* private void Start()
{
    for (int z = 0; z < 10; z+=2)
    {
        Debug.Log(z);
    }
} */

//Riddle 4:
/*  float[] numbers = new float[] { 2.3f, 5.2f, 7f, 0.9f };
    float answer;

    private void Start()
    {
        answer = numbers[0] + numbers[2] - numbers[1] + numbers[3];
    }
} */

// Riddle 5:
/* private void Start()
{
    for (int z = 5; z < 10; z++)
    {
        Debug.Log(z);
    }
} */