using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour
{
    [SerializeField]
    private GameObject _leftBar = null;

    [SerializeField]
    private GameObject _rightBar = null;

    [SerializeField]
    private float delay = 0;

    private IEnumerator InitializeIterator()
    {
        var leftAnimator = _leftBar.GetComponent<Animator>();
        var rightAnimator = _rightBar.GetComponent<Animator>();

        yield return new WaitForSeconds(delay);

        leftAnimator.enabled = true;
        rightAnimator.enabled = true;
    }

    void Awake()
    {
        StartCoroutine(InitializeIterator());
    }
}
