using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSections : MonoBehaviour
{
    public GameObject[] sections;
    public float zPos; // pollaplasio tou megethous tou ground px 0-60-120-180-240-...
    public bool create = false;
    public int secNum;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (create == false)
        {
            create = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, sections.Length);
        Instantiate(sections[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 60;
        yield return new WaitForSeconds(1/2);
        create = false;

    }
}