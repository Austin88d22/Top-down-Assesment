using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assesmentscript : MonoBehaviour
{
    float timer = 0;
    public float onTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0 && timer < onTime)
            Destroy(gameObject);
    }
}
