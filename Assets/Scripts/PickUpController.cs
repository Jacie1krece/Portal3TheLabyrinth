using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    void Update()
    {
        Rotation();
    }
    public virtual void Picked()
    {
        Debug.Log("Pick up get!");
        Destroy(this.gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(new Vector3(5f, 5f, 5f));
    }
}
