using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject[] lines;
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    
    bool moveleft = false;
    bool moveright = false;

    public float speed;
    private int currentline;

    // Start is called before the first frame update
    void Start()
    {
        currentline = 1;
        transform.position = line2.transform.position;
        lines[0] = line1;
        lines[1] = line2;
        lines[2] = line3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            moveright = false;
            moveleft = true;

            if (currentline > 0)
            {
                currentline -= 1;
            }

        }
        if(Input.GetKeyDown(KeyCode.D)){
            moveleft = false;
            moveright = true;
            if (currentline < 2)
            {
                currentline += 1;
            }
        }

        if (moveleft)
        {
            transform.position = Vector3.MoveTowards(transform.position, lines[currentline].transform.position, Time.deltaTime * speed);
        }
        if (moveright)
        {
            transform.position = Vector3.MoveTowards(transform.position, lines[currentline].transform.position, Time.deltaTime * speed);
        }
    }
}
