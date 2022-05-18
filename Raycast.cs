using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Vector3 collision = Vector3.zero;
    public LayerMask layer;
    public GameObject lastHit;
    void Update() {
        raycast(); 
    }
    void raycast(){
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        Color color = Color.red;
        if (Physics.Raycast(ray, out hit, 100))
        {
            
            lastHit = hit.transform.gameObject;
            Debug.DrawLine(this.transform.position, collision, color);
            collision = hit.point;
            Debug.Log("RAYCASTDISTANCE " +Vector3.Distance(this.transform.position, collision));
            
        }
        else { Debug.DrawLine(this.transform.position, this.transform.position + this.transform.forward*100,color); }
    }
}
