namespace HW_3._5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
          string str= await HelloWorldAsync();
            Console.WriteLine(str); 
        }

        public static async Task<string> ReadHelloAsync()
        {
          return await Task.Run(() =>
            {
                string hello;
                using (var sr = new StreamReader("Hello.txt"))
                {
                    hello = Convert.ToString(sr.ReadToEnd());       
                }
                return hello; 
            });          
        }

        public static async Task<string> ReadWorldAsync()
        {
            return await Task.Run(() =>
            {
                string world;
                using (var sr = new StreamReader("World.txt"))
                {
                    world = Convert.ToString(sr.ReadToEnd());
                }
                return world;
            });
        }

        public static async Task<string> HelloWorldAsync()
        {
            return await Task.Run( async () =>
            {
               string hello =  await ReadHelloAsync();
               string world =  await ReadWorldAsync();
               string HelloWorld = hello +" "+ world;
               return HelloWorld;
               
            });
        }
    }
}