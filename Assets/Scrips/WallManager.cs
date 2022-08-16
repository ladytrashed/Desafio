using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    [SerializeField]
    [Range(2, 10)]
    private float cooldown;

    [SerializeField]
    Transform[] positions;

    private float timeInPosition = 0;

    private void OnCollisionEnter(Collision collision)
    {
        timeInPosition = 0;
    }
    private void OnCollisionStay(Collision other)
    {
        timeInPosition += Time.deltaTime;
        Debug.Log(timeInPosition);
        if (timeInPosition >= cooldown)
        {
            int indexPosition = Random.Range(0, positions.Length);
            other.transform.position = positions[indexPosition].position;
        }
    }
}
