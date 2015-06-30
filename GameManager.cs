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
	public int p1TotalAlert, p2TotalAlert, p3TotalAlert, pBigAlert;

	//total alerness manage CPU
	public int c1TotalAlert, c2TotalAlert, c3TotalAlert, cBigAlert;

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
	
	}
	
	// Update is called once per frame
	void Update () {

		ThrowDice();
	
	}

	/*calculates each time a random number and then its added to the alertness of the player read from XML
	 * The XML values are default and can be edited separately.
	 For now it would be done this way, priority P1 over CPU*/
	void ThrowDice()
	{

		//nota mandar pedir el alertness del XML
		p1TotalAlert = Random.Range(0,5);
		p2TotalAlert = Random.Range(0, 5);
		p3TotalAlert = Random.Range(0, 5);

		//gets the biggest number above three

		pBigAlert = (Mathf.Max(Mathf.Max(p1TotalAlert, p2TotalAlert), p3TotalAlert));
		Debug.Log(pBigAlert);

		//cpu
		c1TotalAlert = Random.Range(0, 5);
		c2TotalAlert = Random.Range(0, 5);
		c3TotalAlert = Random.Range(0, 5);

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
        }
      }

		}
		

	}
}
