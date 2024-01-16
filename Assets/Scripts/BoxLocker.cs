using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoxLocker : MonoBehaviour
{
    public bool locked;
    private Rigidbody rb;
    private RigidbodyConstraints rbConstraints;
    private Vector3 startPosition;
    private Quaternion startRotation;
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rbConstraints = rb.constraints;
        startPosition = transform.position;
        startRotation = transform.rotation;
        GameManager.instance.toggleBoxLocks.performed += ToggleLock;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ToggleLock(InputAction.CallbackContext callbackContext)
    {
        if (audioSource != null) {
            audioSource.PlayOneShot(audioClip);
        }

        if (locked) {
            rb.constraints = rbConstraints;
        } else {
            transform.position = startPosition;
            transform.rotation = startRotation;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

        locked = !locked;
    }
}
