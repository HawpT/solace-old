using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour {

    public Unit currentUnit;
    private Renderer rend;
    public int x;
    public int y;
    public Color SaveColorOnMouseover;
    private Player LocalPlayer;
    public Text info;

	// Use this for initialization
	void Start () {
        currentUnit = null;
        rend = GetComponent<Renderer>();
        LocalPlayer = GameObject.Find("Player").GetComponent<Player>();
    }
    

    // Update is called once per frame
    void Update () {
        
	}
	
	void OnMouseEnter() {
        SaveColorOnMouseover = rend.material.color;
		rend.material.color = Color.blue;
        LocalPlayer.CurrentMouseOver = this;
        info.text = "Tile at location: " + x + "," + y
            + "\nCurrent Unit: " + currentUnit
            + "\n";

	}
	
	void OnMouseExit() {
        rend.material.color = SaveColorOnMouseover;
	}
	
	
	void OnMouseDown() {
        rend.material.color = Color.white;
        SaveColorOnMouseover = Color.white;

        Unit currentSelected = LocalPlayer.CurrentTarget;
        if (currentSelected != null)
        {
            currentSelected.MoveLocation(x, y);
        }
	}

    public bool IsEmpty()
    {
        return currentUnit == null;
    }
	
}
