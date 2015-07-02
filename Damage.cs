using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

  //Core properties of robots
  /*For this version only it will have the base
   * stats, not of the pieces of the robot.*/
  public string name;
  public int hp;
  public int currentHP;
  public int maxHP;
  public int presicion;
  public int curPresicion;
  public int maxPresicion;
  public int swiftness;
  public int maxSwiftness;
  public int curSwiftness;
  public int offensive;
  public int curOffensive;
  public int maxOffensive;
  public int armor;
  public int curArmor;
  public int maxArmor;
  public int alertness;
  public int maxAlertness;

  //Turn
  public bool turn;
  //saber si el robot esta activo
  public bool isActive;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
