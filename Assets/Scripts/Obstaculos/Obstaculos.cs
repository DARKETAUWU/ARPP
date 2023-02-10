using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public Transform[] obstaculos;
    public Transform player;
    public float fspeed = 5;

    private Vector2 r; // 
    private Vector2 u;
    private float B = 1300;
    private float m = 2.0f;
    private float fdistance;
    private float U;
    private Vector2 Fs;
    private Vector2 objetivo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fs = Vector2.zero;
        foreach (Transform obstaculo in obstaculos)
        {
            r = obstaculo.position - transform.position;
            u = r;
            u.Normalize();

            fdistance = r.magnitude / 1.0f;

            U = B / Mathf.Pow(fdistance, m);
        }

        Fs.Normalize();

        float a = 1;

        r = player.position - transform.position;
        fdistance = r.magnitude;

        if(fdistance > 10)
        {
            a = 1;
        }
        if(fdistance < 1)
        {
            a = 10;
        }
    }
}
