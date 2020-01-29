# Area 1 

## Level Design Info

We will do labyrinth, some path will make you end at the begininng.

## Level Art Info

We will be doing a mushroom forest.

## Technical Info

### Overview:

We are going to do a level with a smooth teleport, to create this there are some considerations to take in account:

- The designer must create a level where the transitions parts have same height so no jump or fall animation are performer.
- The artist needs to create the same environment so the transitions are unnoticed by the player.
- The camera needs to be the same view in all the transitions. We can do this by changing the camera when needed.

### Meshes:

We don't want a great amount of meshes because for every mesh a drawcall is performer, so the less meshes the less drawcalls. At the same time we don't want to put everything in a single mesh because we will not have culling from unity.

So the amount of meshes we will be using will be maximum 10. Additionally we can use the static batching options Unity provides to handle this.

Settings environment objects as static for options such as occluder, occludee and navigation will make Unity to performe better since this meshes are purely decorative and we don't need to render o calculate obstacles with them.

The final mesh for the scene should no have more than 700.000 vertices
