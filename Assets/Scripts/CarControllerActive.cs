using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControllerActive : MonoBehaviour
{
    public GameObject CarControls;

    // Start is called before the first frame update
    void Start()
    {
        CarControls.GetComponent<CarController>().enabled = true;
    }



}
