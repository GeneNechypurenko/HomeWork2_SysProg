namespace HomeWork2
{
    public partial class Form1 : Form
    {
        private Thread primeThread;
        private Thread fiboThread;
        private volatile bool stopPrimes;
        private volatile bool stopFibo;
        private volatile bool pausePrimes;
        private volatile bool pauseFibo;

        public Form1()
        {
            InitializeComponent();
            primeThread = new Thread(() => { });
            fiboThread = new Thread(() => { });

            stopPrimeButton.Enabled = false;
            stopFiboButton.Enabled = false;
            pausePrimeButton.Enabled = false;
            pauseFiboButton.Enabled = false;
            resumePrimeButton.Enabled = false;
            resumeFiboButton.Enabled = false;
        }

        private void DisplayFibonacci(int fibo)
        {
            if (outputFiboListBox.InvokeRequired)
            {
                outputFiboListBox.Invoke(new Action<int>(DisplayFibonacci), fibo);
            }
            else
            {
                outputFiboListBox.Items.Add(fibo);
            }
        }

        private void DisplayPrime(int prime)
        {
            if (outputPrimeListbox.InvokeRequired)
            {
                outputPrimeListbox.Invoke(new Action<int>(DisplayPrime), prime);
            }
            else
            {
                outputPrimeListbox.Items.Add(prime);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int? minPrimes = minPrimeNumeric.Value != 0 ? (int?)minPrimeNumeric.Value : null;
            int? maxPrimes = maxPrimeNumeric.Value != 0 ? (int?)maxPrimeNumeric.Value : null;

            int? minFibo = minFiboNumeric.Value != 0 ? (int?)minFiboNumeric.Value : null;
            int? maxFibo = maxFiboNumeric.Value != 0 ? (int?)maxFiboNumeric.Value : null;

            outputPrimeListbox.Items.Clear();
            outputFiboListBox.Items.Clear();

            stopPrimes = false;
            stopFibo = false;
            pausePrimes = false;
            pauseFibo = false;

            stopPrimeButton.Enabled = true;
            stopFiboButton.Enabled = true;
            pausePrimeButton.Enabled = true;
            pauseFiboButton.Enabled = true;

            if (!primeThread.IsAlive)
            {
                primeThread = new Thread(() =>
                {
                    GeneratePrimes(minPrimes, maxPrimes, DisplayPrime);
                });
                primeThread.Start();
            }

            if (!fiboThread.IsAlive)
            {
                fiboThread = new Thread(() =>
                {
                    GenerateFibonacci(minFibo, maxFibo, DisplayFibonacci);
                });
                fiboThread.Start();
            }
        }

        private void stopPrimeButton_Click(object sender, EventArgs e)
        {
            stopPrimes = true;
        }

        private void stopFiboButton_Click(object sender, EventArgs e)
        {
            stopFibo = true;
        }

        private void pausePrimeButton_Click(object sender, EventArgs e)
        {
            pausePrimes = true;
            resumePrimeButton.Enabled = true;
            pausePrimeButton.Enabled = false;
        }

        private void pauseFiboButton_Click(object sender, EventArgs e)
        {
            pauseFibo = true;
            resumeFiboButton.Enabled = true;
            pauseFiboButton.Enabled = false;
        }

        private void resumePrimeButton_Click(object sender, EventArgs e)
        {
            pausePrimes = false;
            resumePrimeButton.Enabled = false;
            pausePrimeButton.Enabled = true;
        }

        private void resumeFiboButton_Click(object sender, EventArgs e)
        {
            pauseFibo = false;
            resumeFiboButton.Enabled = false;
            pauseFiboButton.Enabled = true;
        }

        private void GeneratePrimes(int? min, int? max, Action<int> callBack)
        {
            int start = min ?? 2;
            int end = max ?? int.MaxValue;

            List<int> primes = new List<int>();

            for (int num = start; num <= end; num++)
            {
                if (stopPrimes)
                    break;

                while (pausePrimes)
                {
                    Thread.Sleep(10);
                }

                if (IsPrime(num))
                {
                    primes.Add(num);
                    callBack?.Invoke(num);
                    Thread.Sleep(100);
                }
            }
            stopPrimeButton.Invoke(new Action(() => stopPrimeButton.Enabled = false));
            pausePrimeButton.Invoke(new Action(() => pausePrimeButton.Enabled = false));
            resumePrimeButton.Invoke(new Action(() => resumePrimeButton.Enabled = false));
        }

        private void GenerateFibonacci(int? min, int? max, Action<int> callBack)
        {
            int start = min ?? 0;
            int end = max ?? int.MaxValue;

            int a = 0, b = 1;

            while (a <= end)
            {
                if (stopFibo)
                    break;

                while (pauseFibo)
                {
                    Thread.Sleep(10);
                }

                if (a >= start)
                {
                    callBack?.Invoke(a);
                    Thread.Sleep(100);
                }

                int temp = a;
                a = b;
                b = temp + b;
            }
            stopFiboButton.Invoke(new Action(() => stopFiboButton.Enabled = false));
            pauseFiboButton.Invoke(new Action(() => pauseFiboButton.Enabled = false));
            resumeFiboButton.Invoke(new Action(() => resumeFiboButton.Enabled = false));
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}