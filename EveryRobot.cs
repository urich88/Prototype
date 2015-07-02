using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

public class EveryRobot
{
//each robot
  public Robot robot1;
  public Robot robot2;
  public Robot robot3;
  public Robot robot4;
  public Robot robot5;
  public Robot robot6;

//-----Loading XML FILE--------//
  public static EveryRobot Load(TextAsset xmlFile)
  {
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(EveryRobot));
    return xmlSerializer.Deserialize(new StringReader(xmlFile.text)) as EveryRobot;
  }

}


//--Every Stat of the robot---//
  [System.Serializable]
  public class Robot
  {
    //robot core
    [XmlAttribute("name")]
    public string Name;
    public int hp;
    public int currentHP;
    public int maxHP;
    public int presicion;
    public int curPresicion;
    public int maxPressicion;
    public int swiftness;
    public int curSwiftness;
    public int maxSwiftness;
    public int offensive;
    public int curOffensive;
    public int maxOffensive;
    public int armor;
    public int curArmor;
    public int maxArmor;
    public int alertness;
    public int curAlertness;
    public int maxAlertness;
   
    //left arm stats

    public int lahp;
    public int lacurrentHP;
    public int lamaxHP;
    public int lapresicion;
    public int lacurPresicion;
    public int lamaxPressicion;
    public int laswiftness;
    public int lacurSwiftness;
    public int lamaxSwiftness;
    public int laoffensive;
    public int lacurOffensive;
    public int lamaxOffensive;
    public int laarmor;
    public int lacurArmor;
    public int lamaxArmor;
    public int laalertness;
    public int lacurAlertness;
    public int lamaxAlertness;

    //right arm stats
   
    public int rahp;
    public int racurrentHP;
    public int ramaxHP;
    public int rapresicion;
    public int racurPresicion;
    public int ramaxPressicion;
    public int raswiftness;
    public int racurSwiftness;
    public int ramaxSwiftness;
    public int raoffensive;
    public int racurOffensive;
    public int ramaxOffensive;
    public int raarmor;
    public int racurArmor;
    public int ramaxArmor;
    public int raalertness;
    public int racurAlertness;
    public int ramaxAlertness;

    //legs stats
   
    public int lghp;
    public int lgcurrentHP;
    public int lgmaxHP;
    public int lgpresicion;
    public int lgcurPresicion;
    public int lgmaxPressicion;
    public int lgswiftness;
    public int lgcurSwiftness;
    public int lgmaxSwiftness;
    public int lgoffensive;
    public int lgcurOffensive;
    public int lgmaxOffensive;
    public int lgarmor;
    public int lgcurArmor;
    public int lgmaxArmor;
    public int lgalertness;
    public int lgcurAlertness;
    public int lgmaxAlertness;

    //chest stats

    public int chhp;
    public int chcurrentHP;
    public int chmaxHP;
    public int chpresicion;
    public int chcurPresicion;
    public int chmaxPressicion;
    public int chswiftness;
    public int chcurSwiftness;
    public int chmaxSwiftness;
    public int choffensive;
    public int chcurOffensive;
    public int chmaxOffensive;
    public int charmor;
    public int chcurArmor;
    public int chmaxArmor;
    public int chalertness;
    public int chcurAlertness;
    public int chmaxAlertness;

    //head stats

    public int hdhp;
    public int hdcurrentHP;
    public int hdmaxHP;
    public int hdpresicion;
    public int hdcurPresicion;
    public int hdmaxPressicion;
    public int hdswiftness;
    public int hdcurSwiftness;
    public int hdmaxSwiftness;
    public int hdoffensive;
    public int hdcurOffensive;
    public int hdmaxOffensive;
    public int hdarmor;
    public int hdcurArmor;
    public int hdmaxArmor;
    public int hdalertness;
    public int hdcurAlertness;
    public int hdmaxAlertness;

  }
//----------------------------//

