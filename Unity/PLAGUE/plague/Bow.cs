using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Bow : MonoBehaviour
{
    private float rotationZ = 0f;
    private float sensitivityZ = 2f;
    public GameObject Arrow;//箭
    public float LaunchForce1;//弓箭的威力
    public float LaunchForce2;
    public static Bow shooter;
    bool front = true;
    void Start()
    {
        shooter = this;
    }
    void Update()
    {
        Vector2 v2 = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Vector2 newPoint = new Vector2(v2.x - 0.5f, v2.y - 0.5f);
        Vector2 temp = new Vector2(newPoint.x * 1920, newPoint.y * 1080);//須採用1920*1080
        transform.right = temp;
        lockedRotation();
        front = GameObject.Find("Amisia").transform.gameObject.GetComponent<AmisiaController>().getFace();
    }
    void lockedRotation()
    {
        rotationZ += Input.GetAxis("Mouse X") * sensitivityZ;
        rotationZ = Mathf.Clamp(rotationZ, 0, 15);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
    }
    public void Shoot()
    {
        if(front)
        {
            GameObject ArrowIns = Instantiate(Arrow, transform.position, transform.rotation);
            ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce1);
        }
        else
        {
            GameObject ArrowIns = Instantiate(Arrow, transform.position, transform.rotation);
            ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce2);
        }
    }
}