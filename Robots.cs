using UnityEngine;
using System.Collections;
[System.Serializable]

public class Robots : System.Object {

/* Every Robot stat is here and from here it
 * would be pulled elsewhere into an array*/

  //name
  public string robotName;

  //base stats and bonuses
  public int hp, currentHP, maxHP, presicion, curPresicion, maxPresicion,
  swiftness, maxSwiftness, curSwiftness, offensive, curOffensive,
  maxOffensive, armor, curArmor, maxArmor, alertness, maxAlertness,
  attack1, attack2, attack3, hits;

  //type (class)
  public Types type;

  //rarity (maybe would be used maybe not why not?)
  public Rarity rarity;

  //turn
  public bool turn;

  //clases de robots
  public enum Type 
  {
    Inductor,
    Smashers,
    Furnace, 
    Alchemists,
    Reactor

  }

  //raresa (por las piezas o robots
  public enum Rarity
  {
    Common,
    Trashy,
    Champion,
    Legendary
  }

  public string RobotName
  {
    get{return robotName;}
    set{robotName = value;}
  }

}

  
 