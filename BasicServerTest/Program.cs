using System.Net;
using System.Threading;
using System.Text.Json;


namespace FinalTestSample
{


    public class Listener
    {
    }

    public class ServerLoop
    {
        HttpListener _listener;
        string _address;
        public ServerLoop(string address, string port)
        {
            _listener = new HttpListener();
            _address = "http://127.0.0.1" + ":" + port + "/";
            
        }

        public void AddRestAPI(string apiName)
        {
            _listener.Prefixes.Add(_address + apiName + "/");
        }
        public void Run()
        {
            _listener.Start();
            Console.WriteLine("Listening...");

            while (true)
            {

            }
        }

        public void Close()
        {
            _listener.Stop();
        }
    }

    public class HttpService
    {
        HttpService(HttpListener _listener)
        {
            HttpListenerContext context = _listener.GetContext();
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
        }

        HttpListenerContext context;
        HttpListenerRequest request;
        HttpListenerResponse response;

    }

    public class Program
    {
        public static int Main()
        {
            ServerLoop server = new ServerLoop("http://127.0.0.1","3000");
            server.Prefixes.Add("GodDamn");
            server.Prefixes.Add("GodDamn");
            server.Prefixes.Add("GodDamn");
            server.Prefixes.Add("GodDamn");
            server.Prefixes.Add("GodDamn");
            server.Run();


            HttpListenerContext context = listener.GetContext();
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            response.AddHeader("Access-Control-Allow-Origin", "*");
            Stream body = request.InputStream;
            System.Text.Encoding encoding = request.ContentEncoding;
            System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);

            string rawurl = request.RawUrl;
            string httpmethod = request.HttpMethod;

            string result = "";

            result += string.Format("httpmethod = {0}\r\n", httpmethod);
            result += string.Format("rawurl = {0}\r\n", rawurl);
            System.Console.WriteLine(result);

            soo s = new soo();
            s.body = "MaryJane";

            string responseString = JsonSerializer.Serialize(s);
            System.Console.WriteLine(responseString);
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();


            return 0;
        }
    }
}