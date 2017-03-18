using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace MySabino.Model
{
    public class LoginParameters
    {
        public string Password { get; set; }
        public bool Persisted { get; set; }
        public string Username { get; set; }
    }


}