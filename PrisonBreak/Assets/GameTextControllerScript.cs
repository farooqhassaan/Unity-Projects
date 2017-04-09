using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTextControllerScript : MonoBehaviour {

	public Text text;
	public Image bars_1, bars_2;
	public Transform target_1, target_2;
	public float speed;
	private enum States {cell, sheets_0, mirror, lock_0, sheets_1, cell_mirror, lock_1, freedom,corridor_0, stairs_0, 
		floor, closet_door, corridor_1, stairs_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print(myState);

		float step = speed * Time.deltaTime;
		bars_1.transform.position = Vector3.MoveTowards(bars_1.transform.position, target_1.position, step);
		bars_2.transform.position = Vector3.MoveTowards(bars_2.transform.position, target_2.position, step);


		if(myState == States.cell) {
			state_cell();
		} else if(myState == States.sheets_0) {
			state_sheets_0();
		} else if(myState == States.mirror) {
			state_mirror();
		} else if(myState == States.lock_0) {
			state_lock_0();
		} else if(myState == States.sheets_1) {
			state_sheets_1();
		} else if(myState == States.cell_mirror) {
			state_cell_mirror();
		} else if(myState == States.lock_1) {
			state_lock_1();
		} else if(myState == States.freedom) {
			state_freedom();
		}
		
	}
	
	void state_cell(){
		text.text = "You are in a prison cell, and you want to escape. There are some "
			+ "dirty sheets on the bed, a mirror on the wall, and the door is "
				+ "locked from the outside.\n\n"
				+ "Press S to view Sheets, M to view Mirror and L to view the Lock.";
		
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
		} else if(Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		} else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}
	}
	
	void state_sheets_0(){
		text.text = "You can't believe you sleep in these things. Surely it's time somebody changed them. "
			+ "The pleasures of prison life I guess!\n\n "
				+ "Press R to return to roaming your cell.";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_mirror(){
		text.text = "mirror";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		} else if(Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_0(){
		text.text = "lock_0";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_cell_mirror(){
		text.text = "cell_mirror";
		
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_1;
		} else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_1;
		}
	}
	
	void state_sheets_1(){
		text.text = "sheets_1";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		} 
	}
	
	void state_lock_1(){
		text.text = "lock_1";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		} else if(Input.GetKeyDown(KeyCode.O)){
			myState = States.freedom;
		}
	}
	
	void state_freedom(){
		text.text = "freedom";
	}
}
