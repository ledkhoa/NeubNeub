//using System.Text;
//using System.Threading.Tasks;
//using Discord.Commands;
//using System.Net.Http;
//using System.Xml.Linq;
//using System.Xml.XPath;
//using System.Runtime.Serialization.Json;
//using System.Net;
//using System.IO;

//namespace NeubNeub.Modules
//{
//    public class Gfycat : ModuleBase<SocketCommandContext>
//    {
//        private const string APPLICATION_TOKEN = "Bearer NxBiGpocgbKAE9pn8iLRm_NNaJsa";
//        private const string ID = "2_snbC95";
//        private const string SECRET = "5oWqctyXzBNrDtbIRbfHHhyxlwZdFOJziZn5rcbT3eU_PYSqok5bYn7v5uIDqcCH";

//        [Command("gfy")]
//        public async Task Gfy(params string[] input)
//        {
//            string tags = string.Join("+", input);
//            string gfyURI = "https://api.gfycat.com/v1test/gfycats/search?search_text=" + tags + "&count=1";

//            string gfyResponse = string.Empty;

//            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(gfyURI.ToString());
//            request.Method = "GET";

//            request.Headers.Set(HttpRequestHeader.Authorization);

//            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

//            using (var respReader = new StreamReader(response.GetResponseStream()))
//                gfyResponse = respReader.ReadToEnd();

//            await Context.Channel.SendMessageAsync("");
//        }
//    }
//}
