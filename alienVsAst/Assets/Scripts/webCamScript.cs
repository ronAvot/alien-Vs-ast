using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webCamScript : MonoBehaviour {

	public GameObject webCameraPlane;
    public Button fireButton;

	// Use this for initialization
	void Start () {

        if (Application.isMobilePlatform) //check if its run on mobile device
        {
            GameObject cameraParent = new GameObject("camParent"); //New game object call "Camera Parent"
            cameraParent.transform.position = this.transform.position;//make camera parent position such as main camera
            this.transform.parent = cameraParent.transform;//set the main camera and camera parent realationship
            cameraParent.transform.Rotate(Vector3.right, 90);//rotate the camera parent
        }

        Input.gyro.enabled = true; //enable the gyro on the device

        fireButton.onClick.AddListener(onButtonDown);

        WebCamTexture webCameraTexture = new WebCamTexture(); //set new web cam texture
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture; //connect the webcam texture to our plane
        webCameraTexture.Play();//play the web cam to our project
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        //create quaternion that gets the gyro attitude from the devices, we need to put negative input in Z and W values
        this.transform.localRotation = cameraRotation; //we need to set the values from above to our main camera


	}

    void onButtonDown()
    {
        GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject; //define the bullet
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        bullet.transform.rotation = Camera.main.transform.rotation;
        bullet.transform.position = Camera.main.transform.position;
        rb.AddForce(Camera.main.transform.forward * 500f);//add force to it
        Destroy(bullet, 2f);//destroy the bullet after 3 seconds
        GetComponent<AudioSource>().Play();//play the laser sound

    }
}
