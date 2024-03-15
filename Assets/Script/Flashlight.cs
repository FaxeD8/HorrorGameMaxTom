using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject Light;
    public bool LightOn;

    // Start is called before the first frame update
    void Start()
    {
        LightOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f") && LightOn == false)
        {
            Debug.Log("Fonctionne");
            LightOn = true;
            Light.SetActive(true);
        }
        else if (Input.GetKeyDown("f") && LightOn == true)
        {
            Debug.Log("Eteint");
            LightOn = false;
            Light.SetActive(false);
        }

    }
}
