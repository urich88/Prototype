using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

  //Core properties of robots
  /*For this version only it will have the base
   * stats, not of the pieces of the robot.*/
  public static string name, clase;
  public static int hp, currentHP, maxHP, presicion, curPresicion, maxPresicion,
  swiftness, maxSwiftness, curSwiftness, offensive, curOffensive,
  maxOffensive, armor, curArmor, maxArmor, alertness, maxAlertness,
  attack1, attack2, attack3, hits;

  //Turn
  public bool turn;
  //saber si el robot esta activo
  public bool isActive;
    
	//Setting the default attributes for robots
	public static void startState () {

    print ("Creating new Game state");
    //numero de golpes, por ahora el default sera 1
    hits = 1;
    //attacks base points
    attack1 = 20; attack2 = 35; attack3 = 50;
    //robots base stats
    hp = 80; maxHP = 120; presicion = 3; swiftness = 3; armor = 10;
    offensive = 10; alertness = 1;


	
	}

  //---Get methods of this state manager--//
  //getHP()
  //Returns the chars HP
  public static int getHP ()
  {
    return hp;
  }

  //get presicion
  //getPresicion()
  //Returns the chars Presicion
  public static int getPresicion ()
  {
    return presicion;
  }

  //getSwiftness()
  //Returns the chars swiftness
  public static int getSwiftness ()
  {
    return swiftness;
  }
  //getArmor()
  //Returns Armor
  public static int getArmor ()
  {
    return armor;
  }
  //getOffensive()
  //returns Armor
  public static int getOffensive ()
  {
    return offensive;
  }
  //getAlertness()
  //returns alertness
  public static int getAlertness ()
  {
    return alertness;
  }



  //basic attack
  public static void Attack1 ()
  {
    curOffensive = 10;
    curOffensive = offensive;
    int currentAttack;
    currentAttack = attack1 + offensive;
    currentAttack = attack1;
    Debug.Log(attack1);
  }
  //medium attack
  public static void Attack2 ()
  {
    curOffensive = 20;
    curOffensive = offensive;
    attack2 = attack2 + offensive;
    Debug.Log(attack2);
  }
	//power attack
  public static void Attack3 ()
  {
    curOffensive = 30;
    curOffensive = offensive;
    attack3 = attack3 + offensive;
    Debug.Log(attack3);
  }
	// Update is called once per frame
	void Update () {
	
	}
}
