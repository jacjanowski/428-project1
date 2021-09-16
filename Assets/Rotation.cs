using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Vector3 currentRotation;
    public Vector3 anglesToRotate;
    
    // Start is called before the first frame update
    void Start()
    {
        
        currentRotation = new Vector3(currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
        this.transform.eulerAngles = currentRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //code
        currentRotation = currentRotation + anglesToRotate * Time.deltaTime;
        currentRotation = new Vector3(currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
        this.transform.eulerAngles = currentRotation;




        

    }

}
