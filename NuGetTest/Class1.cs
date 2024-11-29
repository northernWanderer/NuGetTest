using System.Runtime.InteropServices.Marshalling;

namespace NuGetTest
{
    public class Class1
    {
        public void Log(string text)
        {
            using (FileStream fileStream = new FileStream("log.log", FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(text);
                }
            }
        }
    }
}
