using System.Collections;
using UnityEngine;

public class Hints : MonoBehaviour
{
    [SerializeField] GameObject[] hints;
    [SerializeField] float delay = 50f;
    [SerializeField] float interval = 20f;

    private void Awake()
    {
        foreach (GameObject hint in hints)
        {
            hint.SetActive(false);
        }
    }

    private void Start()
    {
        StartCoroutine(ShowHint());
    }

    IEnumerator ShowHint()
    {
        yield return new WaitForSeconds(delay);
        for (int i = 0; i < hints.Length; i++)
        {
            hints[i].SetActive(true);
            yield return new WaitForSeconds(interval);
        }
    }
}
