using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]
    private float speed = 3f;
    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }
    }

    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerStay(Collider other, Vector3 quaternion)
    {
        transform.localScale = transform.localScale * 2f;
        transform.rotation = Quaternion.Euler(new Vector3(0, 10, 0));
    }
    private void OnTriggerExit(Collider other)
    {
        transform.localScale = transform.localScale * 1f;
    }
}

