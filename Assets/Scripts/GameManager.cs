using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public InputAction toggleBoxLocks;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        toggleBoxLocks.Enable();
        toggleBoxLocks.performed += ToggleLock;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ToggleLock(InputAction.CallbackContext callbackContext)
    {
        Debug.Log("ToggleLock");
    }
}
