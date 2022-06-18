using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] Vector3 destination;
    [SerializeField] float time;
    EntryDoor entryDoorScript;
    [SerializeField] AudioClip winnerSound;
    Hand handScript;

    private void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = winnerSound;

        if (handScript.greenNumber == 2 && handScript.blueNumber == 6 && handScript.yellowNumber == 8 && handScript.purpleNumber == 5)
        {
            LeanTween.move(gameObject, destination, time);
        }

        if (handScript.greenNumber == 2)
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