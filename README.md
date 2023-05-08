# SpaceShoooter_DOTS
SpaceShooter game using unity DOTS framwork

The Unity DOTS packages im using in this project are Entities, Hybrid Rendere, and Unity Physics.

Controlls for the game are WSAD for movement, Left mouse click for shooting and ESC to close out of the game.

For this projects i used ECS and Job system.

The enemies and projectiles are entities that consist of Tags and component to manage Movement, collsion and spawning through Systems.
The player uses a combination of Monobehaviors, tags and componets. Movement, shooting, health and score are handled by the monobeahviours but collision are handled by systems.
The shooting system uses an adjustable Pooling system to reuse projectiles.

In the built version there are 14000 enemies spawning, and moving at different speeds. Get as high score as possible fore you die. health and score are shown in the top right corner.
