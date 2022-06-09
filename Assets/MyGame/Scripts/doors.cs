using UnityEngine;

public class doors : MonoBehaviour
{
    [SerializeField] Vector3 destination;
    [SerializeField] float time;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LeanTween.move(gameObject, destination, time);
        }
    }
}