using UnityEngine;
using System.Collections;

public class BackForthMovementIB : MonoBehaviour
{
    public enum OccilationFuntion { Sine, Cosine }

    public void Start()
    {
        //to start at zero
        StartCoroutine(Oscillate(OccilationFuntion.Sine, 1f));
        //to start at scalar value
        //StartCoroutine (Oscillate (OccilationFuntion.Cosine, 1f));
    }

    private IEnumerator Oscillate(OccilationFuntion method, float scalar)
    {
        while (true)
        {
            if (method == OccilationFuntion.Sine)
            {
                transform.position = new Vector3(Mathf.Sin(Time.time) * scalar, 1, 1);
            }
            else if (method == OccilationFuntion.Cosine)
            {
                transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, 1, 1);
            }
            yield return new WaitForEndOfFrame();
        }
    }
}