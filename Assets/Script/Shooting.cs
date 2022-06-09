using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
 
    // Update is called once per frame
   private void Update()
   {
       RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up); //стреляем из какой-то точки в каком-то направлении, возвращаем попадание
       Debug.DrawRay(transform.position,Vector2.up*10,Color.red);
       if (hit)
       {
           Destroy(hit.collider.gameObject);
       }
   }
}
