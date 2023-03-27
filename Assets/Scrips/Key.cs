using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    Red,
    Green,
    Blue
}

public class Key : PickUpController
{
    public KeyColor color;
    public override void Picked()
    {
        Debug.Log("Pick up get!");
        GameManager.gameManager.AddKey(color);
        Destroy(this.gameObject);
    }
    void Update()
    {
        Rotation();
    }
}
