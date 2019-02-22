using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
  GameObject other;

  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void OnCollisionEnter(Collision myCollision)
  {
    if (myCollision.gameObject.name == "Wall")
    {
      other = myCollision.gameObject;
      Destroy(other);
    }
  }
}
