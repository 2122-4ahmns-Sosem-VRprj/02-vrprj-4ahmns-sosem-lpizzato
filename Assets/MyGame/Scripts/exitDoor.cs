using UnityEngine;

public class exitDoor : MonoBehaviour
{
    [SerializeField] Vector3 destination;
    [SerializeField] float time;
    entryDoor entry;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LeanTween.move(gameObject, destination, time);
        }

        entry.backgroundSound.Pause();
    }
}