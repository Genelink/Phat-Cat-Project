using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidRotate : MonoBehaviour
{
    public float MinRotSpd = 3f;
    public float MaxRotSpd = 10f;

    public bool Minimum = false;
    public bool Maximum = false;

    private float RotVelo;

    private float AstroidRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        RotVelo = Random.Range(MinRotSpd, MaxRotSpd);
        // AstroidRot.x = 0;
        // AstroidRot.y = 0;
        if (Minimum)
        {
            RotVelo = MinRotSpd;
        }
        if (Maximum)
        {
            RotVelo = MaxRotSpd;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //AstroidRot += RotVelo;
        this.transform.Rotate(0.0f, 0.0f, RotVelo, Space.World);
    }
}
