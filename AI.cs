using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

  /*try of very simple AI, it will choose a rand number,
   * depending of the number it gets, it will get a
   * random attack and at a random robot*/

  public int enemyAttack;

  void GetAttack ()
  {
    enemyAttack = Random.Range(0,5);

    if (enemyAttack == 1)
    {
      //base attack
    }
    if (enemyAttack == 2)
    {
      //medium attack
    }
    if (enemyAttack == 3)
    {
      //super attack
    }
    else
    {
      GetAttack();
    }

  }
}
