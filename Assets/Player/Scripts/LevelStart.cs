using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject textgo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(2);
        text3.SetActive(true);
        yield return new WaitForSeconds(1);
        text2.SetActive(true);
        text3.SetActive(false);
        yield return new WaitForSeconds(1);
        text2.SetActive(false);
        text1.SetActive(true);
        yield return new WaitForSeconds(1);
        text1.SetActive(false);
        textgo.SetActive(true);
        yield return new WaitForSeconds(1);
        textgo.SetActive(false);
        PlayerMove.canMove = true;

    }
}
