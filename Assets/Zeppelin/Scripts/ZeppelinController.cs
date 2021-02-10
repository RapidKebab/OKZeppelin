using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeppelinController : MonoBehaviour
{
    public bool armed;
    public float baseThrust;
    public float[] gearRatios = {-1, 0, 1, 2, 3, 4};
    public Animator prop;
    int currentGear;
    float thrust;
    public Transform rotator;
    public Transform enjin;
    public Rigidbody rb;
    public float maxRot;
    public float altChange;
    public GameObject bomb;
    public Transform bombSpawn;

    // Start is called before the first frame update
    void Start()
    {
        currentGear = 1;
        PropUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        thrust = baseThrust * gearRatios[currentGear];
        if (Input.GetKeyDown(KeyCode.LeftShift) && currentGear < gearRatios.Length-1)
        {
            currentGear += 1;
            PropUpdate();
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && currentGear > 0)
        {
            currentGear -= 1;
            PropUpdate();
        }

        if (Input.GetButtonDown("Fire1") && armed)
            Instantiate(bomb, bombSpawn.position, Quaternion.identity);
    }

    void FixedUpdate()
    {
        rb.AddForceAtPosition(enjin.transform.forward * thrust, enjin.transform.position, ForceMode.Acceleration);
        rotator.transform.localEulerAngles = new Vector3(0f, maxRot * Input.GetAxis("Horizontal") * -1, 0f);
        rb.AddForce(0, altChange * Input.GetAxis("Vertical"), 0, ForceMode.Acceleration);
    }
    void PropUpdate()
    {
        if (prop != null)
            prop.SetFloat("speedMult", gearRatios[currentGear]);
    }
}
