using UnityEngine;

public class eastereggs : MonoBehaviour
{
    [SerializeField] GameObject riddle;

    private void Awake()
    {
        riddle.SetActive(false);
    }

    public void ShowRiddle()
    {
        riddle.SetActive(true);
    }

    public void HideRiddle()
    {
        riddle.SetActive(false);
    }
}
