using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using System.Text;
using System.Xml;
using System.Security.Cryptography;

public class FileManager : MonoBehaviour {

  //instance of FileManager
  private static FileManager instance;
  //holds aplication path
  private string path;


  //---------------INSTANTIATING--------//
  /*--------------------------------------
   * FileManager()
   * constructor, creates an instance of FileManeger 
   * if one does not exist
   * --------------------------------------------------*/

  public static FileManager Instance
  {
    get{
      if(instance == null)
      {
        instance = new GameObject ("FileManager").AddComponent<FileManager>();
      }
      return instance;
    }

  }

  //---------------------QUITTING--------------------------//
  /*------------------------------------------------------------
   * OnApplicationQuit()
   * -----------------------------------------------------------
   * called when aplication quits
   * ---------------------------------------------------------*/
  public void OnApplicationQuit()
  {
    destroyInstance();
  }

  //----------------Destroying------------------------------//
  //------------------------------------------------------------
  /*destroyInstance()
   * destroys the file manager instance
   * ---------------------------------------------------------*/
  public void destroyInstance()
  {
    print ("bye bye, destroyed instance");
    instance = null;
  }

  //----initialising current file manager-------------//
  /*----------------------------------------------------------
   * initialize()
   * --------------------------------------------------------
   * initializes the file manager
   * -----------------------------------------------------*/

  public void initialize()
  {
    print ("file manager initialized");

    //setting the data path
    path = Application.dataPath;
    print ("Path: " + path);

    //Check for and create the gamedata directory
    if(checkDirectory("gamedata") == false)
    {
      createDirectory("gamedata");
    }

  }
  //------ACCESING DATA PATHS-------------//
  /* accesing the data paths to read*/
   //Path to games data directory
  //Application.dataPath;
   //persistent data directory
    //Application.persistentDataPath; //iOS
   //temporary cache
    //Application.temporalyCachePath;
   //-----------------------------------*/

  //-------Checking the existance of directories---------------//
 // checkDirectory()
/*checks to see whenether the passed Directory exist, returning True
 * or false.
 * receiving a directory name to check*/
  private bool checkDirectory (string directory)
  {
    if (Directory.Exists (path + "/" + directory))
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  //--------------CREATING DIRECTORIES-------------//
  //createDirectory()
  //creates a new directory
  private void createDirectory (string directory)
  {
    print ("Creating directory: " + directory);
    Directory.CreateDirectory(path + "/" + directory);

    /*check for the directory data, if it exist
     * if not it will create it
     if it exist it will send an error to not overwrite it*/
    if(checkDirectory ("gamedata") == false)
    {
      createDirectory("gamedata");
    }
    else
    {
      print ("Error, current directory: " + directory + "already exist");
    }
  }

  //------------DELETING DIRECTORIES-----------------//
  //deletingDirectory()
  //deleting directory
  private void deleteDirectory (string directory)
  {
    //checking if firectory exist, if so deletes it
    if (checkDirectory(directory) == true)
    {
      print ("Deleting directory: " + directory);
      Directory.Delete(path + "/" + directory,true);
    }
    else
    {
      //if not, sends error message
      print ("Error: you are trying to delete the directory: " + directory + 
             "but it doesnt exist!");
    }
  }

  //------------FIND SUBDIRECTORIES-----------------//
  //findSubDirectories()
  //finds given subdirectories of a given directory
  public string [] findSubDirectories(string directory)
  {
    print ("Checking directory: " + directory + "for subdirectories");

    string [] subdirectoryList = Directory.GetDirectories(path + "/" + directory);
    return subdirectoryList;
  }
 
  //--------Listing Subdirectories-----------------//
  /* method returns a list of subdirectories
   * grab subdirectories in gamedata and list them */
  //string [] subDirectoryList = findsubdirectories("gamedata");

  //foreach(string subdirectory in subdirectoryList)
  //{
   // print("found: " + subdirectory);
  //}


  //-----------Listing directory contents---------//
  //findFiles()
  //returns the files from a given directory
  public string[] findFiles(string directory)
  {
    print("checking directory: " + directory + "for files");

    string[] fileList = Directory.GetFiles(path + "/" + directory);

    return fileList;
  }

  //------------checking files existance------------//
  //checkFile()
  //checks to see whether a file exist
  public bool checkFile(string filePath)
  {
    if(File.Exists(path + "/" + filePath))
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  //---------creating files----------------//
  //createFile()
  //creates a new file
  //receiving 4string directory, filename, file type and file data
  public void createFile(string directory, string filename, string filetype, string fileData)
  {
    print("Creating: " + directory + "/" + filename + "." + filetype);
    //checking if directory exist
    if(checkDirectory(directory) == true)
    {
      //checking the file does not already exist
      if(checkFile(directory + "/" + filename + "." + filetype) == false)
      {
        //create the file
        File.WriteAllText(path + "/" + directory + "/" + filename + "." + filetype, fileData);
      }
      else
      {
        print("The file " + filename + "already exist" + path + "/" + directory);
      }
    }
    else
    {
      print("unable to create file as the directory" + directory + "does not exist");
    }
  }

  //------------------READING FILES----------------------//
  //readFile()
  //Reads the file and return its contents
  public string readFile(string directory, string filename, string filetype)
  {
    print("Reading: " + directory + "/" + filename + "." + filetype);
    //check if directory exist
    if(checkDirectory(directory) == true)
    {
      if(checkFile(directory + "/" + filename + "." + filetype) == true)
      {
        //Read the file
        string fileContents = File.ReadAllText(path + "/" + directory + "/" + filename + "." + filetype);

        return fileContents;
      }
      else
      {
        print("the file: " + filename + "does not exist in " + path + "/" + directory);

        return null;
      }
    }
    else
    {
      print("unable to read the file as directory " + directory + "does not exist");

      return null;
    }
  }

  //----------------Deleting Files------------------------//
  //deleteFiles()
  //deletes a specified file
  public void deleteFile(string filePath)
  {
    if(File.Exists(path + "/" + filePath))
    {
      File.Delete(path + "/" + filePath);
    }
    else
    {
      print("unable to delete file as it does not exist");
    }
  }

  //---------------Updating Files---------------------//
  //updatefile()
  //updates a files contents
  public void updateFile(string directory, string filename, string filetype, string fileData, string mode)
  {
    print("updating " + directory + "/" + filename + "." + filetype);
    if(checkDirectory(directory) == true)
    {
      if(checkFile(directory + "/" + filename + "." + filetype) == true)
      {
        if(mode == "replace")
        {
          File.WriteAllText(path + "/" + directory + "/" + filename + "." + filetype, fileData);
        }
        else
        {
          print("the file " + filename + "does not exist" + path + "/" + directory);
        }
      }
      else
      {
        print("unable to create file as the directory " + directory + "does not exist");
      }
    }
  }
  /*
  //--------------WRITING XML---------------------------//
  //createNewXML()
  //creates a new XML file
  public void createXMLFile(string directory, string filename, string filetype, string fileData, string mode)
  {
    print("creating XML File" + directory);

    if(checkDirectory(directory) == true)
    {
      if(mode == "plaintext")
      {
        File.WriteAllText(path + "/" + directory + "/" + filename + "." + filetype, fileData);
      }
    }
    else
    {
      print("unable to create file as the directory " + directory + "does not exist");
    }
  }
*/
	
}

