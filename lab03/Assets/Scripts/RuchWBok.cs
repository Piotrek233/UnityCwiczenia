using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchWBok : MonoBehaviour
{        // metoda Start() wywoływana jest przy inicjalizacji obiektu

        public float force = 1.0f;

        void Start()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 0, force, ForceMode.Impulse);
        }
}
