using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GateManager : MonoBehaviour
{
    public TextMeshPro GateNo;
    public int randomNumber;
    public bool multiply;
    bool canDestory;
    void Start()
    {

        if (multiply)
        {
            randomNumber = Random.Range(1, 3);
            GateNo.text = "X" + randomNumber;
        }
        else
        {
            randomNumber = Random.Range(10, 100);

            if (randomNumber % 2 != 0)
                randomNumber += 1;

            GateNo.text = randomNumber.ToString();
        }
        canDestory = true;
    }
    //IEnumerator CoroutineTest()
    //{
    //    if (canDestory)
    //    {

    //        Destroy(gameObject);
    //        yield return new WaitForSeconds(0.1f);
            

    //    }
    //}
//void OnTriggerEnter(Collider other)
//{


//        StartCoroutine(CoroutineTest());
//            canDestory = false;
//        if (multiply)
//        {
//            randomNumber = Random.Range(1, 3);
//            GateNo.text = "X" + randomNumber;
//        }
//        else
//        {
//            randomNumber = Random.Range(10, 100);

//            if (randomNumber % 2 != 0)
//                randomNumber += 1;

//            GateNo.text = randomNumber.ToString();
//        }
//        canDestory = true;

//    }

}
