using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : PickUpController
{
    [SerializeField] int freezeDuration = 10;
    public override void Picked()
    {
        Debug.Log("Pick up get!");
        GameManager.gameManager.FreezeTime(freezeDuration);
        Destroy(this.gameObject);
    }
    void Update()
    {
        Rotation();
    }
}
