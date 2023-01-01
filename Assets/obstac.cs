using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstac : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // int sayi=0;
       // sayi +=1;
     //   gameObject.transform.rotation = Quaternion.Euler(0, 0, sayi*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
