namespace ovn_5_1_3_sno {
    internal class Program {
        static bool LargerHeight(Rectangle r1, Rectangle r2)
            => r1.height > r2.height;
        static List<Rectangle> InsertionSort(List<Rectangle> list, Larger isLarger) {
            List<Rectangle> result = new List<Rectangle>(list);
            for (int i = 0; i < result.Count - 1; i++) {
                for (int j = i + 1; j > 0; j--) {
                    if (isLarger(result[j - 1], result[j])) {
                        Rectangle temp = result[j - 1];
                        result[j - 1] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        class Rectangle {
            public double width, height;
            public Rectangle(double width, double height) {
                this.width = width; this.height = height;
            }
            public override string ToString() => $"[rect W={width} H={height}]";
        }
        // Deklarera delegat-typ:
        delegate bool Larger(Rectangle r1, Rectangle r2);
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(1, 5);
            Rectangle r2 = new Rectangle(4, 3);
            Rectangle r3 = new Rectangle(3, 2);
            // Konstruera lista av trianglar:
            List<Rectangle> rects = new List<Rectangle>() { r1, r2, r3 };
            // Skriv ut lista:
            foreach (Rectangle r in rects) Console.WriteLine(r);
            Console.WriteLine();
            // Sortera med avseende på höjd:
            List<Rectangle> sorth = InsertionSort(rects, LargerHeight);
            // Skriv ut lista:
            foreach (Rectangle r in sorth) Console.WriteLine(r);
            Console.WriteLine();
        }
    }
}
