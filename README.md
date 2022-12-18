# JSON2LVL
This tool converts a Tiled Json file to a compressed binary file.

## What is the files stucture?
*The first 4 bytes are an unsigned int for the width of the map.
*The second 4 bytes are an unsigned int for the height of the map.
*Anything after that is all of the tile ids represented as a sigle array of unsigned shorts.

The name of the map should be the filename so it is not stored.
You should be able to have an infinite amount of layers for a single map with each layer being the size of the width * height.
It also compresses the file with GZip so it can be much smaller at the expense of longer loading times.

## Note:
*Due to using unsigned shorts, 0 is considered an empty tile. So when referencing a tilesheet you need to subtract 1 to get the right index.
*There can only be one tileset per map but I do plan on adding the ability to use more.
