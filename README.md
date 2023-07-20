# ColoredBoxGroup
**Requires Odin Inspector**


## Color Box Groups
* Built-on Boxgroup and allows for coloring, titles and nesting.


## Examples
![image](https://github.com/Kurloc/ColoredBoxGroup/assets/57206908/c746b10e-e73e-4a52-abdf-ed11fa60438a)


Code Ex
```
    // Implicit Title from Groupname
    [ColoredBoxGroup("Colored Box Group Example",
                     .76f, .23f, .64f, .98f,
                     true, false, true)]
    public string IAmAColoredBoxGroupExampleValue;


    // Explicit Title from Groupname
    [ColoredBoxGroup("Colored Box Group Example",
                     "I am the label/title text",
                     .76f, .23f, .64f, .98f,
                     true, false, true)]
    public string IAmAColoredBoxGroupExampleValue;
```

## Usage
This code is not currently namedspaced, but you should place it where you're storing all of the scripts for your game/project. Then namespace it accordingly and import then use the attribute.
