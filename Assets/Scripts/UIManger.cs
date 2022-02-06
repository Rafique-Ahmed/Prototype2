using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the namespace required to use Unity UI
//using UnityEngine.InputSystem;
using TMPro;
public class UIManger : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI countText;
	public TextMeshProUGUI star;
    public string startext="*";
  //  public string  st = "+";
    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        SetCountText();


        // Set the text property of the Win Text UI to an empty string, making the 'You Win' (game over message) blank
      //  star.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCountText(){
        count = count + 1;
		countText.text = "Count: " + count.ToString();
   // countText.text = count.ToString();

	if (count>=3 && count <5) 
	{           
         //   star.SetActive(true);
            star.text= startext;
	}
    else if (count>=5 && count<8) 
	{           
         //   star.SetActive(true);
            star.text= startext+startext;
	}
        else if (count>=8) 
	{           
         //   star.SetActive(true);
            star.text= startext+startext+startext;
	}
	}
}
