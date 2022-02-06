using ThreadChronometerConsole;

Chronometer chrono = new Chronometer();
Thread t1 = new Thread(new ThreadStart(chrono.calculateElapsedSeconds));
Thread t2 = new Thread(new ThreadStart (chrono.printElapsedSeconds));
t1.Start();
t2.Start();
