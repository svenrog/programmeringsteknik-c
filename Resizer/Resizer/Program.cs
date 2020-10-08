using CommandLine;
using Imageflow.Fluent;
using System;
using System.IO;

namespace Resizer
{
    class Options
    {
        [Option('i', "input", Required = true, HelpText = "Path to input file.")]
        public string Input { get; set; }

        [Option('w', "width", Required = false, HelpText = "Width of output image.")]
        public uint? Width { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Dessa övningar använder imageflow
            // https://github.com/imazen/imageflow-dotnet#examples
            // (alla beroenden är installerade i projektet redan)

            // ImageJob.Decode med en System.IO.Stream som parameter laddar in en bild.
            // BuildNode.EncodeToStream (via method chain) kan användas för att skriva till fil

            // På grund av att imageflow är anpassat att köras på server, med kö-hantering,
            // behöver Finish().InProcessAsync() kallas för att beordra avslut på körningen.
            // InProcessAsync() är en asynkron metod och behöver inväntas, 
            // detta kan göras genom att lägga till .Wait(), annars avslutas programmet för tidigt.

            // Options-objektet behöver skapas från args
            // https://github.com/commandlineparser/commandline#quick-start-examples


            // 1. Skala om en bild beroende på angiven breddparameter, tex. 512px
            // 2. Lägg till en höjdparameter och skala om beroende på dessa.
            // 3. Lägg till ett skärpefilter om bildens storlek minskas.
            // 4. Lägg till parametrar för färgmättnad, ljusstyrka och kontrast.

            Parser.Default.ParseArguments<Options>(args) //Utveckla vidare, läs in directory i args. Directory.RunFiles (?)
                            .WithParsed<Options>(Run);
        }

        static void Run(Options options)
        {

            using (var stream = File.OpenRead(options.Input)) //ingående fil
            {
                var outputFileName = GetOutputFileName(options.Input);
                //Test
                using (var outStream = File.OpenWrite(outputFileName)) // utgående fil
                {

                    using (var job = new ImageJob())
                    {
                        job.Decode(stream, false)
                        #region // Här kan man ändra bilden innan den skrivs ut
                            .Distort(812, 512)
                            
                        #endregion
                            .EncodeToStream(outStream, false, new MozJpegEncoder(90))
                            .Finish()
                            .InProcessAsync()
                            .Wait();
                    }
                }
            }
        }

        static string GetOutputFileName(string path)
        {
            string directory = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path); 
            string extenstion = Path.GetExtension(path);  // extension = tex. .Json .Img

            string newFileName = $"{directory}{fileName}-resized{extenstion}";

            return Path.Combine(directory, newFileName);
        }
    }
}
