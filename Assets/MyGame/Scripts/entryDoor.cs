using UnityEngine;

public class entryDoor : MonoBehaviour
{
    [SerializeField] Vector3 closed;
    [SerializeField] Vector3 opened;
    [SerializeField] float time;
    [SerializeField] float delayTime;
    public AudioSource backgroundSound;

    private void Start()
    {
        LeanTween.move(gameObject, opened, time).setDelay(delayTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LeanTween.move(gameObject, closed, time);
        }

        backgroundSound.Play();
    }
}