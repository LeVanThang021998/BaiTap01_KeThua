namespace BaiTap01_KeThua
{
    class Account
    {
        private double _Banlance;
        public Account() { }
        public Account(double banlance)
        {
            this._Banlance = banlance;
        }
        public double Balance
        {
            set { _Banlance = value; }
            get { return _Banlance; }
        }
        public virtual bool WithDraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public void PrintBalance()
        {
            Console.WriteLine("Balance:{0}", _Banlance);
        }
    }
    //Dinh nghia lop SavingAccount
    class SavingAcount: Account
    {
        public double _interesRate=0.8;
        public SavingAcount() { }
        public SavingAcount(double balance) : base(balance) { }
        public double InteresRate
        {
            set { _interesRate = value; }
            get { return _interesRate; }
        }
        public override bool WithDraw(double amount)
        {
            return base.WithDraw(amount);
        }
        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }
    }
    class CheckingAccount:Account
    {
        public CheckingAccount() : base() { }
        public CheckingAccount(double balance) : base(balance) 
        { 
        }
        public override bool WithDraw(double amount)
        {
            return base.WithDraw(amount);
        }
        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }

    }
    


        internal class Program
    {
        static void Main(string[] args)
        {
            Account AC1 = new SavingAcount(200);
            Console.WriteLine("Saving Account!");
            AC1.Deposit(100);
            AC1.PrintBalance();
            Account AC2 = new CheckingAccount(200);
            Console.WriteLine("Saving Account!");
            AC2.Deposit(100);
            AC2.PrintBalance();
            Console.ReadLine();

        }
    }
}
