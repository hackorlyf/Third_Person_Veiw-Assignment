# Third_Person_Veiw-Assignment
This is my submission of tasks given to me for an internship at Jayam Patel

# Controls
Press B : Burpee (has delay of 5 seconds and press B again to stop doing Burpees)
Hold  W : Walking
Hold  C : Crouching

## State Machince
![State Machine] (https://raw.githubusercontent.com/hackorlyf/Third_Person_Veiw-Assignment/main/SS_TPV/StateMachine.png)

## Explaining my design choices and implementation details
1} Download 3D models from https://www.mixamo.com/ . This included Swat, StandingIdle, Crouching, Burpee and Walking.

2} Dragged our Swat model into scene and set its Animation type: Humanoid in Rig and click on "Extract Textures" "Extract Materials" in Materials Tab onto our Assets/Materials.

3} Now for our StandingIdle, Crouching, Burpee and Walking we set its Animation type: Humanoid & Avatar Defination: Copy from Other Avatar and in Source we select our Swat model in Rig. Check the box for Loop Time in our animation as we want our animations to loop like walking.

## Setting up Animations
1} Create a Parameter for Crouching:

a. In the Animator window, click on your character's Animator Controller.

b. In the Animator Controller window, you'll see your character's states and transitions. Create a new parameter by clicking on the "Parameters" tab in the Animator Controller window and clicking the "+" button. Name it "IsCrouching" and set the type to "Bool."

Do the same for Walking and Burpees.

2} Create a Crouching State:

a. In the Animator Controller window, create a new state for the crouching animation:

Right-click in the Animator Controller window.
Choose "Create State > Empty."
b. Rename the state to "Crouching."

Do the same for Walking and Burpees.

3} Transition to the Crouching State:

a. Create a transition from your character's default state (usually an idle state) to the "Crouching" state:

Right-click on the default state.
Select "Make Transition."
b. Click on the "Crouching" state to create the transition.

c. In the Inspector window, find the "Conditions" section. Click the "+" button to add a condition.

d. Set the condition to "IsCrouching" is true.

Do the same for Walking and Burpees.

4} Add the Crouch Animation Clip to the Crouching State:

a. Select the "Crouching" state in the Animator Controller.

b. In the Animator window, drag and drop your "CrouchAnimation" clip into the state. This associates the animation clip with the "Crouching" state.

Do the same for Walking and Burpees.

5} Create a Crouch, Running, Burpees Script

6} Attach the Script:

a. Attach the "CrouchScript" to your character GameObject that has the Animator component.

and similarly Running and Burpee Scripts.
