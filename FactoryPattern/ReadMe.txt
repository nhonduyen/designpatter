Creates an instance of several derived classes
Define an interface for creating an object, but let subclasses decide which class to instantiate.
Factory Method lets a class defer instantiation to subclasses.
Frequency of use: High

The best time to use the factory method pattern is when you have multiple different variations of a single entity. 
Let's say you have a button class;
this class has different variations, such as ImageButton, InputButton and FlashButton. 
Depending on the place, you may need to create different buttons—this is where you can use a factory to create the buttons for you!