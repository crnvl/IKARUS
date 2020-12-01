using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.name == "Warps") {
            Debug.Log("warp");
        }
        
    } 
}
