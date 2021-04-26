# ColoredBoxGroup
**Requires Odin Inspector**


## Color Box Groups
* Drop-in replacement for a regular Boxgroup but can be colored and given a bold title.


## Examples
Normal Title
![Image](https://gyazo.com/5cac08d156d196cbf39fb89555d1a877.png)
Bold Title
![Image](https://gyazo.com/67849ecd8c13daeebeb2d26374db858e.png)

Code Ex
```
    [ColoredBoxGroup("Colored Box Group Example",
                     .76f, .23f, .64f, .98f,
                     true, false, true)]
    public string IAmAColoredBoxGroupExampleValue;
```

## Usage
This code is not currently namedspaced, but you should place it where you're storing all of the scripts for your game/project. Then namespace it accordingly and import then use the attribute.
