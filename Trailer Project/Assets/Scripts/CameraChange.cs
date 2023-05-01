using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public GameObject[] listCameras;
    int ncameras = 3;
    // Start is called before the first frame update
    void Start()
    {
        SetOffCameras();
        listCameras[2].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            //Debug.Log("Camara 1 (1st person)");
            SetOffCameras();
            listCameras[0].gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            //Debug.Log("Camara 2 (Top Down)");
            SetOffCameras();
            listCameras[1].gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            //Debug.Log("Camara 3 (3rd person)");
            SetOffCameras();
            listCameras[2].gameObject.SetActive(true);
        }
    }

    void SetOffCameras()
    {
        for(int i=0; i<ncameras; i++)
        {
            listCameras[i].gameObject.SetActive(false);
        }
    }
}
