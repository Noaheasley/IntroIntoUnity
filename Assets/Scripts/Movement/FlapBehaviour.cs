using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapBehaviour : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float FlapForce = 5.0f;
    public AudioSource JumpAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flap"))
        {
            _rigidbody.AddForce(new Vector3(0, FlapForce, 0), ForceMode.Impulse);
            JumpAudioSource.Play();
        }
    }
}
