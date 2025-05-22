using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace ASCII_FORM
{
    class Convert
    {
        public static Base baseForm;

        public static string path = "";
        public static int width = 0;
        public static double contrast = 0.0;

        public static string encoder = "";

        public static double[,] pixels;
        public static double average = 0.0;
        public static double averageDifference = 0.0;

        public static string text = "";

        public static int maxNumberOfThreads = 10;
        public static int numberOfLinesPerThread = 60;

        public static int linesNow = 0;

        public static string[] encoderList = {
            "@@8%MW52tvvf(!,.``` ",
            "@NQ0#8BgD%KbHRU4$&AP6GMhpVWOwyXqZdue]9oma|n[TIJ2Yv5731ktECSj+LzFls\\)x/i>({}*cf!?_<=;r^\"-:,~.'` ",
            "@N#gKR$PMVwqu9a[Jv3tSLl)i{c?=^:. ",
            "@NBKUAMWXuonJ5kSz\\i}!=\"~ ",
            "@N#%UPpyumTvkjl/}?r, "
        };

        public static void convert() {
            if (!string.IsNullOrEmpty(baseForm.pathTextBox.Text) && !string.IsNullOrEmpty(baseForm.widthTextBox.Text) && !string.IsNullOrEmpty(baseForm.encodingTextBox.Text)
                && (baseForm.contrastCheckBox.Checked ? (baseForm.automaticCheckBox.Checked ? true : !string.IsNullOrEmpty(baseForm.contrastTextBox.Text)) : true))
            {
                try
                {
                    calc();
                }
                catch {
                    baseForm.timer1.Stop();
                    baseForm.convertingLabel.Text = "";
                }
            }
            else {
                baseForm.timer1.Stop();
                baseForm.convertingLabel.Text = "";
            }
        }

        public static void calc() {
            //SET VARIABLES
            setVariables();


            //INITIALIZE IMAGE
            Image image;

            if (baseForm.urlCheckBox.Checked)
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(baseForm.pathTextBox.Text);

                image = Image.FromStream(stream);

                stream.Flush();
                stream.Close();
                client.Dispose();
            }
            else {
                image = Image.FromFile(path);
            }

            int imageHeight = (int)((double)image.Height * ((double)width / (double)image.Width) / 2);
            image = resizeImage(image, new Size(width, imageHeight));

            //SET PIXEL ARRAY
            setArray(image);

            if (baseForm.contrastCheckBox.Checked)
            {
                if (baseForm.automaticCheckBox.Checked)
                {
                    getAverageDifference();
                    double expectedAverage = 0.18;
                    expectedAverage = (average + 1) * (expectedAverage);

                    //TEMP
                    expectedAverage = 0.3;
                    //TEMP

                    double calculated = averageDifference == 0 ? 0 : ((expectedAverage / averageDifference) * 1.2805);
                    contrast = calculated;
                }
                else {
                    contrast = Double.Parse(baseForm.contrastTextBox.Text.Replace(".", ","));
                }
                setContrast();
            }

            text = manageTasks();

            baseForm.timer1.Stop();
            baseForm.convertingLabel.Text = "Completed";
            baseForm.percentageLabel.Text = "";
        }

        public static void setVariables() {
            text = "";
            linesNow = 0;

            path = baseForm.pathTextBox.Text;
            width = Int32.Parse(baseForm.widthTextBox.Text);
            encoder = baseForm.encodingTextBox.Text;
        }

        public static string manageTasks() {
            string result = "";

            int overall = (int)Math.Ceiling((double)pixels.GetLength(1) / (double)(numberOfLinesPerThread * maxNumberOfThreads));

            for (int i = 0; i < overall; i++) {
                int start = (numberOfLinesPerThread * maxNumberOfThreads) * i;
                start = start > pixels.GetLength(1) ? pixels.GetLength(1) : start;
                int end = start + (numberOfLinesPerThread * maxNumberOfThreads);
                end = end > pixels.GetLength(1) ? pixels.GetLength(1) : end;

                int reminder = end - start;

                int numberOfTasks = (int)Math.Ceiling((double)reminder / (double)numberOfLinesPerThread);
                string[] array = new string[numberOfTasks];

                List<Task> allTasks = new List<Task>();
                for (int b = 0; b < numberOfTasks; b++)
                {
                    int copyB = b;
                    Task task = new Task(() =>
                    {
                        int start1 = (copyB * numberOfLinesPerThread) + start;
                        start1 = start1 > pixels.GetLength(1) ? pixels.GetLength(1) : start1;
                        int end1 = (copyB * numberOfLinesPerThread) + numberOfLinesPerThread;
                        end1 = end1 > reminder ? reminder + start : end1 + start;

                        array[copyB] = convertArray(start1, end1);
                    });
                    allTasks.Add(task);
                    task.Start();
                }

                Task.WaitAll(allTasks.ToArray());

                result += "\n" + string.Join("\n", array);
            }

            return result;
        }

        public static string convertArray(int start, int end) {
            string result = "";

            for (int y = start; y < end; y++)
            {
                for (int x = 0; x < pixels.GetLength(0); x++)
                {
                    result += encoder[convertNumber(pixels[x, y])];
                }
                result += y == pixels.GetLength(1) - 1 ? "" : "\r\n";
                linesNow++;
            }

            return result;
        }

        public static void setArray(Image image)
        {
            pixels = new double[image.Width, image.Height];

            using (Bitmap bmp = new Bitmap(image))
            {
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        pixels[x, y] = bmp.GetPixel(x, y).GetBrightness();
                    }
                }
            }
        }

        public static void setContrast()
        {
            for (int y = 0; y < pixels.GetLength(1); y++)
            {
                for (int x = 0; x < pixels.GetLength(0); x++)
                {
                    pixels[x, y] = ((pixels[x, y] - average) * contrast) + average;
                    pixels[x, y] = pixels[x, y] > 1 ? 1 : pixels[x, y];
                    pixels[x, y] = pixels[x, y] < 0 ? 0 : pixels[x, y];
                }
            }
        }

        public static double getAverage()
        {
            double average1 = 0.0;

            for (int y = 0; y < pixels.GetLength(1); y++)
            {
                for (int x = 0; x < pixels.GetLength(0); x++)
                {
                    average1 += pixels[x, y];
                }
            }

            average1 = average1 / (pixels.GetLength(1) * pixels.GetLength(0));
            return average1;
        }

        public static void getAverageDifference()
        {
            double average1 = getAverage();
            double averageDifference1 = 0.0;

            for (int y = 0; y < pixels.GetLength(1); y++)
            {
                for (int x = 0; x < pixels.GetLength(0); x++)
                {
                    averageDifference1 += Math.Abs(pixels[x, y] - average1);
                }
            }

            averageDifference1 = averageDifference1 / (pixels.GetLength(1) * pixels.GetLength(0));

            average = average1;
            averageDifference = averageDifference1;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public static int convertNumber(double number)
        {
            int index = (int)Math.Floor(number * Double.Parse(encoder.Length.ToString()));
            return index == encoder.Length ? index - 1 : index;
        }
    }
}
