using UnityEngine;
using System.Collections;

/*Reading the data to initialise the base stats
 * Numeral and string variables keeping for know who wins
 * timers to set turns (Need to be in miliseconds)*/

public class GameManager : MonoBehaviour {

	//Manage the timers needed for player
	public float p1Timer, p2Timer, p3Timer;

	//Manage timers of CPU
	public float cpu1Timer, cpu2Timer, cpu3Timer;


	//total alertness manage P1
	public int p1TotalAlert, p2TotalAlert, p3TotalAlert, pBigAlert, pAlert;

	//total alerness manage CPU
	public int c1TotalAlert, c2TotalAlert, c3TotalAlert, cBigAlert, cAlert;

	//Player turn
	public bool pTurn, cTurn;



	
	//Loading and checking the manager loads correctly

	private static GameManager manager;
	//singleton
	public static GameManager Instance
	{
		get
		{
			if(!manager)
			{
				Debug.Log("No manager, getting...");
				manager = FindObjectOfType(typeof(GameManager)) as GameManager;
				if(!manager)
				{
					Debug.LogError("Should be GM in level");
				}
			}
			return manager;
		}
	}



	// Use this for initialization
	void Start () {

    //initialize the file manager class
    FileManager.Instance.initialize();
    //who starts the turn, cpu or Player1
    ThrowDice();
    Damage.startState();
	
	}
	
	// Update is called once per frame
	void Update () {

		
	
	}

	/*calculates each time a random number and then its added to the alertness of the player read from XML
	 * The XML values are default and can be edited separately.
   * For now values are being dragged from another class, XML read soon. 
	 For now it would be done this way, priority P1 over CPU*/
	void ThrowDice()
	{

		//nota mandar pedir el alertness del XML
    //Nota: (alerness de clase damage) por el momento base stats clase damage
		p1TotalAlert = Random.Range(0, 5) + Damage.alertness;
    //si p1totalAlert es mayor a 5 se le resta 1
    if(p1TotalAlert > 5)
      p1TotalAlert = p1TotalAlert - 1;
    //si p2totalAlert es mayor a 5 se le resta 1
		p2TotalAlert = Random.Range(0, 5) + Damage.alertness;
    if(p2TotalAlert > 5)
      p2TotalAlert = p2TotalAlert - 1;
    //si p3totalAlert es mayor a 5 se le resta 1
		p3TotalAlert = Random.Range(0, 5) + Damage.alertness;
    if(p3TotalAlert > 5)
      p3TotalAlert = p3TotalAlert - 1;

    //gets the biggest number from 3 robots to get turns
    int[] pAlert = new [] {p1TotalAlert, p2TotalAlert, p3TotalAlert};
    int min = Mathf.Min(pAlert);
    int max = Mathf.Max(pAlert);

    Debug.Log(min);
    Debug.Log(pAlert);
    Debug.Log(max);


		//gets the biggest number above three

		pBigAlert = (Mathf.Max(Mathf.Max(p1TotalAlert, p2TotalAlert), p3TotalAlert));
		Debug.Log(pBigAlert);

		//cpu
		c1TotalAlert = Random.Range(0, 5) + Damage.alertness;
    //si c1totalAlert es mayor a 5 se le resta 1
    if(c1TotalAlert > 5)
      c1TotalAlert = c1TotalAlert - 1;
    //si c2totalAlert es mayor a 5 se le resta 1
    c2TotalAlert = Random.Range(0, 5) + Damage.alertness;
    if(c2TotalAlert > 5)
      c2TotalAlert = c2TotalAlert - 1;
    //si c3totalAlert es mayor a 5 se le resta 1
    c3TotalAlert = Random.Range(0, 5) + Damage.alertness;
    if(c3TotalAlert > 5)
      c3TotalAlert = c3TotalAlert - 1;

		//gets bigger number above three

		cBigAlert = (Mathf.Max(Mathf.Max(c1TotalAlert, c2TotalAlert), c3TotalAlert));
		Debug.Log(cBigAlert);

    //checks which one is bigger (add the one routine to activate player)
    //player turn
		if (pBigAlert > cBigAlert)
		{
			pTurn = true;
			cTurn = false;
      //cpu turn
      if (pBigAlert < cBigAlert)
      {
        cTurn = true;
        pTurn = false;

        //priority to player in case the values are the same over cpu
        if (pBigAlert == cBigAlert)
        {
          pTurn = true;
          cTurn = false;
        }
      }

		}
		if(pTurn = true)
    {
      //activar al player
    }
    else
    {
      //activar al cpu
    }

	}
}
