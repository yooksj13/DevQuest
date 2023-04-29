using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrGunFire : MonoBehaviour
{
    private OVRGrabbable grab;

    //bulletº¯¼ö
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grab.isGrabbed && OVRInput.GetDown(OVRInput.Button.One) /*&& (!PopUpManager.PopUpOn)*/)
        {
            GameObject weapon = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
            Vector3 shooting = transform.forward;
            shooting = shooting.normalized * 3000;
            weapon.GetComponent<WeaponController>().Launch(shooting);
        }
    }
}
