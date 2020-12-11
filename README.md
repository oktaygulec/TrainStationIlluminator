# Train Station Illuminator

<b>Problem:</b>

We have a bunch of unlit train stations and we have to put lights on them.
In this case, we should be able to put lights on unlit stations but, they have a starting and ending points and we should find those points and then we are going to put those lights on those stations.

<b>Solution:</b>

First of all, we need some numbers from the user for making our sample train station so, we need to store total location and total path in some variables.

Second thing is, we need an array and it should be 2D because we have rows and columns (paths are rows and locations are columns).

Third step is going to be making a train station sample and we are making those with nested loops. In those loops, we can generate some random numbers which is going to be 0 and 1 (0 is empty location and 1 is unlit station) and we are going to convert those numbers to some chars for making the program more graphical (0 is going to be * and 1 is going to be -) and then we are going to use our 2D array to store empty locations and unlit stations.

In fourth step; we are going to use nested loops again because we have to look every single location for to ask "is my current location a station or empty location?" and we are going to question them for to lit them or not.

And finally; we are going to print the lit train station to display with nested loops.



Thanks for checking and reading my train station illuminator project.

If you have any questions or suggestions, you can reach me at Discord (Miyajinco#3918). It would be awesome and I really appreciate your interest.
