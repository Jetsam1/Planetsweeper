using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManage : MonoBehaviour
{
        public Transform FollowObject;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 offset = new Vector3(8,0,0);
            Vector3 pos = new Vector3(FollowObject.position.x, transform.position.y, transform.position.z);
            transform.position = pos+offset;
        }
    
}
