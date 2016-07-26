using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {intro, cell, cell_intro, cell_sink, bed, bed_sink, stains, stains_sink, sink_0, sink_1, mirror, mirror_sink, toilet, note, door, door_sink,
						 lock_0, lock_0_sink, lock_1, scratches, scratches_sink, cell_spoon, cell_mirror, freedom, corridor, corridor_left, corridor_right, corridor_dent,
						 corridor_exit, corridor_exit_dent, corridor_left_dent, corridor_right_dent, warped_metal, biohazard, jumpscare, brokenlock, window, handle, brokenlock_dent,
						 window_dent, stairwell, lobby, down, flooded,  body, death_monster, table_1, airvent_1, flooded_door_1, sealed_room_1, sealed_room_2, table_2, airvent_2, flooded_door_2,
						 flooded_door_3, airvent_3, table_3, drown_1, drown_2, main_doors, lobby_key, escape, reception, guard, computer, camera, receptionist,
						 lobby_2, end}
	private States myState;     

	// Use this for initialization 
	void Start () {
	myState = States.intro;
	}

	
	// Update is called once per frame
	void Update ()
	{ 
		print (myState); 
		if (myState == States.intro)					{state_intro ();}
		else if (myState == States.cell) 				{state_cell ();}
		else if (myState == States.cell_intro)			{state_cell_intro ();}
		else if (myState == States.cell_sink)			{state_cell_sink ();}
		else if (myState == States.bed) 				{state_bed ();} 
		else if (myState == States.bed_sink)			{state_bed_sink ();}
		else if (myState == States.door) 				{state_door ();}
		else if (myState == States.door_sink)			{state_door_sink ();} 
		else if (myState == States.lock_0) 				{state_lock_0 ();}
		else if (myState == States.lock_0_sink)			{state_lock_0_sink ();}
		else if (myState == States.lock_1) 				{state_lock_1 ();} 
		else if (myState == States.stains)				{state_stains ();}
		else if (myState == States.stains_sink)			{state_stains_sink ();}
		else if (myState == States.sink_0)				{state_sink_0 ();}
		else if (myState == States.sink_1)				{state_sink_1 ();}
		else if (myState == States.toilet)				{state_toilet ();}
		else if (myState == States.note)				{state_note ();} 
		else if (myState == States.scratches) 			{state_scratches ();}
		else if (myState == States.scratches_sink)		{state_scratches_sink ();}
		else if (myState == States.mirror) 				{state_mirror ();}
		else if (myState == States.mirror_sink)			{state_mirror_sink ();}
		else if (myState == States.cell_spoon) 			{state_cell_spoon ();}
		else if (myState == States.cell_mirror) 		{state_cell_mirror ();}
		else if (myState ==	States.freedom)				{state_freedom ();} 
		else if (myState == States.corridor)			{state_corridor ();}
		else if (myState == States.corridor_left)		{state_corridor_left ();}
		else if (myState == States.corridor_right)		{state_corridor_right ();}
		else if (myState == States.corridor_dent)		{state_corridor_dent ();}
		else if (myState == States.biohazard)			{state_biohazard ();}
		else if (myState == States.warped_metal)		{state_warped_metal ();}
		else if (myState == States.jumpscare)			{state_jumpscare ();}
		else if (myState == States.corridor_exit)		{state_corridor_exit ();} 
		else if (myState == States.corridor_exit_dent)	{state_corridor_exit_dent ();}
		else if (myState == States.corridor_left_dent)	{state_corridor_left_dent ();}
		else if (myState == States.corridor_right_dent) {state_corridor_right_dent ();} 
		else if (myState == States.brokenlock)			{state_brokenlock ();} 
		else if (myState == States.brokenlock_dent)		{state_brokenlock_dent ();} 
		else if (myState == States.window)				{state_window ();}
		else if (myState == States.window_dent)			{state_window_dent ();} 
		else if (myState == States.handle)				{state_handle ();} 
		else if (myState == States.stairwell)			{state_stairwell ();} 
		else if (myState == States.down)				{state_down ();}
		else if (myState == States.lobby)				{state_lobby ();}
		else if (myState == States.flooded)				{state_flooded ();}
		else if (myState == States.body)				{state_body ();}
		else if (myState == States.death_monster)		{state_death_monster ();}
		else if (myState == States.table_1)				{state_table_1 ();}
		else if (myState == States.table_2)				{state_table_2 ();}
		else if (myState == States.table_3)				{state_table_3 ();}
		else if (myState == States.flooded_door_1)		{state_flooded_door_1 ();}
		else if (myState == States.flooded_door_2)		{state_flooded_door_2 ();}
		else if (myState == States.flooded_door_3)		{state_flooded_door_3 ();}
		else if (myState == States.sealed_room_1)		{state_sealed_room_1 ();}
		else if (myState ==	States.sealed_room_2)		{state_sealed_room_2 ();}
		else if (myState == States.airvent_1)			{state_airvent_1 ();}
		else if (myState == States.airvent_2)			{state_airvent_2 ();}
		else if (myState == States.airvent_3)			{state_airvent_3 ();}
		else if (myState == States.drown_1)				{state_drown_1 ();}
		else if (myState == States.drown_2)				{state_drown_2 ();}
		else if (myState == States.lobby_key)			{state_lobby_key ();}
		else if (myState == States.lobby_2)				{state_lobby_2 ();}
		else if (myState == States.guard)				{state_guard ();}
		else if (myState == States.reception)			{state_reception ();}
		else if (myState == States.receptionist)		{state_receptionist ();}
		else if (myState == States.main_doors)			{state_main_doors ();}
		else if (myState == States.escape)				{state_escape ();}
		else if (myState == States.computer)			{state_computer ();}
		else if (myState == States.camera)				{state_camera ();}
		else if (myState == States.end)					{state_end ();} 
		} 


		// This is Scene 0 - The introduction 
	void state_intro () {
			text.text = "Welcome to Experiment. Experiment is a text based choose your own adventure game created by Kitsunami Lupo. " + 
						"\n\nPlease press the space key to start"; 
		if (Input.GetKeyDown(KeyCode.Space)) 			{myState = States.cell_intro;} 
						}

	// This is the cell intro
	void state_cell_intro () {
			text.text = "You awaken to a bitter chill." +
			"\n\nThe only light comes from the dim glow of a single white striplamp overhead. You look around the room from the Bed. " +
			"You find yourself in a room with four gray walls, a locked metal Door, and no windows. " +
			"In the corner lies a simple toilet with a Sink and mirror but aside from that the room is empty and very, very cold. " +
			"\n\nPress B to view the Bed, D to view the Door or S to view Sink."; 
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.door;}
		if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.bed;}
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.sink_0;}
		}

	// This is the cell
	void state_cell () {
			text.text = "You are in the cell. The only light comes from the dim glow of a single white striplamp overhead. " +
			"The room has four gray walls, a locked metal Door, and no windows. " +
			"In the corner lies a simple toilet with a Sink and mirror but aside from that the room is empty and very, very cold. " +
			"\n\nPress B to view the Bed, D to view the Door or S to view Sink."; 
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.door;}
		if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.bed;}
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.sink_0;}
		}

	
	// Door 
	void state_door ()	{
			text.text = "You see a thick metal door. It seems very sturdy. It has no window, " +
			"but you can see several thick grooves scraped into the surface by...something." +
			"\n\nPress R to Return, S to look at the Scratchs or L to try the Lock"; 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.cell;}
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.scratches;}
		if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.lock_0;} 
		}

	// Scratches 
	void state_scratches ()	{
			text.text = "The metal is very thick and heavy. It seems strong. Yet somehow, " +
			"something has scratched thick, deep grooves into the metal. On closer inspection you find dark red splatters around the scratchs." +
			"Clearly, something wanted out of this room." + 
			"\n\nPress R to return"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.door;}
		}

	// Locked door 
	void state_lock_0 ()	{
			text.text = "You reach out and try the handle. Click. " +
			"Something is blocking the Lock. You peer at the hole, but you can't see anything." +
			"If only you had something to push into the keyhole..." + 
			"\n\nPress R to Return"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.door;}
		}

	// Bed 
	void state_bed () { 
			text.text = "You see a metal frame with a simple flat matress and a single cloth sheet. " +
			"The matress has some dark Stains. You don't want to know what they are." +
			"Judging by the pain in your back, it's not very comfortable." +
			"\n\nPress R to Return, or S to examine the Stains"; 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.cell;}
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.stains;}		
		}

	// Stains 
	void state_stains () {
			text.text = "You decide to examine the stains further. You notice they spread across the entire matress, " +
			"and down the side towards the floor. The crimson stains are scattered underneath the bed leaving " +
			"a grisly impression. You are suddenly aware of the claw marks amongst the splattered stone and bloody hand prints. " +
			"You are starting to regret looking at the matress now." +
			"\n\nPress R to Return";
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.bed;} 
		}

	// Sink
	void state_sink_0 () {
			text.text = "You can see a toilet. It appears to be blocked. To the side, you see a simple sink " +
			"And above that, a plain mirror. The glass is coated with black smears, you can't see a reflection " +
			"\n\nPress M to take the Mirror, T to check the Toilet, or R to Return."; 
		if (Input.GetKeyDown(KeyCode.M)) 				{myState = States.cell_mirror;}
		if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.toilet;} 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.cell;} 
		}

	// Toilet 
	void state_toilet () {
			text.text = "You decide to check the toilet. The smell causes your eyes to water as you bend down and reach inside " +
			"to tug on whatever is causing the blockage. You find a small plastic container, which you quickly take to the sink " +
			"and rinse clean, followed by your hands. It seem's the water is still running here. Which is great, because your hands " +
			"were covered in a thick, slimy red and black mess." +
			"\n\nPress B to open the Bottle, or R to Return."; 
		if (Input.GetKeyDown(KeyCode.B))				{myState = States.note;}
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.cell_sink;}
		}

	// This is the cell without the blocked toilet. 
	void state_cell_sink () {
			text.text = "You are in the cell. The only light comes from the dim glow of a single white striplamp overhead. " +
			"The room has four gray walls, a locked metal Door, and no windows. " +
			"In the corner lies a simple toilet with a Sink and mirror but aside from that the room is empty and very, very cold. " +
			"\n\nPress B to view the Bed, D to view the Door or S to view Sink."; 
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.door_sink;}
		if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.bed_sink;}
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.sink_1;}
		}

	// Door without the blocked toilet. 
	void state_door_sink ()	{
			text.text = "You see a thick metal door. It seems very sturdy. It has no window, " +
			"but you can see several thick grooves scraped into the surface by...something." +
			"\n\n Press R to Return, S to look at the Scratchs or L to try the Lock"; 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.cell_sink;}
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.scratches_sink;}
		if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.lock_0_sink;} 
		}

	// Scratches without the blocked toilet
	void state_scratches_sink ()	{
			text.text = "The metal is very thick and heavy. It seems strong. Yet somehow, " +
			"something has scratched thick, deep grooves into the metal. On closer inspection you find dark red splatters around the scratchs." +
			"Clearly, something wanted out of this room." + 
			"\n\nPress R to return"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.door_sink;}
		}

	// Locked door without the blocked toilet 
	void state_lock_0_sink ()	{
			text.text = "You reach out and try the handle. Click. " +
			"Something is blocking the Lock. You peer at the hole, but you can't see anything." +
			"If only you had something to push into the keyhole..." + 
			"\n\nPress R to Return"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.door_sink;}
		}

	// Bed without blocked toilet
	void state_bed_sink () { 
			text.text = "You see a metal frame with a simple flat matress and a single cloth sheet. " +
			"The matress has some dark Stains. You don't want to know what they are." +
			"Judging by the pain in your back, it's not very comfortable." +
			"\n\nPress R to Return, or S to examine the Stains"; 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.cell_sink;}
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.stains_sink;}		
		}

	// Stains without blocked toilet
	void state_stains_sink () {
			text.text = "You decide to examine the stains further. You notice they spread across the entire matress, " +
			"and down the side towards the floor. The crimson stains are scattered underneath the bed leaving " +
			"a grisly impression. You are suddenly aware of the claw marks amongst the splattered stone and bloody hand prints. " +
			"You are starting to regret looking at the matress now." +
			"\n\nPress R to Return";
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.bed_sink;} 
		}

	// Note 
	void state_note () {
		text.text = "You open the bottle. Inside, you find a crumpled note coated in a black goo. You carefully open the note. " +
		"'If you are reading this than I am already dead and have been unable to escape. " +
		"they injected me with something. My blood burns, my body twists and all is agony " +
		"I can barely see. They have taken my eyes. My body feels wrong. I managed to twist the lock " +
		"but it has jammed and my hands have grown too big to fit. You, you must escape. Take the spoon behind the mirror " +
		"and use it to escape!' " +
		"\n\nPress R to Return"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.sink_1;}
		}

	// Sink with Note
	void state_sink_1 () {
			text.text = "You can see a toilet. It is no longer blocked. To the side, you see a simple sink " +
			"And above that, a plain mirror. The glass is coated with black smears, you can't see a reflection " +
			"\n\nPress M to take the Mirror or R to Return."; 
		if (Input.GetKeyDown(KeyCode.M)) 				{myState = States.mirror_sink;}
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.cell_sink;} 
		}

	// Mirror without blocked toilet. 
	void state_mirror_sink () {
		text.text = "You look at the mirror. The glass is smeared with a stream of some sort of thick, black goo and something " +
		"that might be a handprint. The glass is also cracked, and though you rub at the mirror with your fingers you only " +
		"succeed in spreading the goo across the glass. You cannot see your reflection." +
		" \n\nPress R to Return or E to Examine the mirror."; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.cell_sink;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.cell_spoon;} 
		}

	// Mirror 
	void state_mirror () {
		text.text = "You look at the mirror. The glass is smeared with a stream of some sort of thick, black goo and something " +
		"that might be a handprint. The glass is also cracked, and though you rub at the mirror with your fingers you only " +
		"succeed in spreading the goo across the glass. You cannot see your reflection." +
		" \n\nPress R to Return or E to Examine the mirror."; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.cell;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.cell_spoon;}
		}

	// Getting the Spoon 
	void state_cell_spoon () {
		text.text = "You tug on the mirror and to your shock it comes off the wall almost immediately. You stumble and regain " +
		"your balance as something clatters to the floor. You place the mirror on the bed, and look down. Below you see a spoon. " +
		"You pick up the spoon and wonder if you could use this to escape somehow." +
		"\n\nPress R to Return";
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.cell_mirror;} 
		}

	//Cell with Spoon and Mirror down
	void state_cell_mirror () {
		text.text = "You look around the room, holding onto the spoon. The mirror now lies on the bed where you left it. Perhaps " +
		"now you have a way to get out of this cell?" + 
		"\n\nPress L to try the Lock again."; 
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.lock_1;} 
		}

	// Opening the lock 
	void state_lock_1 () {
		text.text = "You move back to the door and take the spoon in your hand. Carefully, you hold onto the top and push the end " +
		"into the hole and turn. To your satisfaction you hear a loud click followed by a snap as the spoon breaks off into the lock. " +
		"You hope that wasn't the sound of the lock getting stuck. Trembling, you turn the handle and are rewarded with a loud screech " +
		"as the metal of the frame scrapes across the flooring. It is the most beautiful sound you have ever heard. The door is open. " + 
		"\n\nPress E to Exit the cell."; 
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.freedom;} 
		}

	// Exiting the cell 
	void state_freedom () {
		text.text = "You cautiously step out of the cell. Immediately, you have to shield your eyes from the bright " +
		"lighting of the strips overhead. The smell of bleach and disinfectant assaults your nose and as your eyes " +
		"adjust you find yourself in the middle of a long white corridor. To the Left you see several closed cell doors " +
		"leading down to the end of the corridor. To the Right, you see a single closed doorway with a bright red " +
		"light flickering overhead. Directly ahead of you, you see a red sealed doorway with the word 'Exit' above." + 
		"\n\nPress L to go Left, R to go Right or E to investigate the Exit door"; 
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.corridor_left;}
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor_right;} 
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.corridor_exit;} 
		}

	// Going Left
	void state_corridor_left () {
		text.text = "You decide to investigate the cells to the left. As you approach, you hear a distant scream making your blood run " +
		"cold. Supressing a shudder, you peer into the various cells as you pass to the end of this side of the corridor. Each of them is " +
		"closed, sealed and empty. You wonder if you are the only person being held here. Finally, you reach the end of the row of cells. " +
		"there was nothing of interest here. Perhap's you should try the other side?" +
		"\n\nPress R to Return to the corridor";
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor;} 
		}

	//The default corridor 
	void state_corridor () {
		text.text = "You are back in the corridor outside of your cell. You have grown used to the smell, oddly enough it reminds you of " +
		"a hospital. To the Left you see several closed doors leading down to the end of the corridor. To the Right, you see a single closed " +
		"doorway with a bight red light flickering overhead. Directly ahead of you, you see a red sealed doorway with the word 'Exit' above." +
		"\n\nPress L to go Left, R to go Right or E to investigate the Exit door."; 
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.corridor_left;}
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor_right;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.corridor_exit;}
		}

	// Using the Exit 
	void state_corridor_exit () {
		text.text = "You decide to try the exit door. It appears to be locked and sealed. To the side is a electronic keycard Lock, the light is red. " +
		"Beneath the Lock is a metal handle with no keyhole. You assume that if the keycard is swiped, the Handle will open the door. " + 
		"in the centre of the door is a reinforced glass panel. You need to get closer to View the other side." +
		"\n\nPress L to view the keycard Lock, H to try the Handle, or V to view the other side"; 
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.brokenlock;} 
		if (Input.GetKeyDown(KeyCode.H))				{myState = States.handle;}
		if (Input.GetKeyDown(KeyCode.V))				{myState = States.window;}
		}

	// Broken Electric Card Lock 
	void state_brokenlock () {
		text.text = "You examine the keycard lock. The screen is smashed but you can see the color coded LED's on the side of the machine. " +
		"The red light is active for the Lock. You may need to find a Keycard to open this door. Perhap's if you search this Corridor thoroughly?" +
		"\n\nPress R to Return to the Corridor or E to continue examining the Exit door"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.corridor_exit;}
		}

	// Broken Electric Card Lock (dented)
	void state_brokenlock_dent () {
		text.text = "You examine the keycard lock. The screen is smashed but you can see the color coded LED's on the side of the machine. " +
		"The red light is active for the Lock. You may need to find a Keycard to open this door. Perhap's if you search this Corridor thoroughly?" +
		"\n\nPress R to Return to the Corridor or E to continue examining the Exit door"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor_dent;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.corridor_exit_dent;}
		}

	// Window 
	void state_window () {
		text.text = "You move closer to the window and peer through the glass. You can see a stairwell, with staircases leading Up and Down." +
		"For a moment you think you can see something moving at the edge of your vision heading Down the staircase" +
		"but it could have been your imagination. The glass is reinforced with metal wiring, and it appears to be very sturdy. Certainly " +
		"it is too small for anything to fit through even if you could break the glass." + 
		"\n\nPress R to Return to the Corridor, or E to continue examining the Exit door"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.corridor_exit;}
		}

	// Window (Dented) 
	void state_window_dent () {
		text.text = "You move closer to the window and peer through the glass. You can see a stairwell, with staircases leading Up and Down." +
		"For a moment you think you can see something moving at the edge of your vision heading Down the staircase" +
		"but it could have been your imagination. The glass is reinforced with metal wiring, and it appears to be very sturdy. Certainly " +
		"it is too small for anything to fit through even if you could break the glass." + 
		"\n\nPress R to Return to the Corridor, or E to continue examining the Exit door"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor_dent;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.corridor_exit_dent;}
		}

	// Using the Exit (dented) 
	void state_corridor_exit_dent () {
		text.text = "You decide to try the exit door. It appears to be locked and sealed. To the side is a electronic keycard Lock, the light is red. " +
		"Beneath the Lock is a metal handle with no keyhole. You assume that if the keycard is swiped, the Handle will open the door. " + 
		"in the centre of the door is a reinforced glass panel. You need to get closer to View the other side." +
		"\n\nPress L to view the keycard Lock, H to try the Handle, or V to view the other side"; 
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.brokenlock_dent;} 
		if (Input.GetKeyDown(KeyCode.H))				{myState = States.handle;}
		if (Input.GetKeyDown(KeyCode.V))				{myState = States.window_dent;}
		}

	// Going Right
	void state_corridor_right () {
		text.text = "You decide to investigate the closed doorway to the right. As you approach you are bathed in the red glow of " +
		"the spinning red light overhead. You notice that the sealed doorway is metal, incredibly thick metal. It looks like something " +
		"you might see in a bunker. Yet the metal appears warped and Dented in places, as if something heavy had slammed into the metal from the other "+
		"side with great force. Though, the blast doors seem to be sealed tight and that comforts you. You notice a bright yellow and black Symbol lit up " +
		"over the doorways access panel. What could that mean?" +
		"\n\nPress P to view the Panel, D to examine the dented metal, or R to Return to the corridor"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor;} 
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.warped_metal;}
		if (Input.GetKeyDown(KeyCode.P))				{myState = States.biohazard;}
		}

	//Panel 
	void state_biohazard () {
		text.text ="You examine the panel. This appears to be some sort of touch screen interface, but when you touch it nothing happens. All " +
		"you can see is a black and yellow symbol. It looks like those radioactive symbols you see in science fiction. What could " +
		"it mean?" +
		"\n\nPress R to Return to the corridor, or D to examine the warped metal."; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor;} 
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.warped_metal;} 
		}

	//Dented Metal - Leads to jumpscare and chain.
	void state_warped_metal () {
		text.text ="You lean closer to the metal and run your hand over the warped metal. It is incredibly cold to the touch, and very heavy. You " +
		"are certain this is some sort of emergency blast doorway. What could be behind it?" +
		"\n\nPress C to return to the Corridor, L to Listen at the door or P to examine the access panel.";
		if (Input.GetKeyDown(KeyCode.P))				{myState = States.biohazard;}
		if (Input.GetKeyDown(KeyCode.C))				{myState = States.corridor;}
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.jumpscare;}
		}

	// Jumpscare and sound test.
	void state_jumpscare () {
	SoundManager.instance.PlaySound("metalbangs");
		text.text = "Something big just hit the door! The metal creaks under the pressure and several more dents appear as the metal is warped and pushed forwards. You " +
		"hear a frustrated screech and a bloodcurdling snarl. Now seems like an excellent time to Leave." +
		"\n\nPress C to run back to the Corridor"; 
		if (Input.GetKeyDown(KeyCode.C))				{myState = States.corridor_dent;}
		}

	// Going Left (Dented) 
	void state_corridor_left_dent () {
		text.text = "You decide to investigate the cells to the left. As you approach, you hear the distant thud of metal being hit with something heavy, making your blood run " +
		"cold. Supressing a shudder, you peer into the various cells as you pass to the end of this side of the corridor. Each of them is " +
		"closed, sealed and empty. You wonder if you are the only person being held here. Finally, you reach the end of the row of cells. " +
		"there was nothing of interest here. Perhap's you should try the Exit door?" +
		"\n\nPress R to Return to the corridor";
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor_dent;} 
		}

	//The default corridor (Dented!) 
	void state_corridor_dent () {
		text.text = "You are back in the corridor outside of your cell. You have grown used to the smell, oddly enough it reminds you of " +
		"a hospital. To the Left you see several closed doors leading down to the end of the corridor. To the Right, you see a single closed " +
		"doorway with a bight red light flickering overhead. Directly ahead of you, you see a red sealed doorway with the word 'Exit' above." +
		"\n\nPress L to go Left, R to go Right or E to investigate the Exit door."; 
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.corridor_left_dent;}
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.corridor_right_dent;}
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.corridor_exit_dent;}
		}

	// Going Right (Dented) 
	void state_corridor_right_dent () {
		text.text = "You can hear the distant thud and screech of something hitting the metal blast doors. You really don't want to go " +
		"that way again." +
		"\n\nPress R to Return to the Corridor"; 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.corridor_dent;} 
		}

	//Handle (This progresses to the Stairwell!) 
	void state_handle () {
		text.text = "You decide to try the handle. To your amazement and shock, when you turn the handle the door simply opens. On closer " +
		"inspection it appears as though somebody had already forced the locking mechanism open. You decide to step through into the Stairwell, " +
		"closing the door behind you. Suddenly the door snaps shut with a electronic chime, and the hear the emergency bolts latching into place. " +
		"Well. You won't be going back that way!" +
		"\n\nPress U to go Up the staircase, or D to go Down."; 
		if (Input.GetKeyDown(KeyCode.U))				{myState = States.lobby;}
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.down;} 
		}

	// Stairwell (default) 
	void state_stairwell () {
		text.text = "You return to the stairwell and look at the doorway. It is still bolted shut. The sign at the side on the wall states " +
		"'B-1' which suggests that you were underground somehow. You can see the Staircases that go Up or Down. Which way should you go now?" +
		"\n\nPress U to go Up the Staircase, or D to go Down."; 
		if (Input.GetKeyDown(KeyCode.U))				{myState = States.lobby;}
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.down;}
		}

	// Down the Stairs 
	void state_down () {
		text.text = "You decide to try your luck downstairs. Cautiously you make your way down " +
		"You feel the sudden chill of cold water beneath you at the next step. It seems that the steps below you are underwater. You can just see " +
		"a dim red glow beneath the stairs. Clearly there are more levels below, but they are inaccessible. You walk into the water and onto the landing. The water is " +
		"now at your hips and causing you difficulty in moving. The door here is open wide, the pressure of the water keeping it from closing. You look down the corridor and see " + 
		"a nearby room with a doorway half-open. Further down the corridor you can just make out a white covered form, floating. Is that a body? " +
		"\n\nPress B to investigate the Body, D to check the open Doorway or R to Return";
		if (Input.GetKeyDown(KeyCode.B))				{myState = States.body;}
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.stairwell;}
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.flooded;} 
		}

	// Checking the body 
	void state_body () {
		text.text = "You decide to check the body for something useful. As you wade through the cold water you can feel it growing deeper the further you go down the corridor. " +
		"By the time you reach the body the water is almost at your waist. You can see the body of a man, facedown. He wears a long white labcoat and black trouses. As you reach " +
		"the body you feel something brush against your legs. What was that?" + 
		"\n\nPress C to continue Checking the body, R to Return or D to make for the Doorway"; 
		if (Input.GetKeyDown(KeyCode.C))				{myState = States.death_monster;}
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.stairwell;} 
		if (Input.GetKeyDown(KeyCode.D))				{myState = States.flooded;} 
		}

	// Death by Monster
	void state_death_monster () {
		text.text = "You decide to ignore the brushing sensation and continue checking the body. As you reach to turn the man over, you catch a glimpse of movement behind you. " +
		"You turn to look and lose your footing as something suddenly slams into your legs throwing you backwards. You scream as you land on the body. The last thing you see before " +
		"the darkness swallows you whole is an impressively huge maw, full of razor sharp teeth. There is a sharp pain and then, thankfully, nothing. Well, at least you know what " +
		"killed the scientist." +
		"\n\nYou Are Dead" + 
		"\nPress P to Play Again"; 
		if (Input.GetKeyDown(KeyCode.P))				{myState = States.intro;}
		}

	// Flood 
	void state_flooded () {								{myState = States.flooded;}
		text.text = "You are going to check on the flooded doorway. You cautiously push through the water to the door and peer inside. You cannot make much out. Carefully, you " +
		"push upon the metal door until it gives way just enough for you to slip inside. Inside, you see an empty white room with a simple Airvent near the ceiling, a small table " + 
		"and a large glass mirror covering " +
		"one side of the wall. Dissapointed, you turn around to leave only to see the door slam shut from the increasing water pressure! Startled, you look down. " +
		"the water temporarily recedes down to your ankles, but you can already feel it rising. You need to get out of here!" +
		"\n\nPress D to try the Door, A to reach up to the Airvent or T to examine the Table"; 
		if (Input.GetKeyDown(KeyCode.D)) 				{myState = States.flooded_door_1;}
		if (Input.GetKeyDown(KeyCode.A))				{myState = States.airvent_1;}
		if (Input.GetKeyDown(KeyCode.T))				{myState = States.table_1;}
		}

	// Flooded Door
	void state_flooded_door_1 () {
		text.text = "You frantically push against the metal door. It doesn't budge. The water continues to rise at a faster pace now, it's already reaching your knees. " +
		"You really need to find a way out of this room and quickly, or you are going to drown here!" +
		"\n\nPress R to Return to examining the Room"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.sealed_room_1;}
		}

	// Flooded Airvent
	void state_airvent_1 ()		{
		text.text = "You reach towards the Airvent. It's far too high up. The water continues to rise at a faster pace now, it's already reaching your knees. " +
		"If only you had something you could Stand on...maybe you could reach the vent?" +
		"\n\nPress R to Return to examining the Room"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.sealed_room_1;}
		}

	// Flooded Table 
	void state_table_1 () {
		text.text = "You walk over to the table and push, hard. Despite all of your straining, it doesn't budge. Further examination shows you that it's bolted to the floor. " +
		"The water continues to rise at a faster pace now, it's already reaching your knees. You need to find some way to get out of this room. Maybe the Door will open if you " +
		"use enough force?" +
		"\n\nPress R to Return to examining the Room"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.sealed_room_1;}
		}

	// Sealed Room 
	void state_sealed_room_1 () {
		text.text = "You are in the sealed room with water rising up to your knees. There is a Table in the centre of the room, a long mirror across one of the walls and an Airvent " +
		"near the ceiling. The Door is shut. You really need to find another way out of this room." +
		"\n\n Press T to examine the Table, A to attempt to reach the Airvent or D to force the Door"; 
		if (Input.GetKeyDown(KeyCode.D)) 				{myState = States.flooded_door_2;}
		if (Input.GetKeyDown(KeyCode.A))				{myState = States.airvent_2;}
		if (Input.GetKeyDown(KeyCode.T))				{myState = States.table_2;}
		}

	// Flooded Door 2
	void state_flooded_door_2 () {
		text.text = "You throw yourself against the door, cringing as you hit the metal. When that doesn't work, you push and shove but the door remains closed. The water continues to rise " +
		"It is now just above your chest. You are finding it difficult to move and the water is extremely cold. There has be some way out of here!" +
		"\n\nPress R to Return to examining the Room"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.sealed_room_2;}
		}

	// Flooded Airvent 2
	void state_airvent_2 ()		{
		text.text = "You wave your arms about in your efforst to reach the Airvent. Unfortunately, you are not tall enough to reach. Maybe if you could stand on something? "+
		"The water continues to rise. It is now just above your chest. You are finding it difficult to move and the water is extremely cold. There has to be some way out of here!" + 
		"\n\nPress R to Return to examining the Room"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.sealed_room_2;}
		}

	// Flooded Table 2
	void state_table_2 () {
		text.text = "You tug, push and shove the metal table but it refuses to budge. It must be bolted to the floor, though with the rising water you are unable to check that for yourself. " +
		"The water continues to rise. It is now just above your chest. You are finding it difficult to move and the water is extremely cold. There has to be some way out of here!" + 
		"\n\nPress R to Return to examining the Room"; 
		if (Input.GetKeyDown(KeyCode.R))				{myState = States.sealed_room_2;}
		}

	// Sealed Room 2
	void state_sealed_room_2 () {
		text.text = "You are still in the sealed room and you really, really want to get out of it. The water is now just below your neck. It is extremely cold and you are shivering. " +
		"You are now having to swim to stay afloat. The Door is submerged entirely, as is the Table. You can see the Airvent just above you. Is there anyway out of this mess?" +
		"\n\nPress T to examine the Table, A to attempt to reach the Airvent or D to try and force the Door"; 
		if (Input.GetKeyDown(KeyCode.D)) 				{myState = States.flooded_door_3;}
		if (Input.GetKeyDown(KeyCode.A))				{myState = States.airvent_3;}
		if (Input.GetKeyDown(KeyCode.T))				{myState = States.table_3;}
		}

	// Flooded Door 3
	void state_flooded_door_3 () {
		text.text = "You take a deep breath and plunge into the icy waters. You swim for the Door and push on it with all of your might! It refuses to budge. In desperation you hammer on the metal " +
		"with your fists until you feel your lungs burning for air. You need to breath!" + 
		"\n\nPress S to Swim for the Ceiling"; 
		if (Input.GetKeyDown(KeyCode.S))				{myState = States.drown_1;}
		}

	// Flooded Airvent 3
	void state_airvent_3 ()		{
		text.text = "You take several long deep breaths to prepare yourself for the trial ahead. Once the water has risen" +
		"You reach up to the airvent and tug, hard. To your suprise it comes free with a satifying crack and you are able to squeeze into the opening. You pull yourself up out of the water " +
		"and begin to crawl through the opening. You can't help but grin at your daring escape from death but then as you pull yourself through the narrow vents you suddenly find yourself " +
		"stuck. You wiggle, but your sides are pinned to the metal. You attempt to go backwards, but you cannot get any grip with your feet. You can hear the water " +
		"rushing into the vents behind you, already your feet feel wet. You have to break free!" +
		"\n\nPress S to Struggle and attempt to break free"; 
		if (Input.GetKeyDown(KeyCode.S))				{myState = States.drown_2;}
		}

	// Flooded Table 3
	void state_table_3 () {
		text.text = "You take a deep breath and plunge into the icy waters. You swim for the Table and tug on it with all of your might! It refuses to budge. In desperation you hammer on the metal with " + 
		"your fists until you feel your lungs burning for Air. You need to breath!" +
		"\n\nPress S to Swim for the Ceiling"; 
		if (Input.GetKeyDown(KeyCode.S))				{myState = States.drown_1;}
		}

	// Drowning in the Room
	void state_drown_1 () {
		text.text = "You swim for the ceiling. Within moments, your face is pressing against the cold tiling. You gasp for air. The waters are still rising! You take one last deep breath before the water " +
		"completely fills the room. You have no escape! Your lungs burn." +
		"You have no choice. You slam yourself into the ceiling, pressing your hands against the tiles. Desperately, you try to force your way through. Nothing. You lungs can hold no longer " +
		"and you open your mouth for air. Your lungs are flooded with water and you frantically flail in the darkness as the lights sizzle out. Finally, blissfully, you pass out. " +
		"\n\nYou Are Dead" +
		"\nPress P to Play Again"; 
		if (Input.GetKeyDown(KeyCode.P))				{myState = States.intro;}
		}

	// Drowning in the vent.
	void state_drown_2 () {
		text.text = "You Struggle violently, pushing against the metal walls of the Airvent. Nothing happens. Despite your best efforts, you are simply too big to continue forwards. You are " +
		"well and truly stuck. You cannot find enough grip to pull yourself backwards and your struggling only makes it worse. You can feel the cold water beneath you. You close your eyes " +
		"and let the darkness consume you." +
		"\n\nYou Are Dead" +
		"\nPress P to Play Again"; 
		if (Input.GetKeyDown(KeyCode.P))					{myState = States.intro;}
		}

	// Up the Stairs 
	void state_lobby () {
		text.text = "You walk up the stairs, carefully approaching the top. Though they continue upwards you can see a metal gate blocking the next set of stairs. Instead, you " +
		"turn and open the doorway behind you that enters the first floor. You find yourself in a lobby, with clean white walls, a lovely red carpet and a brightly lit Reception desk. " +
		"across from the desk you can see massive tinted glass walls and two large sealed doors. These have to be the Main Doors. To the side sits a Guard on a chair. He appears to be asleep. " +
		"\n\n Press M to approach the Main doors, R to look at the Reception desk, or G to examine the Guard";
		if (Input.GetKeyDown(KeyCode.M))					{myState = States.main_doors;}
		if (Input.GetKeyDown(KeyCode.R))					{myState = States.reception;}
		if (Input.GetKeyDown(KeyCode.G))					{myState = States.guard;}
		}

	// Main Doors Lobby
	void state_main_doors () {
		text.text = "You approach the main doors and look at the glass. The glass appears to be tinted, it is difficult to see through the black color. The doors themselves are sealed and the glass " +
		"appears to be very thick and secure. Perhap's bulletproof? It seems to be reinforced with a steel frame and a keycard lock. The lock is red. These doors will not be opening soon. You peer through " +
		"the glass. You can make our moving figures and shapes but nothing else." +
		"\n\nPress R to Return to the lobby"; 
		if (Input.GetKeyDown(KeyCode.R)) 					{myState = States.lobby_2;} 
		}

	// Lobby Default
	void state_lobby_2 () {
		text.text = "You are in the main lobby. It has a red carpet, a brightly lit Reception desk and two large sealed glass Doors. There is a Guard sat on a chair opposite the door. He appears to be asleep." +
		"\n\n Press M to approach the Main doors, R to look at the Reception desk, or G to examine the Guard."; 
		if (Input.GetKeyDown(KeyCode.M))					{myState = States.main_doors;}
		if (Input.GetKeyDown(KeyCode.R))					{myState = States.reception;}
		if (Input.GetKeyDown(KeyCode.G))					{myState = States.guard;}
		}

	// Reception 
	void state_reception () {
		text.text = "You approach the reception desk. You can see a large white desk with several computers and chairs. As you get behind the desk you see a woman on the floor in a pool of blood. She is certainly dead " +
		"You can see the Computer's are powered up, though on closer inspection several of the monitors appear to be broken." +
		"\n\nPress R to check on the Receptionist, or C to examine the Computer";
		if (Input.GetKeyDown(KeyCode.R))					{myState = States.receptionist;}
		if (Input.GetKeyDown(KeyCode.C))					{myState = States.computer;}
		}

	// Computer
	void state_computer () {
		text.text = "You move the chair out of the way and step over the dead receptionists body to use the keyboard. You have access to the computer, though it appears to be in a state of Lockdown. Red flashing warnings " +
		"on the screen state 'Emergency Situation - Lockdown In Effect' and you have very limited access to the system. You could try to look at the Camera feeds, or head back to the Lobby." +
		"\n\nPress C to examine the Camera feeds or R to Return to the Lobby"; 
		if (Input.GetKeyDown(KeyCode.R))					{myState = States.lobby_2;}
		if (Input.GetKeyDown(KeyCode.C))					{myState = States.camera;}
		}

	// Camera Feeds
	void state_camera () {
		text.text = "You look at the Camera feeds. Most of them appear to be offline, but you notice one feed from the Corridor outside of your cell. The blast doors at the end of the corridor are missing: smashed metal " +
		"lines the corridor and massive clawmarks line the walls. You are glad you escaped before whatever it was got to you first. You notice movement and see one of the feeds pointed outside: the building is surrounded " +
		"by a variety of armed police with a combination of armored vehicles and heavy weaponry. They appear to be arguing with a man in a white lab coat." +
		"\n\nPress R to Return to the Lobby";
		if (Input.GetKeyDown(KeyCode.R))					{myState =States.lobby_2;} 
		}

	// Receptionist 
	void state_receptionist () {
		text.text = "This must have been the receptionist, judging by her white clothing and ID. She does not appear to have a keycard. Her clothing is matted with blood on the back, it seems she was taken by surprise. " +
		"Across her back are a series of gashes, clearly the cause of her death. She is cold to the touch, she must have been dead for some time. There is nothing else here for you." +
		"\n\nPress R to Return to the Lobby"; 
		if (Input.GetKeyDown(KeyCode.R))					{myState = States.lobby_2;} 
		}

	// Guard - Leads to exit 
	void state_guard () {
		text.text = "You cautiously approach the sleeping guard. Up close you notice he appears to be holding one hand to his chest, and the other hangs limp to the side. Below him you can see a pistol " +
		"and from the spent bullet casings on the floor, it would appear that the Guard did not go down without a fight. You examine his kevlar vest, it appears to have been cleaved through the middle. " +
		"The vest is soaked in blood. It seems that this man died here. Clutched in his free hand, you see a blooded Keycard. Perhaps this guard activated the lockdown?" +
		"\n\nPress K to take the Keycard"; 
		if (Input.GetKeyDown(KeyCode.K))					{myState = States.lobby_key;} 
		}

	// Lobby with Key 
	void state_lobby_key () {
		text.text = "You are in the Lobby. You have the Keycard from the dead Guard. You should probably try to get out of here now." +
		"\n\nPress L to use the Keycard on the door Lock";
		if (Input.GetKeyDown(KeyCode.L))					{myState = States.escape;}
		}

	// Escape!
	void state_escape () {
		text.text = "You swipe the card in the lock. With a chime, the doors open up. Immediately you are stunned by the bright light but before your eyes "+
		"can adjust you find yourself surrounded by the police who swarm into the lobby and take up positions at the door. The man in the white coat approaches " +
		"you but is stopped by one of the policemen. Another officer smiles at you. 'It's going to be OK. Can you tell us what happened?' "+  
		"You are about to speak when a massive roar echoes through the room. The scientist screams 'RUN! IT'S LOOSE!' then struggles to escape. Quickly, you are escorted "+
		"out of the building to the sound of gunfire. It appears that for now, your nightmare has ended." +
		"\n\nPress E to Continue"; 
		if (Input.GetKeyDown(KeyCode.E))				{myState = States.end;}
		}

	// End Screen 
	void state_end () {
		text.text = "Congratulations! You have escaped the facility!" +
		"\n\nThank you for playing Experiment. Please let me know what you thought to my first Unity project! " +
		"This project was written and coded by Kitsunami Lupo. The sound code was written by Joe D. Thank's Joe!" + 
		"\n\nPress P to Play Again"; 
		if (Input.GetKeyDown(KeyCode.P))				{myState = States.intro;} 
		}
		}

	// NOTES AT END OF SESSION - Just need to do the lobby and win set. 


	