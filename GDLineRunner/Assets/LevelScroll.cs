using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScroll : MonoBehaviour
{
    [Range(0.01f,2.0f)]
    public float scrolSpeed = 0.01f;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(0, 0, scrolSpeed);
    }
}
