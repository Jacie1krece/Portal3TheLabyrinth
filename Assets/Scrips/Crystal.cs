using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Crystal : PickUpController
{
    [SerializeField] int pointsAdded = 5;
    public override void Picked()
    {
        Debug.Log("Pick up get!");
        GameManager.gameManager.AddPoints(pointsAdded);
        Destroy(this.gameObject);
    }
    void Update()
    {
        Rotation();
    }
}
