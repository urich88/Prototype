using UnityEngine;
using System.Collections;
[System.Serializable]

public class Robots : System.Object {

/* Every Robot stat is here and from here it
 * would be pulled elsewhere into an array*/

  //Core properties of robots
  /*For this version only it will have the base
   * stats, not of the pieces of the robot.*/

  //name
  public string robotName;

  //base stats and bonuses
  public int hp, currentHP, maxHP, presicion, curPresicion, maxPresicion,
  swiftness, maxSwiftness, curSwiftness, offensive, curOffensive,
  maxOffensive, armor, curArmor, maxArmor, alertness, maxAlertness,
  attack1, attack2, attack3, hits, baseAttack1, baseAttack2, baseAttack3;

  //type (class)
  public Type type;

  //turn
  public bool turn;

  public Attack[] attacks;

  //clases de robots
  public enum Type 
  {
    Inductor,
    Smashers,
    Furnace, 
    Alchemists,
    Reactor

  }

  public string RobotName
  {
    get{return robotName;}
    set{robotName = value;}
  }



}

  
 