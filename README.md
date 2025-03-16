# Unity.WindowsCursor

Change the hardware cursor / mouse in Windows for Unity. Works in the editor as well.

## Installation

Add the dependency to your `manifest.json`

```json
{
  "dependencies": {
    "jd.boiv.win-cursor": "https://github.com/starburst997/Unity.WindowsCursor.git"
  }
}
```

## Usage

You need to call `Update()` every frame somewhere

```csharp
WindowsCursor.Update();
```

Change the cursor by calling once the function

```csharp
WindowsCursor.Change(WindowsCursors.Hand);
```

## Cursors

- `WindowsCursors.StandardArrowAndSmallHourglass`
- `WindowsCursors.StandardArrow`
- `WindowsCursors.Crosshair`
- `WindowsCursors.Hand`
- `WindowsCursors.ArrowAndQuestionMark`
- `WindowsCursors.IBeam`
- `WindowsCursors.SlashedCircle`
- `WindowsCursors.FourPointedArrowPointingNorthSouthEastAndWest`
- `WindowsCursors.DoublePointedArrowPointingNortheastAndSouthwest`
- `WindowsCursors.DoublePointedArrowPointingNorthAndSouth`
- `WindowsCursors.DoublePointedArrowPointingNorthwestAndSoutheast`
- `WindowsCursors.DoublePointedArrowPointingWestAndEast`
- `WindowsCursors.VerticalArrow`
- `WindowsCursors.Hourglass`

## TODO

- Add sample
- Better readme
- [Support more native platforms with fallback to software](https://github.com/starburst997/Unity.NativeCursors)