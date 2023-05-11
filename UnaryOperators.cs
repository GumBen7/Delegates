namespace Delegates {
    class UnaryOperators {
        public Operator[] Operators { get; private set; } 
        public UnaryOperators() {
            this.Operators = new Operator[] { DelegateSqrt, DelegateMultBy10, 
                DelegateMultBy100, DelegateMultBy1000, DelegateMultBy10000, DelegateSqrt, 
                DelegateMultBy10, DelegateMultBy100, DelegateMultBy1000, DelegateMultBy10000 };
        }

        public void Shuffle() {
            Random rand = new Random();
            this.Operators = this.Operators.OrderBy(x => rand.Next()).ToArray();
        }

        public delegate double Operator(double a);

        private double DelegateSqrt(double a) => Math.Sqrt(a);

        private double DelegateMultBy10(double a) => a * 10;

        private double DelegateMultBy100(double a) => a * 100;

        private double DelegateMultBy1000(double a) => a * 1000;

        private double DelegateMultBy10000(double a) => a * 10000;
    }
}