using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  void Update()
  {
    float H = Input.GetAxis("Horizontal");
    float V = Input.GetAxis("Vertical");
    Vector3 Move = new Vector3(V, 0, H);

    transform.Translate(Move);
  }
}
