using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
  public GameObject theObj;

  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonUp("Jump"))
    {
      GameObject instance = Instantiate(theObj, transform.position, transform.rotation);
      //Debug.Log("Space!!!");
    }
  }
}
