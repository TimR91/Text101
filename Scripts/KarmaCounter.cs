using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KarmaCounter : MonoBehaviour {

	private static KarmaCounter karma = null;
    private static readonly object karmaNum = new object();
    private static int clickcount;
    KarmaCounter()
    {

    }

    public static KarmaCounter Karma
    {
        get
        {
            lock (karmaNum)
                if (karma == null)
                {
                    karma = new KarmaCounter();
                }
            return karma;
        }
    }
}
