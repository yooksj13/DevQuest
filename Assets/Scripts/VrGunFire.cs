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
        grab = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A) /*&& (!PopUpManager.PopUpOn)*/)
        {
            Vector3 shooting = this.transform.right;
            GameObject weapon = Instantiate(bulletPrefab) as GameObject;
            weapon.transform.position = this.transform.position + shooting;
            shooting = shooting.normalized * 3000;
            weapon.GetComponent<WeaponController>().Launch(shooting);
        }
    }
}
