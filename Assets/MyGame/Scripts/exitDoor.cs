using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] Vector3 destination;
    [SerializeField] float time;
    EntryDoor entryDoorScript;
    [SerializeField] AudioClip winnerSound;
    public int greenNumber, blueNumber, yellowNumber, purpleNumber;

    private void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = winnerSound;

        if (greenNumber == 2 && blueNumber == 6 && yellowNumber == 8 && purpleNumber == 5)
        {
            LeanTween.move(gameObject, destination, time);
        }

        if (greenNumber == 2)
        {
            LeanTween.move(gameObject, destination, time);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            entryDoorScript.backgroundSound.Pause();
            GetComponent<AudioSource>().Play();
        }
    }
}