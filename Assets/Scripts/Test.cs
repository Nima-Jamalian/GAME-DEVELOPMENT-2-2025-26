using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{
    private float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ChangeColor();
        //Invoke(nameof(ChangeColor),5f);
        StartCoroutine(ChangeColorIE());
    }

    // Update is called once per frame
    void Update()
    {
        // time += Time.deltaTime; // time = time + Time.deltaTime
        // if(time > 3f)
        // {
        //     ChangeColor();
        //     // Rest the time
        //     time = 0;
        // }
    }
    private IEnumerator ChangeColorIE()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            GetComponent<MeshRenderer>().material.color = new Color(Random.value,Random.value,Random.value);
        }
    }

    private void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value,Random.value,Random.value);
    }



}
