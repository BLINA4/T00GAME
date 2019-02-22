using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
  public AudioClip myClip;

  // Start is called before the first frame update
  void Start()
  {
    AudioSource.PlayClipAtPoint(myClip, transform.position);
  }

  // Update is called once per frame
  void Update()
    {
        
    }
}
