using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Player : MonoBehaviour, InputMaster.IPlayerActions
{
    private InputMaster controls;

    public void OnShoot(InputAction.CallbackContext context)
    {
        Debug.Log("We shot the enemy");
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    void Awake()
    {
        controls = new InputMaster();
        //controls.Player.Shoot.performed += _ => Shoot();
        //controls.Player.Movement.started += ctx => Shoot();

        controls.Player.SetCallbacks(this);
    }
    /*
    void Shoot()
    {
        Debug.Log("We shot the enemy");
    }
    */

    void OnEnable()
    {
        controls.Player.Enable();
    }
    void OnDisable()
    {
        controls.Player.Disable();
    }

   
}
