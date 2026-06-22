using UnityEngine;
using System.Collections;

public class JayVision : MonoBehaviour
{
    [Header("Components")]
    public Animator animator;
    public AnimationClip singing;
    public AnimationClip alert;
    public AnimationClip watching;
    public DamageArea damageArea;

    [Header("Seconds")]
    public float maxSingingWait = 5f;
    public float minSingingWait = 1f;
    public float alertWait = 2f;
    public float maxWatchingWait = 5f;
    public float minWatchingWait = 1f;

    public AudioSource rawr;


    private void Start()
    {
        StartCoroutine(StateLoop());
        rawr = GetComponent<AudioSource>();
    }

    private IEnumerator StateLoop()
    {
        while (true)
        {
            yield return StartCoroutine(SingingState());
            yield return StartCoroutine(AlertState());
            yield return StartCoroutine(WatchingState());
        }
    }

    private IEnumerator SingingState()
    {
        Debug.Log("Entering Singing State");

        animator.Play(singing.name);
        damageArea.gameObject.SetActive(false);

        float seconds = Random.Range(minSingingWait, maxSingingWait);
        yield return new WaitForSeconds(seconds);
    }

    private IEnumerator AlertState()
    {
        Debug.Log("Entering Alert State");

        animator.Play(alert.name);
        rawr.Play();
        yield return new WaitForSeconds(alertWait);
    }

    private IEnumerator WatchingState()
    {
        Debug.Log("Entering Watching State");

        animator.Play(watching.name);
        damageArea.gameObject.SetActive(true);

        float seconds = Random.Range(minWatchingWait, maxWatchingWait);
        yield return new WaitForSeconds(seconds);
    }
}
