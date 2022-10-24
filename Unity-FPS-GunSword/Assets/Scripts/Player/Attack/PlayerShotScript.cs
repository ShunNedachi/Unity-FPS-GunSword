using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class PlayerShotScript : MonoBehaviour
{
    public float rayDistance;

    private void FixedUpdate()
    {
        Transform trans = transform;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            var direction = trans.forward;

            Vector3 rayPosition = trans.position + new Vector3(0.0f, 0.0f, 0.0f);
            Ray ray = new Ray(rayPosition, direction);
            UnityEngine.Debug.DrawRay(rayPosition, direction * rayDistance, UnityEngine.Color.red);

            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                UnityEngine.Debug.Log("HIT‚µ‚Ü‚µ‚½‚æ");

                if(hit.collider.tag == "OBJECT")
                {
                    Destroy(hit.collider.gameObject);
                }
            }

        }
    }
}
