using UnityEngine;
using System.Collections;

public class WindScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _egg = null;

    [SerializeField]
    private Vector3 _windpower = Vector3.zero;

    private Rigidbody _rigidbody;
    private bool _isActive; // 多重起動防止

    private void Start()
    {
        _rigidbody = _egg.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (!_isActive && col.gameObject == _egg)
        {
            Debug.Log("Hit");
            StartCoroutine(WindBreathe());
        }
    }

    private const float MaxTime = 1F;

    private IEnumerator WindBreathe()
    {
        _isActive = true;
        for (var time = 0F; time < MaxTime; time += Time.deltaTime)
        {
            if (_egg == null) { break; }

            _rigidbody.AddForce(_windpower * (time / MaxTime), ForceMode.Force);
            Debug.Log((time / MaxTime) * _windpower + " is power , " + time + " is time.");
            yield return null;
        }
        _isActive = false;
    }
}
