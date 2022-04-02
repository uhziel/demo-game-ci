using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 camPosOffset;
    public Vector3 camRotOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = plane.transform.rotation * CalRotOffset(); //Sets the rotation to the plane rot + the offset given at the beginning
        transform.position = plane.transform.position + CalPosOffset(); //Sets the position to the plane pos + (the current rotation of the cam * the offset given at the beginning) //In that order
    }
    private Quaternion CalRotOffset()
    {
        return Quaternion.Euler(camRotOffset);
    }

    private Vector3 CalPosOffset()
    {
        return transform.rotation * camPosOffset;
        //By far the most interesting par of the challange that wasn't even a challange
        //rotate the camara based on the rotation of the plane and make it stay there even if the plane keeps rotating
    }

}
