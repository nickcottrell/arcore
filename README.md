# AR Core
This is a series of mobile AR experiences I created to get familiar with the AR Core SDK. The projects demonstrate a working knowledge of plane detection, anchors, and 3D object manipulation in an AR context.

## Sushi Bar
This project is a customization of some basic hello world functionality. I replaced the model with another model that I created and also swapped the texture used by the plane detection mechanic. I encorporated audio so that it fires when a model is attached to a plane.

**Key concepts:**
* Planes
* Anchors

![AR Sushi Bar](/AR_SushiBar/ar-sushi-bar.png)
_When the app detects surfaces, user taps the screen and drops a plate of sushi on the surface._


## AR Treasure Hunt
This project brings in more functionality to create a more complex experience. I added conditional functionality that unfolds in a specific sequence that is initiated by user events. There is also a blend of 2D screenspace touch actions along with 3D world space behaviors that exemplify mobile AR experience.

**Key concepts:**
* AR Object instantiation
* Conditional functionality
* Touch/raycast events

![AR Treasure Hunt](/AR_TreasureHunt/ar-treasure-hunt.png)
_First, the user drops a locked chest, then the key. Next, they tap the key to pick it up, and tap the chest to unlock the treasure!_