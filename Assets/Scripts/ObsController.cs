using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        VerifyToDestroy();
    }

    void VerifyToDestroy()
    {
        if (transform.position.x <= -12f)
        {
            Destroy(this.gameObject);
        }
    }
}
