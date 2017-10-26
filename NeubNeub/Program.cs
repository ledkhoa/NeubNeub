using System;
using System.IO;
using System.Net;

namespace NeubNeub
{
    class Program
    {
        static void Main(string[] args) => new NeubNeub().Start().GetAwaiter().GetResult();

        //static void Main(string[] args)
        //{

        //    //string ID = "2_snbC95";
        //    //string SECRET = "5oWqctyXzBNrDtbIRbfHHhyxlwZdFOJziZn5rcbT3eU_PYSqok5bYn7v5uIDqcCH";


        //    //            string tags = string.Join("+", input);
        //    string gfyURI = "https://api.gfycat.com/v1/oauth/token/grant_type=client_credentials&client_id=2_BlrBi1&client_secret=sEHTVBl7LTJynhYwq38u0Ql7t-_wxdNN6Ar9NoUKGbMyvGfxG-vcH6AO3JprfsgZ";

        //    string gfyResponse = string.Empty;

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(gfyURI.ToString());
        //    request.Method = "POST";

        //    try
        //    {
        //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        //        using (var respReader = new StreamReader(response.GetResponseStream()))
        //            gfyResponse = respReader.ReadToEnd();
        //    }
        //    catch(Exception e)
        //    {
        //        System.Console.WriteLine(e.Message);
        //    }

        //}
    }
}