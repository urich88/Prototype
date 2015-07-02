using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Collections.Generic;


[XmlRoot("Properties")]

public class RobotContainer : MonoBehaviour {

 [XmlArray("Robot") , XmlArrayItem("EveryRobot")]

  public EveryRobot[] Robot;

  //load xml

  public static RobotContainer Load(string path)
  {
    var robotContainer = RobotContainer.Load(Path.Combine(Application.dataPath, "Properties.xml"));
    var serializer = new XmlSerializer(typeof(RobotContainer));
    using(var stream = new FileStream(path, FileMode.Open))
    {
      return serializer.Deserialize(stream) as RobotContainer;
    }
  }
 
  //Loads the xml directly from the given string

  public static RobotContainer LoadFromText(string text)
  {
    var xmlData = @"<EveryRobot><Robot1 name = ""Robot1""><core><name>E1</name><hp>80</hp><currentHP>0</currentHP><maxHP>120</maxHP><presicion>0</presicion><curPresicion>0</curPresicion><maxPressicion>0</maxPressicion><swiftness>0</swiftness><curSwiftness>0</curSwiftness><maxSwiftness>0</maxSwiftness><offensive>0</offensive><curOffensive>0</curOffensive><maxOffensive>0</maxOffensive><armor>0</armor><curArmor>0</curArmor><maxArmor>0</maxArmor><alertness>1</alertness><curAlertness>0</curAlertness><maxAlertness>2</maxAlertness></core></EveryRobot>";
    var robotContainer = RobotContainer.LoadFromText(xmlData);
    var serializer = new XmlSerializer(typeof(RobotContainer));
    return serializer.Deserialize(new StringReader(text)) as RobotContainer;
  }






}
