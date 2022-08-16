using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public Transform playerTransform;
    bool iAlreadyShrink = false;

    [SerializeField]
    [Range(2, 10)]

    private float cooldown;
    private float timeFromShrink = 0;

    [SerializeField]
    Transform nextPortal;
    
    private void Update()
    {
        timeFromShrink += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrando en -> " + other.gameObject.name);
        if (other.gameObject.CompareTag("Player") && iAlreadyShrink == false)
        {
            playerTransform.localScale = playerTransform.localScale / 2;
            iAlreadyShrink = true;
            timeFromShrink = 0;
        }
        if (other.gameObject.CompareTag("Player") && iAlreadyShrink == true && timeFromShrink >= cooldown)
        {
            playerTransform.localScale = playerTransform.localScale * 2;
            iAlreadyShrink = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Saliendo de -> " + other.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Dentro de -> " + other.gameObject.name);
    }
}
