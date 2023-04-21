using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    private Camera playerCamera;
    private Transform basePortal;
    private Transform targetPortal;

    private float myAngle;


    private void Start()
    {
        playerCamera = Camera.main;
        //basePortal = weü rodzica
        //targetPortal = weü z rodzica portal docelowy

    }

    private void PortalCameraControler()
    {
        // przypisz do rotacji kamery w portalu docelowym rotacjÍ kamery g≥Ûwnej ;

    }

    private void Update()
    {
        PortalCameraControler();
    }

}
