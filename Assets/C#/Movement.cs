using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  public void Button0(){
    this.transform.localPosition = new Vector2(0,2000);
  }
  public void Button1(){
    this.transform.localPosition = new Vector2(0,4000);
  }
  public void Button2(){
    this.transform.localPosition = new Vector2(0,6000);
  }
}
