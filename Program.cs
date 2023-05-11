namespace Delegates {
    class Program {
        static void Main(string[] args) {
            UnaryOperators uOperators = new UnaryOperators();
            double x = 7.3;
            x = OpApply(x, uOperators);
            Console.WriteLine(x);

            uOperators.Shuffle();
            x = OpApply(x, uOperators);
            Console.WriteLine(x);
            Console.WriteLine(OpApply(7.3, uOperators));            
        }

        private static double OpApply(double a, UnaryOperators uOperators) {
            foreach (var op in uOperators.Operators) {
                a = op(a);
            }
            return a;
        }
    }
}