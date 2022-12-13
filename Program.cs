using DCTLib;
using Emgu.CV;
using Emgu.CV.Structure;
using FourierTransformFFT;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;

namespace PIS
{
    public struct colorFreq
    {
        public string name;
        public int freq;
        public string code;
        public decimal min;
        public decimal max;
    };

    class Program
    {
        static void Main(string[] args)
        {
            //Laboratorul1();
            //Laboratorul2();
            //Laboratorul3();
            //Laboratorul5();
            Laboratorul6();
        }
        //#region Laboratorul1
        //static void Laboratorul1()
        //{
        //    Console.WriteLine("EX1");
        //    Exercitiu1();
        //    Console.WriteLine("\n\nEX2");
        //    Exercitiu2();
        //}
        //static void Exercitiu1()
        //{
        //    List<colorFreq> colorList = new List<colorFreq>();
        //    colorFreq negru = new colorFreq { name = "Negru", freq = 100 };
        //    colorFreq alb = new colorFreq { name = "Alb", freq = 100 };
        //    colorFreq galben = new colorFreq { name = "Galben", freq = 20 };
        //    colorFreq portocaliu = new colorFreq { name = "Portocaliu", freq = 5 };
        //    colorFreq rosu = new colorFreq { name = "Rosu", freq = 5 };
        //    colorFreq purpuriu = new colorFreq { name = "Purpuriu", freq = 3 };
        //    colorFreq albastru = new colorFreq { name = "Albastru", freq = 20 };
        //    colorFreq verde = new colorFreq { name = "Verde", freq = 3 };
        //    colorList.Add(negru);
        //    colorList.Add(alb);
        //    colorList.Add(galben);
        //    colorList.Add(portocaliu);
        //    colorList.Add(rosu);
        //    colorList.Add(purpuriu);
        //    colorList.Add(albastru);
        //    colorList.Add(verde);

        //    //using (StreamReader sr = new StreamReader("colors.txt"))
        //    //{
        //    //    string line;
        //    //    string[] lineS = new string[2];

        //    //    while ((line = sr.ReadLine()) != null)
        //    //    {
        //    //        lineS = line.Split(' ');
        //    //        colorList.Add(new colorFreq { name = lineS[0], freq = Int32.Parse(lineS[1]) });
        //    //    }
        //    //}

        //    colorList.Sort((x, y) => y.freq.CompareTo(x.freq));

        //    Split_Evenly<colorFreq> arbore = new Split_Evenly<colorFreq>(colorList, colorList.ToArray());
        //    Node<colorFreq> tree = arbore.Root;

        //    //foreach (colorFreq color in colorList)
        //    //{
        //    //    Console.WriteLine($"{color.name} {color.freq} {color.code}");
        //    //}
        //}
        //class Node<T>
        //{
        //    public Node(T data)
        //    {
        //        Data = data;
        //    }
        //    public T Data { get; }
        //    public Node<T> Left { get; set; }
        //    public Node<T> Right { get; set; }
        //}
        //class Split_Evenly<T>
        //{
        //    public Node<colorFreq> Root { get; }
        //    public Split_Evenly(List<colorFreq> data, colorFreq[] colorOutput)
        //    {
        //        Root = Arbore(data, 0, colorOutput);
        //    }
        //    private Node<colorFreq> Arbore(List<colorFreq> colorList, int ix, colorFreq[] colorOutput)
        //    {
        //        if (colorList.Count > 1)
        //        {
        //            List<colorFreq> list1 = new List<colorFreq>();
        //            List<colorFreq> list2 = new List<colorFreq>();

        //            int a = colorList[0].freq; list1.Add(colorList[0]);
        //            int b = colorList[1].freq; list2.Add(colorList[1]);

        //            for (int i = 2; i < colorList.Count; i++)
        //            {
        //                if (a < b)
        //                {
        //                    a += colorList[i].freq;
        //                    list1.Add(colorList[i]);
        //                }
        //                else
        //                {
        //                    b += colorList[i].freq;
        //                    list2.Add(colorList[i]);
        //                }
        //            }

        //            //Console.WriteLine($"{ix} {colorList.Count}");
        //            Node<colorFreq> next = new Node<colorFreq>(colorList[0]);

        //            foreach (colorFreq color in list1)
        //            {
        //                for (int z = 0; z < colorOutput.Length; z++)
        //                {
        //                    if (color.name == colorOutput[z].name)
        //                    {
        //                        colorOutput[z].code += "0";
        //                    }
        //                }
        //            }

        //            foreach (colorFreq color in list2)
        //            {
        //                for (int z = 0; z < colorOutput.Length; z++)
        //                {
        //                    if (color.name == colorOutput[z].name)
        //                    {
        //                        colorOutput[z].code += "1";
        //                    }
        //                }
        //            }

        //            next.Left = Arbore(list1, 2 * ix + 1, colorOutput);
        //            next.Right = Arbore(list2, 2 * ix + 2, colorOutput);

        //            return next;
        //        }
        //        else
        //        {
        //            //Console.WriteLine($"{ix} {colorList[0].name}");

        //            for (int ijk = 0; ijk < colorOutput.Length; ijk++)
        //            {
        //                if (colorOutput[ijk].name == colorList[0].name)
        //                    Console.WriteLine($"{colorOutput[ijk].name}\nFrecventa: {colorOutput[ijk].freq}\tCod: {colorOutput[ijk].code}");
        //            }
        //        }
        //        return null;
        //    }
        //}
        //static void Exercitiu2()
        //{
        //    colorFreq negru = new colorFreq { name = "Negru", freq = 40 };
        //    colorFreq alb = new colorFreq { name = "Alb", freq = 25 };
        //    colorFreq galben = new colorFreq { name = "Galben", freq = 15 };
        //    colorFreq rosu = new colorFreq { name = "Rosu", freq = 10 };
        //    colorFreq albastru = new colorFreq { name = "Albastru", freq = 10 };

        //    colorFreq[] secventa = new colorFreq[] { alb, negru, negru, galben, rosu, albastru };

        //    List<colorFreq> listaCulori = new List<colorFreq>();
        //    listaCulori.Add(alb);
        //    listaCulori.Add(negru);
        //    listaCulori.Add(galben);
        //    listaCulori.Add(rosu);
        //    listaCulori.Add(albastru);

        //    listaCulori.Sort((x, y) => y.freq.CompareTo(x.freq));

        //    decimal interval = 0;
        //    foreach (colorFreq culoare in listaCulori)
        //    {
        //        interval += (decimal)culoare.freq / 100;
        //        for (int i = 0; i < secventa.Length; i++)
        //        {
        //            if (secventa[i].name == culoare.name)
        //            {
        //                secventa[i].freq /= 100;
        //                secventa[i].min = interval - (decimal)culoare.freq / 100;
        //                secventa[i].max = interval;
        //            }

        //        }
        //    }
        //    Console.WriteLine("Codificare\n\n");
        //    foreach (colorFreq test in secventa)
        //    {
        //        Console.WriteLine($"{test.name} {test.freq} {test.min} {test.max}");
        //    }
        //    Console.WriteLine(Codificare(secventa));

        //    Console.WriteLine("\n\nDecodificare\n\n");

        //    Decodificare(Codificare(secventa),secventa);
        //}
        //static float Codificare(colorFreq[] secventa)
        //{
        //    decimal low = 0;
        //    decimal high = 1;

        //    for (int i = 0; i < secventa.Length; i++)
        //    {
        //        decimal range = high - low;
        //        decimal s_high = secventa[i].max;
        //        decimal s_low = secventa[i].min;
        //        high = low + range * s_high;
        //        low = low + range * s_low;

        //    }
        //    return ((float)high + (float)low) / 2;
        //}
        //static void Decodificare(float cod, colorFreq[] secventa)
        //{
        //    for (int i = 0; i < secventa.Length; i++)
        //    {
        //        Console.WriteLine(secventa[i].name);
        //        float s_high = (float)secventa[i].max;
        //        float s_low = (float)secventa[i].min;
        //        if (cod >= s_low && cod <= s_high)
        //        {
        //            float range = s_high - s_low;
        //            cod = (cod-s_low)/range;
        //        }
        //    }
        //}
        //#endregion

        //#region Laboratorul2
        //public static string forwardsWavFilePath = @"B:\MEGA\Facultate\Master\An1Sem2\PIS\beep.wav";
        //public static List<short> samples = new List<short>();
        //static void Laboratorul2()
        //{
        //    L2E1();
        //    L2E2();
        //    L2E3();
        //}
        //private static void L2E3()
        //{
        //    List<short> endSamples= new List<short>();
        //    int toshow = 0;
        //    Console.Write("Valori Esantioane beep1: ");
        //    if (samples.Count > 0)
        //    {

        //        foreach (short sample in samples)
        //        {
        //            endSamples.Add((short)(128 * MLaw((double)(sample))));

        //            if (toshow < 19)
        //            {
        //                Console.Write(endSamples[toshow] + " ");
        //                toshow++;
        //            }
        //        }
        //    }

        //    FileStream fso = new FileStream(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\beep1.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 8, 44100, 31542);
        //    BinaryWriter bw = new BinaryWriter(fso);
        //    using (StreamWriter sw = new StreamWriter("beep1.txt"))
        //    {
        //        foreach (short sample in endSamples)
        //        {
        //            bw.Write(sample);
        //            sw.WriteLine(sample);
        //        }
        //    }
        //    bw.Close();
        //    fso.Close();

        //    // L2E4
        //    FileStream fso2 = new FileStream(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\beep2.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso2, 1, 16, 44100, 31542);
        //    BinaryWriter bw2 = new BinaryWriter(fso2);

        //    toshow = 0;
        //    Console.Write("\nValori Esantioane beep2: ");
        //    using (StreamWriter sw = new StreamWriter("beep2.txt"))
        //    {
        //        foreach (short sample in endSamples)
        //        {
        //            short towrite = (short)(32768 * DLaw((double)sample));
        //            bw2.Write(towrite);

        //            if (toshow < 19)
        //            {
        //                Console.Write(towrite + " ");
        //                toshow++;
        //            }
        //            sw.WriteLine(towrite);
        //        }
        //    }

        //    bw2.Close();
        //    fso2.Close();
        //}
        //private static double MLaw(double x)
        //{
        //    double mu = 255;
        //    return Math.Sign(x) * ((Math.Log((double)1 + mu * Math.Abs(x/32768))) / (Math.Log((double)1 + mu)));
        //}
        //private static double DLaw(double x)
        //{
        //    double mu = 255;
        //    return Math.Sign(x) * ((Math.Pow(((double)1+mu),Math.Abs(x/128))-1) / (mu));
        //}
        //private static void L2E2()
        //{
        //    FileStream fso = new FileStream(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\sin.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, 8000 * 2);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (double t = 0; t < 2; t += (double)1 / 8000)
        //    {
        //        double y = 15000 * Math.Sin(2 * Math.PI * 400 * t);
        //        bw.Write((int)y);
        //    }
        //    bw.Close();
        //    fso.Close();
        //}
        //private static void L2E1()
        //{
        //    FileStream fs = new FileStream(forwardsWavFilePath, FileMode.Open, FileAccess.Read);

        //    BinaryReader br = new BinaryReader(fs);
        //    int length = (int)fs.Length - 8;

        //    fs.Position = 8;
        //    int format = br.ReadInt32();
        //    fs.Position = 20;
        //    short audioFormat = br.ReadInt16();
        //    fs.Position = 22;
        //    short channels = br.ReadInt16();
        //    fs.Position = 24;
        //    int samplerate = br.ReadInt32();
        //    fs.Position = 34;

        //    short BitsPerSample = br.ReadInt16();
        //    int DataLength = (int)fs.Length - 44;

        //    fs.Position = 44;
        //    Console.Write("Valori Esantioane: ");
        //    int toshow = 0;
        //    using (StreamWriter sw = new StreamWriter("beep.txt"))
        //    {
        //        for (int i = 0; i < 31542; i++)
        //        {
        //            short sample = br.ReadInt16();
        //            if (toshow < 19)
        //            {
        //                Console.Write(sample + " ");
        //                toshow++;
        //            }
        //            samples.Add(sample);
        //            sw.WriteLine(sample);
        //        }
        //    }
        //    Console.WriteLine();
        //    br.Close();
        //    fs.Close();

        //    Console.WriteLine("Dimensiune [bytes]: " + length);
        //    Console.WriteLine("Format: " + Encoding.ASCII.GetString(BitConverter.GetBytes(format)));
        //    Console.WriteLine("Audio Format: " + audioFormat);
        //    Console.WriteLine("Canale: " + channels);
        //    Console.WriteLine("Sample rate: " + samplerate);
        //    Console.WriteLine("Bits per sample: " + BitsPerSample);
        //    Console.WriteLine("Data Length [bytes]: " + DataLength);
        //}
        //private static void WriteWavHeader(FileStream stream, ushort channelCount, ushort bitDepth, int sampleRate, int totalSampleCount)
        //{
        //    stream.Position = 0;
        //    stream.Write(Encoding.ASCII.GetBytes("RIFF"), 0, 4);
        //    stream.Write(BitConverter.GetBytes(((bitDepth / 8) * totalSampleCount) + 36), 0, 4);
        //    stream.Write(Encoding.ASCII.GetBytes("WAVE"), 0, 4);
        //    stream.Write(Encoding.ASCII.GetBytes("fmt "), 0, 4);
        //    stream.Write(BitConverter.GetBytes(16), 0, 4);
        //    stream.Write(BitConverter.GetBytes((ushort)(false ? 3 : 1)), 0, 2);
        //    stream.Write(BitConverter.GetBytes(channelCount), 0, 2);
        //    stream.Write(BitConverter.GetBytes(sampleRate), 0, 4);
        //    stream.Write(BitConverter.GetBytes(sampleRate * channelCount * (bitDepth / 8)), 0, 4);
        //    stream.Write(BitConverter.GetBytes((ushort)channelCount * (bitDepth / 8)), 0, 2);
        //    stream.Write(BitConverter.GetBytes(bitDepth), 0, 2);
        //    stream.Write(Encoding.ASCII.GetBytes("data"), 0, 4);
        //    stream.Write(BitConverter.GetBytes((bitDepth / 8) * totalSampleCount), 0, 4);
        //}

        //#endregion

        //#region Laboratorul3
        //static void Laboratorul3()
        //{
        //    L3();
        //}
        //public struct Complex
        //{
        //    public double Real;
        //    public double Imaginary;
        //}
        //public enum Direction
        //{
        //    Forward = 1,
        //    Backward = -1
        //};
        //private static void L3()
        //{
        //    // EX1
        //    int samples = 1024;
        //    Complex[] sin1 = SinWav(400, 15000, "sin1",samples);
        //    Complex[] sin2 = SinWav(1000, 10000, "sin2",samples);
        //    Complex[] sin3 = SinComp(1000,samples);

        //    // EX2
        //    Complex[] fsin1 = DFT(sin1,Direction.Forward);
        //    Complex[] fsin2 = DFT(sin2,Direction.Forward);
        //    Complex[] fsin3 = DFT(sin3,Direction.Forward);

        //    double[] magSin1, magSin2,magSin3;

        //    magSin1 = new double[fsin1.Length];
        //    magSin2 = new double[fsin1.Length];
        //    magSin3 = new double[fsin1.Length];

        //    for(int i=0;i<fsin1.Length;i++)
        //    {
        //        magSin1[i] = Math.Sqrt(Math.Pow(fsin1[i].Real,(double)2)+Math.Pow(fsin1[i].Imaginary,(double)2));
        //        magSin2[i] = Math.Sqrt(Math.Pow(fsin2[i].Real,(double)2)+Math.Pow(fsin2[i].Imaginary,(double)2));
        //        magSin3[i] = Math.Sqrt(Math.Pow(fsin3[i].Real,(double)2)+Math.Pow(fsin3[i].Imaginary,(double)2));
        //    }

        //    using (StreamWriter sw = new StreamWriter("magSin.txt"))
        //    {
        //        for (int i = 0; i < fsin1.Length; i++)
        //        {
        //            sw.WriteLine($"{magSin1[i]}\t{magSin2[i]}\t{magSin3[i]}");
        //        }
        //    }

        //    // EX3
        //    // tau = 1 / 8000 s = 0.125 ms
        //    // t = 1023 * 0.125 ms = 127.875 ms = 0.127875 s

        //    // f1 = ksin1 / t = (52 - 1) / 0.127875 = 398.8 Hz < 400 Hz
        //    // f2 = ksin2 / t = (129 - 1) / 0.127875 = 1000.9 Hz > 1000 Hz

        //    // EX4
        //    Complex[] invSin3 = DFT(fsin3, Direction.Backward);
        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\invSin3.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, samples);
        //    BinaryWriter bw = new BinaryWriter(fso);
        //    short[] sin3Freqs = new short[invSin3.Length];
        //    for(int i =0;i< invSin3.Length; i++)
        //    {
        //        bw.Write((short)(invSin3[i].Real));
        //        sin3Freqs[i] = (short)(invSin3[i].Real);
        //    }
        //    bw.Close();
        //    fso.Close();
        //    Laboratorul4(sin3Freqs);
        //}
        //private static Complex[] SinWav(int freq, int amp,string file,int samples)
        //{
        //    Complex[] data = new Complex[samples];
        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\{file}.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16,  8000, samples);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (double t = 0; t < 1024; t ++)
        //    {
        //        double y = amp * Math.Sin(2 *Math.PI* freq * t/8000);
        //        bw.Write((short)y);
        //        data[(int)t].Real = y;
        //    }
        //    bw.Close();
        //    fso.Close();

        //    return data;
        //}
        //private static Complex[] SinComp(int freq, int samples)
        //{
        //    Complex[] data = new Complex[samples];
        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\sin3.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, samples);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (double t = 0; t < 1024; t++)
        //    {
        //        double y = 15000 * Math.Sin(2 * Math.PI * 400 * t/8000) + 10000 * Math.Sin(2 * Math.PI * 1000 * t/8000);
        //        bw.Write((short)y);
        //        data[(int)t].Real = y;
        //    }
        //    bw.Close();
        //    fso.Close();

        //    return data;
        //}

        //public static Complex[] DFT(Complex[] data, Direction direction)
        //{
        //    int N = data.Length;
        //    double arg, cos, sin;

        //    Complex[] X = new Complex[N];

        //    for (int k = 0; k < N; k++)
        //    {
        //        X[k].Real = 0;
        //        X[k].Imaginary = 0;

        //        arg = -(int)direction * 2.0 * System.Math.PI * (double)k / (double)N;

        //        for (int n = 0; n < N; n++)
        //        {
        //            cos = System.Math.Cos(n * arg);
        //            sin = System.Math.Sin(n * arg);

        //            X[k].Real += (data[n].Real * cos - data[n].Imaginary * sin);
        //            X[k].Imaginary += (data[n].Real * sin + data[n].Imaginary * cos);
        //        }
        //    }

        //    if (direction == Direction.Backward)
        //    {
        //        for (int i = 0; i < N; i++)
        //        {
        //            data[i].Real = X[i].Real / N;
        //            data[i].Imaginary = X[i].Imaginary / N;
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < N; i++)
        //        {
        //            data[i].Real = X[i].Real;
        //            data[i].Imaginary = X[i].Imaginary;
        //        }
        //    }
        //    return data;
        //}
        //#endregion

        //#region Laboratorul4

        //static double fc, fsamp,f1,f2;
        //static int Ns;
        //static short[] h = new short[1024];
        //static int amps = 150000;

        //static void L4Start(short[] freqs)
        //{
        //    fc = 400;
        //    fsamp = 8000;
        //    Ns = 1024;
        //    f1 = freqs[54];
        //    f2 = freqs[1024-54];
        //}
        //static void Laboratorul4(short[] freqs)
        //{
        //    L4Start(freqs);
        //    h = freqs;
        //    L4Low(fc, fsamp, Ns);
        //    h = freqs;
        //    L4High(fc, fsamp, Ns);
        //    h = freqs;
        //    L4TB(f1, f2, fsamp, Ns);
        //    h = freqs;
        //    L4SB(f1, f2, fsamp, Ns);
        //    h = freqs;
        //    L4S4(fc, fsamp, Ns);
        //}

        //static void L4Low(double f_c, double f_samp, int N)
        //{
        //    double[] h2 = new double[1024];
        //    for (int i = 0; i < N; i++)
        //    {
        //        h2[i] = h[i];
        //    }

        //    f_c = f_c / f_samp;

        //    double w_c = 2 * Math.PI * f_c;

        //    double middle = N / 2;

        //    for (int i = -N / 2; i < N / 2; i++)
        //    {
        //        if (i == 0)
        //        {
        //            h2[(int)middle] = (2 * f_c);
        //        }
        //        else
        //        {
        //            h2[(int)(i + middle)] = (Math.Sin(w_c * i) / (Math.PI * i));
        //        }
        //    }

        //    for (int i = 0; i < N; i++)//
        //    {
        //        h[i] *= (short)(0.5 * 0.5 * Math.Cos((2 * Math.PI * i) / N));
        //    }

        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\sin3Low.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, 1024);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (int t = 0; t < 1024; t++)
        //    {
        //        bw.Write((short)(h2[t]*amps));
        //    }
        //    bw.Close();
        //    fso.Close();
        //}
        //static void L4High(double f_c, double f_samp, int N)
        //{
        //    double[] h2 = new double[1024];
        //    for (int i = 0; i < N; i++)
        //    {
        //        h2[i] = h[i];
        //    }

        //    f_c = f_c / f_samp;

        //    double w_c = 2 * Math.PI * f_c;

        //    double middle = N / 2;

        //    for (int i = -N / 2; i < N / 2; i++)
        //    {
        //        if (i == 0)
        //        {
        //            h2[(int)middle] = (1 - 2 * f_c);
        //        }
        //        else
        //        {
        //            h2[(int)(i + middle)] = (-Math.Sin(w_c * i) / (Math.PI * i));
        //        }
        //    }
        //    for (int i = 0; i < N; i++)//
        //    {
        //        h[i] *= (short)(0.5 * 0.5 * Math.Cos((2 * Math.PI * i) / N));
        //    }

        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\sin3High.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, 1024);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (int t = 0; t < 1024; t++)
        //    {
        //        bw.Write((short)(h2[t] * amps));
        //    }
        //    bw.Close();
        //    fso.Close();
        //}

        //static void L4SB(double f_1, double f_2, double f_samp, int N)
        //{
        //    double[] h2 = new double[1024];
        //    for (int i = 0; i < N; i++)
        //    {
        //        h2[i] = h[i];
        //    }

        //    double f_1c = f_1 / f_samp;
        //    double f_2c = f_2 / f_samp;

        //    double w_1c = 2 * Math.PI * f_1c;
        //    double w_2c = 2 * Math.PI * f_2c;

        //    double middle = N / 2;

        //    for (int i = -N / 2; i < N / 2; i++)
        //    {
        //        if (i == 0)
        //        {
        //            h2[(int)middle] = (1 - 2 * (f_2c - f_1c));
        //        }
        //        else
        //        {
        //            h2[(int)(i + middle)] = (Math.Sin(w_1c * i) / (Math.PI * i) - Math.Sin(w_2c * i) / (Math.PI * i));
        //        }
        //    }
        //    for (int i = 0; i < N; i++)//
        //    {
        //        h[i] *= (short)(0.5 * 0.5 * Math.Cos((2 * Math.PI * i) / N));
        //    }

        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\sin3SB.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, 1024);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (int t = 0; t < 1024; t++)
        //    {
        //        bw.Write((short)(h2[t] * amps));
        //    }
        //    bw.Close();
        //    fso.Close();
        //}

        //static void L4TB(double f_1, double f_2, double f_samp, int N)
        //{
        //    double[] h2 = new double[1024];
        //    for (int i = 0; i < N; i++)
        //    {
        //        h2[i] = h[i];
        //    }

        //    double f_1c = f_1 / f_samp;
        //    double f_2c = f_2 / f_samp;

        //    double w_1c = 2 * Math.PI * f_1c;
        //    double w_2c = 2 * Math.PI * f_2c;

        //    double middle = N / 2;

        //    for (int i = -N / 2; i < N / 2; i++)
        //    {
        //        if (i == 0)
        //        {
        //            h2[(int)middle] = (2 * (f_2c - f_1c));
        //        }
        //        else
        //        {
        //            h2[(int)(i + middle)] = (Math.Sin(w_2c * i) / (Math.PI * i) - Math.Sin(w_1c * i) / (Math.PI * i));
        //        }
        //    }
        //    for (int i = 0; i < N; i++)//
        //    {
        //        h[i] *= (short)(0.5 * 0.5 * Math.Cos((2 * Math.PI * i) / N));
        //    }

        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\sin3TB.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, 1024);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (int t = 0; t < 1024; t++)
        //    {
        //        bw.Write((short)(h2[t] * amps));
        //    }
        //    bw.Close();
        //    fso.Close();
        //}

        //static void L4S4(double f_c, double f_samp, int N)
        //{
        //    double[] h2 = new double[1024];
        //    for (int i = 0; i < N; i++)
        //    {
        //        h2[i] = h[i];
        //    }

        //    f_c = f_c / f_samp;

        //    double w_c = 2 * Math.PI * f_c;

        //    double middle = N / 2;

        //    for (int i = -N / 2; i < N / 2; i++)
        //    {
        //        if (i == 0)
        //        {
        //            h2[(int)middle] = (2 * f_c);
        //        }
        //        else
        //        {
        //            h2[(int)(i + middle)] = (Math.Sin(w_c * i) / (Math.PI * i));
        //        }
        //    }

        //    for (int i = 0; i < N; i++)
        //    {
        //        h2[i] *= (0.5 * 0.5 * Math.Cos((2 * Math.PI * i) / N));
        //    }

        //    FileStream fso = new FileStream($"B:\\MEGA\\Facultate\\Master\\An1Sem2\\PIS\\sin4.wav", FileMode.Create, FileAccess.Write);
        //    WriteWavHeader(fso, 1, 16, 8000, 1024);
        //    BinaryWriter bw = new BinaryWriter(fso);

        //    for (int t = 0; t < 1024; t++)
        //    {
        //        bw.Write((short)(h2[t] * amps));
        //    }
        //    bw.Close();
        //    fso.Close();
        //}
        //#endregion

        //#region laboratorul5
        //static void Laboratorul5()
        //{
        //    Image<Bgr, Byte> img1 = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L5\1.jpg");

        //    L5E1(img1);//Ex 1

        //    for (int i = 0; i < img1.Height; i++)
        //    {
        //        for (int j = 0; j < img1.Width; j++)
        //        {
        //            int r = new Random().Next(0, 256);
        //            int g = new Random().Next(0, 256);
        //            int b = new Random().Next(0, 256);
        //            img1[i, j] = new Bgr(r, g, b);
        //        }
        //    }
        //    img1.ToBitmap().Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L5\random.jpg");

        //    L5E2();//Ex 2
        //    L5E3();//Ex 3

        //    Console.Write("\n");
        //}

        //static void L5E1(Image<Bgr, Byte> img)
        //{
        //    Bgr white = new Bgr(255, 255, 255);
        //    Bgr black = new Bgr(0, 0, 0);

        //    for (int i = 0; i < img.Height; i++)
        //    {
        //        for (int j = 0; j < img.Width; j++)
        //        {

        //            if ((i + j) % 2 == 0)
        //            {
        //                img[i, j] = white;
        //            }
        //            else
        //            {
        //                img[i, j] = black;
        //            }

        //        }
        //    }
        //    img.ToBitmap().Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L5\chess.jpg");

        //    for (int i = 0; i < img.Height; i++)
        //    {
        //        for (int j = 0; j < img.Width; j++)
        //        {
        //            if ((i + j) % 2 == 0)
        //            {
        //                img[i, j] = white;
        //            }
        //            else
        //            {
        //                int r = new Random().Next(0, 256);
        //                int g = new Random().Next(0, 256);
        //                int b = new Random().Next(0, 256);
        //                img[i, j] = new Bgr(r, g, b);
        //            }
        //        }
        //    }
        //    img.ToBitmap().Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L5\chess_random.jpg");
        //}
        //static void L5E2()
        //{
        //    Image<Bgr, Byte> imgRandom = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L5\random.jpg");
        //    Console.WriteLine("Ex 2:");
        //    for (int i = 0; i < imgRandom.Height; i++)
        //    {
        //        for (int j = 0; j < imgRandom.Width; j++)
        //        {
        //            Console.Write(imgRandom[i, j] + " ");
        //        }
        //        Console.Write("\n");
        //    }
        //}
        //static void L5E3()
        //{
        //    Image<Bgr, Byte> img = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L5\8x8.bmp");
        //    Console.WriteLine($"\nEx 3:");
        //    Img_Details(img);

        //    L5E4(img);//Ex 4

        //}
        //static void Img_Details(Image<Bgr,Byte> img)
        //{

        //    Console.WriteLine($"Inaltime: {img.Height}");
        //    Console.WriteLine($"Latime: {img.Width}");

        //    switch (img.Mat.Depth.ToString())
        //    {
        //        case "Cv8U":
        //            Console.WriteLine($"Bits/Pixel: unsigned 8");
        //            break;
        //        case "Cv32F":
        //            Console.WriteLine($"Bits/Pixel: float 32");
        //            break;
        //        case "Cv32S":
        //            Console.WriteLine($"Bits/Pixel: signed 32");
        //            break;
        //    }


        //    int bits = 0;

        //    Console.Write($"Valori Culori:");
        //    List<Bgr> colors = new List<Bgr>();
        //    for (int i = 0; i < img.Height; i++)
        //    {
        //        for (int j = 0; j < img.Width; j++)
        //        {
        //            if (!colors.Contains(img[i, j]))
        //            {
        //                colors.Add(img[i, j]);
        //                bits += img[i, j].Dimension;
        //            }
        //        }
        //    }
        //    foreach (Bgr color in colors)
        //    {
        //        Console.Write(color + " ");
        //    }
        //}
        //static void L5E4(Image<Bgr,Byte> img)
        //{
        //    for (int i = 0; i < img.Height; i++)
        //    {
        //        for (int j = 0; j < img.Width; j++)
        //        {
        //            int r = (img[i, j].Red == 0) ? 128 : 192;
        //            int g = (img[i, j].Green == 0) ? 128 : 192;
        //            int b = (img[i, j].Blue == 0) ? 128 : 192;
        //            img[i, j] = new Bgr(r, g, b);
        //        }
        //    }
        //    img.ToBitmap().Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L5\8x8_new.bmp");

        //    Console.WriteLine($"\n\nEx 4:");
        //    Img_Details(img);

        //}
        //#endregion
        #region Laboratorul 6
        static void Laboratorul6()
        {
            //Ex 1
            Image<Bgr, Byte> img1 = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\imgV.bmp");
            Size = img1.Width;
            Complex[][] imgComplex = Forward(img1.ToBitmap());
            Bitmap x = VisualizeFourier(imgComplex);
            x.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\imgVF.bmp");

            img1 = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\imgH.bmp");
            Size = img1.Width;
            imgComplex = Forward(img1.ToBitmap());
            x = VisualizeFourier(imgComplex);
            x.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\imgHF.bmp");

            img1 = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\imgC.bmp");
            Size = img1.Width;
            imgComplex = Forward(img1.ToBitmap());
            x = VisualizeFourier(imgComplex);
            x.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\imgCF.bmp");

            //Ex2

            img1 = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\64.bmp");
            Bitmap imgB = img1.ToBitmap();
            for (int i = 0; i < img1.Height; i++)
            {
                for (int j = 0; j < img1.Width; j++)
                {
                    Color oc = imgB.GetPixel(i, j);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    imgB.SetPixel(i, j, nc);
                }
            }
            imgB.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\64_1.bmp");

            img1 = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\64_1.bmp");
            Size = img1.Width;
            imgComplex = Forward(img1.ToBitmap());
            x = VisualizeFourier(imgComplex);
            x.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\64_2.bmp");

            x = Inverse(imgComplex);
            x.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\64_3.bmp");

            //Ex3 Ex4

            Cosine("imgH");
            Cosine("imgV");
            Cosine("imgC");

        }

        public static void Cosine(string image)
        {
            int w;
            int h;
            int width;
            int height;

            Image<Bgr, Byte> img1 = new Image<Bgr, Byte>(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\" + image + ".bmp");

            Bitmap bitmap = new Bitmap(img1.ToBitmap());
            width = bitmap.Width;
            height = bitmap.Height;

            Bitmap imageIDCT = new Bitmap(width, height);
            Graphics image_IDCT = Graphics.FromImage(imageIDCT);

            Bitmap imageDCT = new Bitmap(width, height);
            Graphics image_DCT = Graphics.FromImage(imageDCT);

            w = h = img1.Width;

            DCT d = new DCT(w, h);

            for (int y = 0; y < height / h; y++)
            {
                for (int j = 0; j < width / w; j++)
                {
                    Bitmap sector = new Bitmap(w, h);
                    Graphics g = Graphics.FromImage(sector);

                    Rectangle dest = new Rectangle(0, 0, w, h);
                    Rectangle src = new Rectangle(j * w, y * h, w, h);

                    g.DrawImage(bitmap, dest, src, GraphicsUnit.Pixel);

                    double[][,] values = d.BitmapToMatrices(sector);
                    double[][,] coeffs = d.DCTMatrices(values);//DCT

                    image_DCT.DrawImage(d.MatricesToBitmap(coeffs, false), src, dest, GraphicsUnit.Pixel);

                    values = d.IDCTMatrices(coeffs);//IDCT
                    image_IDCT.DrawImage(d.MatricesToBitmap(values), src, dest, GraphicsUnit.Pixel);
                }
            }
            imageIDCT.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\" + image + "_IDCT.bmp");
            imageDCT.Save(@"B:\MEGA\Facultate\Master\An1Sem2\PIS\L6\" + image + "_DCT.bmp");
        }

        public static Bitmap VisualizeFourier(Complex[][] f)
        {
            float[] frequencies = new float[Size * Size];
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[0].Length; j++)
                {
                    frequencies[j * f.Length + i] = Complex.Modulus(f[j][i]);
                }
            }

            float min = frequencies.Min();
            float max = frequencies.Max();
            double log_constant = 255 / Math.Log10(1 + 255);
            for (int i = 0; i < frequencies.Length; i++)
            {
                frequencies[i] = 255 * (frequencies[i] - min) / (max - min);
                frequencies[i] = (int)(Math.Log10(1 + frequencies[i]) * log_constant);
            }

            Bitmap image = new Bitmap(Size, Size);
            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, Size, Size),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] result = new byte[bytes];
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    int pixel_position = y * image_data.Stride + x * 4;
                    for (int i = 0; i < 3; i++)
                    {
                        result[pixel_position + i] = (byte)frequencies[y * Size + x];
                    }
                    result[pixel_position + 3] = 255;
                }
            }
            Marshal.Copy(result, 0, image_data.Scan0, bytes);
            image.UnlockBits(image_data);
            return image;
        }

        public static int Size;

        public static Complex[][] ToComplex(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData input_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            int bytes = input_data.Stride * input_data.Height;

            byte[] buffer = new byte[bytes];
            Complex[][] result = new Complex[w][];

            Marshal.Copy(input_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(input_data);

            int pixel_position;

            for (int x = 0; x < w; x++)
            {
                result[x] = new Complex[h];
                for (int y = 0; y < h; y++)
                {
                    pixel_position = y * input_data.Stride + x * 4;
                    result[x][y] = new Complex(buffer[pixel_position], 0);
                }
            }

            return result;
        }

        public static Complex[] Forward(Complex[] input, bool phaseShift = true)
        {
            Complex[] result = new Complex[input.Length];
            float omega = (float)(-2.0 * Math.PI / input.Length);

            if (input.Length == 1)
            {
                result[0] = input[0];

                if (Complex.IsNaN(result[0]))
                {
                    return new[] { new Complex(0, 0) };
                }
                return result;
            }

            Complex[] evenInput = new Complex[input.Length / 2];
            Complex[] oddInput = new Complex[input.Length / 2];

            for (int i = 0; i < input.Length / 2; i++)
            {
                evenInput[i] = input[2 * i];
                oddInput[i] = input[2 * i + 1];
            }

            Complex[] even = Forward(evenInput, phaseShift);
            Complex[] odd = Forward(oddInput, phaseShift);

            for (int k = 0; k < input.Length / 2; k++)
            {
                int phase;

                if (phaseShift)
                {
                    phase = k - Size / 2;
                }
                else
                {
                    phase = k;
                }
                odd[k] *= Complex.Polar(1, omega * phase);
            }

            for (int k = 0; k < input.Length / 2; k++)
            {
                result[k] = even[k] + odd[k];
                result[k + input.Length / 2] = even[k] - odd[k];
            }

            return result;
        }

        public static Complex[][] Forward(Bitmap image)
        {
            Complex[][] p = new Complex[Size][];
            Complex[][] f = new Complex[Size][];
            Complex[][] t = new Complex[Size][];

            Complex[][] complexImage = ToComplex(image);

            for (int l = 0; l < Size; l++)
            {
                p[l] = Forward(complexImage[l]);
            }

            for (int l = 0; l < Size; l++)
            {
                t[l] = new Complex[Size];
                for (int k = 0; k < Size; k++)
                {
                    t[l][k] = p[k][l];
                }
                f[l] = Forward(t[l]);
            }

            return f;
        }

        public static Complex[] Inverse(Complex[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Complex.Conjugate(input[i]);
            }

            Complex[] transform = Forward(input, false);

            for (int i = 0; i < input.Length; i++)
            {
                transform[i] = Complex.Conjugate(transform[i]);
            }

            return transform;
        }

        public static Bitmap Inverse(Complex[][] frequencies)
        {
            Complex[][] p = new Complex[Size][];
            Complex[][] f = new Complex[Size][];
            Complex[][] t = new Complex[Size][];

            Bitmap image = new Bitmap(Size, Size);
            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, Size, Size),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] result = new byte[bytes];

            for (int i = 0; i < Size; i++)
            {
                p[i] = Inverse(frequencies[i]);
            }

            for (int i = 0; i < Size; i++)
            {
                t[i] = new Complex[Size];
                for (int j = 0; j < Size; j++)
                {
                    t[i][j] = p[j][i] / (Size * Size);
                }
                f[i] = Inverse(t[i]);
            }

            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    int pixel_position = y * image_data.Stride + x * 4;
                    for (int i = 0; i < 3; i++)
                    {
                        result[pixel_position + i] = (byte)Complex.Modulus(f[x][y]);
                    }
                    result[pixel_position + 3] = 255;
                }
            }

            Marshal.Copy(result, 0, image_data.Scan0, bytes);
            image.UnlockBits(image_data);
            return image;
        }

        #endregion
    }
}