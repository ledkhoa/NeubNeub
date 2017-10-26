using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using System.Net.Http;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Runtime.Serialization.Json;

namespace NeubNeub.Modules
{
    public class Giphy : ModuleBase<SocketCommandContext>
    {
        //[Command("gif")]
        //public async Task Gif(params string[] msg)
        //{
        //    string search = string.Join("+", msg);

        //    await GiphyQuery("https://api.giphy.com/v1/gifs/search?api_key=GO2uNoWENkMoCV4pjjW4rYsH9sjaNOVn&q=" + search);
        //}

        [Command("translate")]
        public async Task Translate(params string[] input)
        {
            string tags = string.Join("+", input);

            await GiphyQuery("https://api.giphy.com/v1/gifs/translate?api_key=GO2uNoWENkMoCV4pjjW4rYsH9sjaNOVn&s=" + tags);
        }

        [Command("gif")]
        public async Task Random(params string[] input)
        {
            string tags = string.Join("+", input);

            await GiphyQuery("https://api.giphy.com/v1/gifs/random?api_key=GO2uNoWENkMoCV4pjjW4rYsH9sjaNOVn&tag=" + tags);
        }

        [Command("trending")]
         public async Task Trending()
        {
            await GiphyQuery("https://api.giphy.com/v1/gifs/trending?api_key=GO2uNoWENkMoCV4pjjW4rYsH9sjaNOVn");
        }

        private async Task GiphyQuery(string url)
        {
            var response = await new HttpClient().GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            var jsonReader = JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(content), new System.Xml.XmlDictionaryReaderQuotas());
            var root = XElement.Load(jsonReader);

            if (string.IsNullOrWhiteSpace(root.XPathSelectElement("//data").Value))
                await Context.Channel.SendMessageAsync("waduhek");
            else
                await Context.Channel.SendMessageAsync(root.XPathSelectElement("//url").Value);
        }
    }
}
