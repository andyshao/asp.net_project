using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itcast.Mall.Model
{
    public class Captcha
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public bool Actived { get; set; }
        public DateTime Expired { get; set; }
    }
}
