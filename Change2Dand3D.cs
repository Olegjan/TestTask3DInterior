using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change2Dand3D : MonoBehaviour
{
    public GameObject gameObj3D;
    public GameObject gameObj2D;
    bool changer;
    float rotationModel = 60;
    float rotationModel2 = 80;
    public Camera androidCameraTouch;
    public GameObject androidCameraTouchTransform;
    Transform startPositionCamera;

    private void Start()
    {
        startPositionCamera = androidCameraTouch.transform;
    }

    public void Change2dAnd3d()
    {
        
        if (changer)
        {
            gameObj3D.SetActive(false);
            gameObj2D.SetActive(true);
            androidCameraTouch.transform.position = new Vector3(0, 70, -10);
            androidCameraTouch.transform.rotation = Quaternion.Euler(new Vector3(88, androidCameraTouch.transform.rotation.y, androidCameraTouch.transform.rotation.z));
        }
        else
        {
            gameObj2D.SetActive(false);
            gameObj3D.SetActive(true);
            androidCameraTouch.transform.position = new Vector3(0, 70, -10);
            androidCameraTouch.transform.rotation = Quaternion.Euler(new Vector3(60, androidCameraTouch.transform.rotation.y, androidCameraTouch.transform.rotation.z));
        }
        changer = !changer;
    }
}