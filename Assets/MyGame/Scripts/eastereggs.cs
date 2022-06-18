using UnityEngine;

public class Eastereggs : MonoBehaviour
{
    [SerializeField] GameObject riddle;

    private void Awake()
    {
        riddle.SetActive(false);
    }

    public void ShowRiddle()
    {
        riddle.SetActive(true);
        Debug.Log("Riddle active");
    }

    public void HideRiddle()
    {
        riddle.SetActive(false);
        Debug.Log("Riddle inactive");
    }
}
