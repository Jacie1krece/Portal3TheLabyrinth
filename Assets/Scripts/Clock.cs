using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : PickUpController
{
    [SerializeField] int addedTime = 5;
    public override void Picked()
    {
        Debug.Log("Pick up get!");
        GameManager.gameManager.AddTime(addedTime);
        Destroy(this.gameObject);
    }
    void Update()
    {
        Rotation();
    }
}
