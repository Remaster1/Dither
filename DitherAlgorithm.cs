namespace Dither
{
    internal struct DitherAlgorithm
    {
        public string Name { get; }
        public readonly double[,] Formula;
        public readonly int StartPixelPositionInFormulaX;
        public readonly int StartPixelPositionInFormulaY;

        public DitherAlgorithm(string name, double[,] formula, int startPixelPositionInFormulaX, int startPixelPositionInFormulaY)
        {
            Name = name;
            this.Formula = formula;
            this.StartPixelPositionInFormulaX = startPixelPositionInFormulaX;
            this.StartPixelPositionInFormulaY = startPixelPositionInFormulaY;
        }
    }

    internal static class DitherAlgorithms
    {
        internal static readonly DitherAlgorithm[] All =
        [
            new DitherAlgorithm(
            "Floyd-Steinberg",
            new[,]
            {
                { 0, 0, 7 / 16.0 },
                { 3 / 16.0, 5 / 16.0, 1 / 16.0 }
            },
            1, 0
        ),

            new DitherAlgorithm(
            "Jarvis-Judice-Ninke",
            new[,]
            {
                { 0, 0, 0, 7 / 48.0, 5 / 48.0 },
                { 3 / 48.0, 5 / 48.0, 7 / 48.0, 5 / 48.0, 3 / 48.0 },
                { 1 / 48.0, 3 / 48.0, 5 / 48.0, 3 / 48.0, 1 / 48.0 }
            },
            2, 0
        ),

            new DitherAlgorithm(
            "Stucki",
            new[,]
            {
                { 0, 0, 0, 8 / 42.0, 4 / 42.0 },
                { 2 / 42.0, 4 / 42.0, 8 / 42.0, 4 / 42.0, 2 / 42.0 },
                { 1 / 42.0, 2 / 42.0, 4 / 42.0, 2 / 42.0, 1 / 42.0 }
            },
            2, 0
        ),

            new DitherAlgorithm(
            "Burkes",
            new[,]
            {
                { 0, 0, 0, 8 / 32.0, 4 / 32.0 },
                { 2 / 32.0, 4 / 32.0, 8 / 32.0, 4 / 32.0, 2 / 32.0 }
            },
            2, 0
        ),

            new DitherAlgorithm(
            "Sierra 3",
            new[,]
            {
                { 0, 0, 0, 5 / 32.0, 3 / 32.0 },
                { 2 / 32.0, 4 / 32.0, 5 / 32.0, 4 / 32.0, 2 / 32.0 },
                { 0, 2 / 32.0, 3 / 32.0, 2 / 32.0, 0 }
            },
            2, 0
        ),

            new DitherAlgorithm(
            "Simple Threshold",
            new double[,]
            {
                { 0 }
            },
            0, 0
        )
        ];
    }
}
