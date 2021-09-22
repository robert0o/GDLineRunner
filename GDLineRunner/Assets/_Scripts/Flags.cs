using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    public GameObject flagPole;
    public int[] flags= new int [5];

    public Renderer flagRenderer;

    // Start is called before the first frame update
    void Start()
    {
        flagRenderer = gameObject.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i< flags.Length; i++)
        {
            if (flags[i] == 0) { flagRenderer.material.color = new Color(0, 0, 0, 0); }
            if (flags[i] == 1) { flagRenderer.material.color = new Color(0, 0, 0, 0); }
            if (flags[i] == 2) { flagRenderer.material.color = new Color(0, 0, 0, 0); }
            if (flags[i] == 3) { flagRenderer.material.color = new Color(0, 0, 0, 0); }
            if (flags[i] == 4) { flagRenderer.material.color = new Color(0, 0, 0, 0); }
        }

        //Random.Range();
    }
}
