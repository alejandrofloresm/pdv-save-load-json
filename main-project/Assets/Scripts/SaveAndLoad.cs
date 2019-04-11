using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveAndLoad
{
    public static void Save(string jsonString, string filename = "save.json", string storePath = null) {
      if (storePath == null) {
        storePath = Application.dataPath + "/saves";
      }
      if (!Directory.Exists(storePath)) {
        Directory.CreateDirectory(storePath);
      }
      string fullPath = storePath + "/" + filename;
      File.WriteAllText(fullPath, jsonString);
    }

    public static string Load(string filename = "save.json", string storePath = null) {
      if (storePath == null) {
        storePath = Application.dataPath + "/saves";
      }
      string fullPath = storePath + "/" + filename;
      string loaded = null;
      if (File.Exists(fullPath)) {
        loaded = File.ReadAllText(fullPath);
      }
      return loaded;
    }
}
