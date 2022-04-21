using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class DDZ
{
    public static void randomizeList(List<GameObject> AllObjects)
    {
        for (int i = 0; i < AllObjects.Count; i++)
        {
            GameObject temp = AllObjects[i];
            int randomIndex = UnityEngine.Random.Range(i, AllObjects.Count);
            AllObjects[i] = AllObjects[randomIndex];
            AllObjects[randomIndex] = temp;
        }
    }

    public static Vector3 GetRandomPointInBoxCollider(BoxCollider box)
    {
        Vector3 bLocalScale = box.transform.localScale;
        Vector3 boxPosition = box.transform.position;
        boxPosition += new Vector3(bLocalScale.x * box.center.x, bLocalScale.y * box.center.y, bLocalScale.z * box.center.z);

        Vector3 dimensions = new Vector3(bLocalScale.x * box.size.x,
                                 bLocalScale.y * box.size.y,
                                 bLocalScale.z * box.size.z);

        Vector3 newPos = new Vector3(UnityEngine.Random.Range(boxPosition.x - (dimensions.x / 2), boxPosition.x + (dimensions.x / 2)),
                             UnityEngine.Random.Range(boxPosition.y - (dimensions.y / 2), boxPosition.y + (dimensions.y / 2)),
                             UnityEngine.Random.Range(boxPosition.z - (dimensions.z / 2), boxPosition.z + (dimensions.z / 2)));
        return newPos;
    }

    public static T GetOneFromArray<T>(T[] array)
    {
        return array[UnityEngine.Random.Range(0, array.Length - 1)];
    }

    public static T GetOneFromList<T>(List<T> array)
    {
        return array[UnityEngine.Random.Range(0, array.Count)];
    }

    public static Texture GetOneFromArray(Texture[] array)
    {

        return array[UnityEngine.Random.Range(0, array.Length - 1)];
    }

    public static IEnumerator waitThenCallback(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback();
    }

   
}

public static class Extensions
{
   
    public static Transform getChildObjectOfname(this Transform target, string name)
    {
        if (target.name == name)
            return target;

        for (int i = 0; i < target.childCount; ++i)
        {
            var result = getChildObjectOfname(target.GetChild(i), name);

            if (result != null)
                return result;
        }

        return null;
    }

    public static float Remap(this float value, float from1, float to1, float from2, float to2, bool isClamped = false)
    {
        if (isClamped)
        {
            value = Mathf.Clamp(value, from1, to1);
        }
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    public static bool isInRange(this float value, float bottom, float top)
    {
        return (value >= bottom && value <= top);
    }

    public static string ScoreShow(int Score)
    {
        float Scor = Score;
        string result;
        string[] ScoreNames = new string[] { "", "k", "M", "B", "T", "aa", "ab", "ac", "ad", "ae", "af", "ag", "ah", "ai", "aj", "ak", "al", "am", "an", "ao", "ap", "aq", "ar", "as", "at", "au", "av", "aw", "ax", "ay", "az", "ba", "bb", "bc", "bd", "be", "bf", "bg", "bh", "bi", "bj", "bk", "bl", "bm", "bn", "bo", "bp", "bq", "br", "bs", "bt", "bu", "bv", "bw", "bx", "by", "bz", };
        int i;

        for (i = 0; i < ScoreNames.Length; i++)
            if (Scor < 900)
                break;
            else Scor = Mathf.Floor(Scor / 100f) / 10f;

        if (Scor == Mathf.Floor(Scor))
            result = Scor.ToString() + ScoreNames[i];
        else result = Scor.ToString("F1") + ScoreNames[i];
        return result;
    }

}
