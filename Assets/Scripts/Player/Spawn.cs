using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    public bool Deactivated { get; private set; }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Deactivator")
        {
            Deactivated = true;
        }
        Debug.Log($"{gameObject.name} is {Deactivated}");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Deactivator")
        {
            Deactivated = false;
        }
        Debug.Log($"{gameObject.name} is {Deactivated}");
    }
}
