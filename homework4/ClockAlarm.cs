class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.SetTime(0, 0, 10);
            Person student = new Person();

            clock.Alarm += student.ClockAlarm;
            clock.Tick += student.ClockTick;

            clock.Start();

            while (true) { }
            
        }
    }

    class Person
    {
        bool sleep = true;

        public void ClockTick(object clock)
        {
            if (sleep == true)
            {
                Console.WriteLine("Person is sleeping.");
            }
            else
            {
                Console.WriteLine("Person is not sleeping.");
            }
        }
        public void ClockAlarm(object clock)
        {
            sleep = false;
            Console.WriteLine("Person is waking up.");
        }
    }

    class Clock
    {
        public event Action<object> Tick;
        public event Action<object> Alarm;

        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        public int[] Time = new int[3];

        public void SetTime(int h, int m, int s)
        {
            Time[0] = h;
            Time[1] = m;
            Time[2] = s;

        }

        public void Start()
        {
            hour = minute = second = 0;
            Timer timer = new Timer();
            timer.Elapsed += (object source, System.Timers.ElapsedEventArgs e) =>
            {
                second++;
                minute += second / 60;
                hour += minute / 60;
                second %= 60;
                minute %= 60;
                hour %= 24;
                GetTick();
            };
            timer.AutoReset = true;
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();

            GetTick();

        }
        public void GetTick()
        {


            Console.WriteLine(hour + ": " + minute + ": " + second);
            Tick(this);
            if (hour == Time[0] && minute == Time[1] && second == Time[2])
            {
                GetAlarm();
            }


        }
        public void GetAlarm()
        {
            Console.WriteLine("Clock Alarming! Wake up!");
            Alarm(this);
        }
    }
