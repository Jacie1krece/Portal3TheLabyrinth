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
        //basePortal = we� rodzica
        //targetPortal = we� z rodzica portal docelowy

    }

    private void PortalCameraControler()
    {
        // przypisz do rotacji kamery w portalu docelowym rotacj� kamery g��wnej ;

    }

    private void Update()
    {
        PortalCameraControler();
    }

}
