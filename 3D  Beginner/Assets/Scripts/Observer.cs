using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
    public GameEnding gameEnding;
    bool m_IsPlayerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        if (m_IsPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if(Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == player)
                {
                    
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            m_IsPlayerInRange = false;
        }
    }
}
