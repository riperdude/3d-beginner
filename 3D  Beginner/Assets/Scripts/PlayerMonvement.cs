using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMonvement : MonoBehaviour
{
    private Vector3 m_Movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_Movement.Set(horizontal, Of, vertical);
        m_Movement.Normalize();
    }
}
