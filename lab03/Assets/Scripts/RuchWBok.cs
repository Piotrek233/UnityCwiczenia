using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchWBok : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        speed = 0.5f;
    }
    void Update()
    {
        float pozycjaPozioma = transform.position.x + (Input.GetAxis("Horizontal") * speed);
        float pozycjaPionowa = transform.position.z + (Input.GetAxis("Vertical") * speed);

        Vector3 nowaPozycja = new Vector3(Mathf.Clamp(pozycjaPozioma, 0f, 8f), transform.position.y, Mathf.Clamp(pozycjaPionowa, -9f, 0f));
        transform.position = nowaPozycja;
    }
}


