using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModel : MonoBehaviour
{
    public GameObject GameObjC;
    public GameObject GameObjS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClothToSpring()
    {
        GameObjC.SetActive(false);
        GameObjS.SetActive(true);
    }
    public void SpringToCloth()
    {
        GameObjC.SetActive(true);
        GameObjS.SetActive(false);
    }
}
