using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
    Destroy(other);
  }
}
