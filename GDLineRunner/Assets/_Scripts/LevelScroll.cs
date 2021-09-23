using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScroll : MonoBehaviour
{
    [SerializeField]
    private float scrolSpeed = 10f;
    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(0, 0, -scrolSpeed*Time.deltaTime);
    }
}
