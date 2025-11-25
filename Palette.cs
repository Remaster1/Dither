namespace Dither
{
    internal struct Palette
    {
        public Palette(string name, Color[] colors)
        {
            Name = name;
            Colors = colors;
        }

        public string Name { get; set; }
        public Color[] Colors { get; set; }
    };

    internal static class Palettes
    {
        public static readonly Palette[] All =
        [
            new Palette(
            "Black & White",
            [
                Color.Black,
                Color.White
            ]
            ),

        new Palette(
            "Grayscale 4-bit",
            [
                Color.FromArgb(0, 0, 0),
                Color.FromArgb(85, 85, 85),
                Color.FromArgb(170, 170, 170),
                Color.FromArgb(255, 255, 255)
            ]
        ),

        new Palette(
            "Primary Colors",
            [
                Color.Red,
                Color.Green,
                Color.Blue,
                Color.Yellow,
                Color.Cyan,
                Color.Magenta,
                Color.Black,
                Color.White
            ]
        ),

        new Palette(
            "Web Safe Colors",
            [
                Color.FromArgb(0, 0, 0),
                Color.FromArgb(51, 51, 51),
                Color.FromArgb(102, 102, 102),
                Color.FromArgb(153, 153, 153),
                Color.FromArgb(204, 204, 204),
                Color.FromArgb(255, 255, 255),
                Color.FromArgb(255, 0, 0),
                Color.FromArgb(0, 255, 0),
                Color.FromArgb(0, 0, 255)
            ]
        ),

        new Palette(
            "Pastel Colors",
            [
                Color.FromArgb(255, 209, 220), // Light Pink
                Color.FromArgb(209, 222, 255), // Light Blue
                Color.FromArgb(209, 255, 218), // Light Green
                Color.FromArgb(255, 255, 209), // Light Yellow
                Color.FromArgb(255, 209, 209), // Light Red
                Color.FromArgb(220, 209, 255)  // Light Purple
            ]
        ),

        new Palette(
            "Earth Tones",
            [
                Color.FromArgb(139, 69, 19),   // Brown
                Color.FromArgb(160, 82, 45),   // Sienna
                Color.FromArgb(205, 133, 63),  // Peru
                Color.FromArgb(222, 184, 135), // BurlyWood
                Color.FromArgb(245, 222, 179), // Wheat
                Color.FromArgb(210, 180, 140)  // Tan
            ]
        ),

        new Palette(
            "Game Boy",
            [
                Color.FromArgb(15, 56, 15),    // Dark Green
                Color.FromArgb(48, 98, 48),    // Medium Green
                Color.FromArgb(139, 172, 15),  // Light Green
                Color.FromArgb(155, 188, 15)   // Pale Green
            ]
        ),

        new Palette(
            "CGA 4-Color",
            [
                Color.FromArgb(0, 0, 0),       // Black
                Color.FromArgb(85, 255, 255),  // Cyan
                Color.FromArgb(255, 85, 255),  // Magenta
                Color.FromArgb(255, 255, 255)  // White
            ]
        ),

        new Palette(
            "Warm Colors",
            [
                Color.FromArgb(255, 0, 0),     // Red
                Color.FromArgb(255, 165, 0),   // Orange
                Color.FromArgb(255, 255, 0),   // Yellow
                Color.FromArgb(139, 0, 0),     // Dark Red
                Color.FromArgb(255, 140, 0),   // Dark Orange
                Color.FromArgb(255, 215, 0)    // Gold
            ]
        ),

        new Palette(
            "Cool Colors",
            [
                Color.FromArgb(0, 0, 255),     // Blue
                Color.FromArgb(0, 255, 255),   // Cyan
                Color.FromArgb(0, 255, 0),     // Green
                Color.FromArgb(0, 100, 0),     // Dark Green
                Color.FromArgb(0, 0, 139),     // Dark Blue
                Color.FromArgb(72, 61, 139)    // Dark Slate Blue
            ]
        ),
           new Palette(
        "ZX Spectrum",
        [
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(0, 0, 215),     // Blue
            Color.FromArgb(215, 0, 0),     // Red
            Color.FromArgb(215, 0, 215),   // Magenta
            Color.FromArgb(0, 215, 0),     // Green
            Color.FromArgb(0, 215, 215),   // Cyan
            Color.FromArgb(215, 215, 0),   // Yellow
            Color.FromArgb(215, 215, 215), // White
            Color.FromArgb(0, 0, 255),     // Bright Blue
            Color.FromArgb(255, 0, 0),     // Bright Red
            Color.FromArgb(255, 0, 255),   // Bright Magenta
            Color.FromArgb(0, 255, 0),     // Bright Green
            Color.FromArgb(0, 255, 255),   // Bright Cyan
            Color.FromArgb(255, 255, 0),   // Bright Yellow
            Color.FromArgb(255, 255, 255)  // Bright White
        ]
           ),

    new Palette(
        "Apple II",
        [
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(114, 38, 64),   // Deep Red
            Color.FromArgb(64, 51, 127),   // Dark Blue
            Color.FromArgb(228, 103, 171), // Purple
            Color.FromArgb(0, 120, 53),    // Dark Green
            Color.FromArgb(128, 128, 128), // Gray
            Color.FromArgb(27, 203, 255),  // Medium Blue
            Color.FromArgb(191, 220, 255), // Light Blue
            Color.FromArgb(139, 90, 0),    // Brown
            Color.FromArgb(255, 128, 0),   // Orange
            Color.FromArgb(128, 128, 128), // Gray 2
            Color.FromArgb(255, 203, 128), // Pink
            Color.FromArgb(0, 233, 0),     // Light Green
            Color.FromArgb(255, 255, 128), // Yellow
            Color.FromArgb(64, 255, 203),  // Aquamarine
            Color.FromArgb(255, 255, 255)  // White
        ]
    ),

    new Palette(
        "Commodore 64",
        [
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(255, 255, 255), // White
            Color.FromArgb(136, 0, 0),     // Red
            Color.FromArgb(170, 255, 238), // Cyan
            Color.FromArgb(204, 68, 204),  // Purple
            Color.FromArgb(0, 204, 85),    // Green
            Color.FromArgb(0, 0, 170),     // Blue
            Color.FromArgb(238, 238, 119), // Yellow
            Color.FromArgb(221, 136, 85),  // Orange
            Color.FromArgb(102, 68, 0),    // Brown
            Color.FromArgb(255, 119, 119), // Light Red
            Color.FromArgb(51, 51, 51),    // Dark Gray
            Color.FromArgb(119, 119, 119), // Medium Gray
            Color.FromArgb(170, 255, 102), // Light Green
            Color.FromArgb(0, 136, 255),   // Light Blue
            Color.FromArgb(187, 187, 187)  // Light Gray
        ]
    ),

    new Palette(
        "NES",
        [
            Color.FromArgb(124, 124, 124), // Gray
            Color.FromArgb(0, 0, 252),     // Blue
            Color.FromArgb(0, 0, 188),     // Dark Blue
            Color.FromArgb(68, 40, 188),   // Purple
            Color.FromArgb(148, 0, 132),   // Magenta
            Color.FromArgb(168, 0, 32),    // Red
            Color.FromArgb(168, 16, 0),    // Brick
            Color.FromArgb(136, 20, 0),    // Dark Red
            Color.FromArgb(80, 48, 0),     // Brown
            Color.FromArgb(0, 120, 0),     // Green
            Color.FromArgb(0, 104, 0),     // Dark Green
            Color.FromArgb(0, 88, 0),      // Deep Green
            Color.FromArgb(0, 64, 88),     // Teal
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(188, 188, 188), // Light Gray
            Color.FromArgb(248, 56, 0)     // Orange
        ]
    ),

    new Palette(
        "MSX",
        [
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(0, 0, 0),       // Black (duplicate)
            Color.FromArgb(33, 200, 66),   // Medium Green
            Color.FromArgb(94, 220, 120),  // Light Green
            Color.FromArgb(84, 85, 237),   // Dark Blue
            Color.FromArgb(125, 118, 252), // Light Blue
            Color.FromArgb(212, 82, 77),   // Dark Red
            Color.FromArgb(66, 235, 245),  // Cyan
            Color.FromArgb(252, 85, 84),   // Medium Red
            Color.FromArgb(255, 121, 120), // Light Red
            Color.FromArgb(212, 193, 84),  // Dark Yellow
            Color.FromArgb(230, 206, 128), // Light Yellow
            Color.FromArgb(33, 176, 59),   // Dark Green
            Color.FromArgb(201, 91, 186),  // Magenta
            Color.FromArgb(204, 204, 204), // Gray
            Color.FromArgb(255, 255, 255)  // White
        ]
    ),

    new Palette(
        "Amiga",
        [
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(0, 0, 170),     // Blue
            Color.FromArgb(0, 170, 0),     // Green
            Color.FromArgb(0, 170, 170),   // Cyan
            Color.FromArgb(170, 0, 0),     // Red
            Color.FromArgb(170, 0, 170),   // Magenta
            Color.FromArgb(170, 85, 0),    // Brown
            Color.FromArgb(170, 170, 170), // Light Gray
            Color.FromArgb(85, 85, 85),    // Dark Gray
            Color.FromArgb(85, 85, 255),   // Light Blue
            Color.FromArgb(85, 255, 85),   // Light Green
            Color.FromArgb(85, 255, 255),  // Light Cyan
            Color.FromArgb(255, 85, 85),   // Light Red
            Color.FromArgb(255, 85, 255),  // Light Magenta
            Color.FromArgb(255, 255, 85),  // Yellow
            Color.FromArgb(255, 255, 255)  // White
        ]
    ),

    new Palette(
        "Atari 2600",
        [
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(255, 255, 255), // White
            Color.FromArgb(104, 55, 43),   // Brown
            Color.FromArgb(112, 164, 178), // Light Blue
            Color.FromArgb(111, 61, 134),  // Purple
            Color.FromArgb(88, 141, 67),   // Green
            Color.FromArgb(53, 40, 121),   // Navy
            Color.FromArgb(184, 199, 111), // Olive
            Color.FromArgb(111, 79, 37),   // Dark Brown
            Color.FromArgb(67, 57, 0),     // Dark Olive
            Color.FromArgb(154, 103, 89),  // Pink
            Color.FromArgb(68, 68, 68),    // Dark Gray
            Color.FromArgb(108, 108, 108), // Medium Gray
            Color.FromArgb(154, 210, 132), // Light Green
            Color.FromArgb(108, 94, 181),  // Lavender
            Color.FromArgb(149, 149, 149)  // Light Gray
        ]
    ),

    new Palette(
        "DOS 16-color",
        [
            Color.FromArgb(0, 0, 0),       // Black
            Color.FromArgb(0, 0, 170),     // Blue
            Color.FromArgb(0, 170, 0),     // Green
            Color.FromArgb(0, 170, 170),   // Cyan
            Color.FromArgb(170, 0, 0),     // Red
            Color.FromArgb(170, 0, 170),   // Magenta
            Color.FromArgb(170, 170, 0),   // Brown/Yellow
            Color.FromArgb(170, 170, 170), // Light Gray
            Color.FromArgb(85, 85, 85),    // Dark Gray
            Color.FromArgb(85, 85, 255),   // Light Blue
            Color.FromArgb(85, 255, 85),   // Light Green
            Color.FromArgb(85, 255, 255),  // Light Cyan
            Color.FromArgb(255, 85, 85),   // Light Red
            Color.FromArgb(255, 85, 255),  // Light Magenta
            Color.FromArgb(255, 255, 85),  // Yellow
            Color.FromArgb(255, 255, 255)  // White
        ]
    )
        ];
    }


}
