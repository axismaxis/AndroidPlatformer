using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuoteManager : MonoBehaviour
{
	public List<string> Quotes;

    // Start is called before the first frame update
    void Start()
    {
		int quoteToPick = Random.Range(0, Quotes.Count);
		string textToReplace = Quotes[quoteToPick].Replace("\\n", "\n");
        GetComponent<UnityEngine.UI.Text>().text = textToReplace;
    }
}
