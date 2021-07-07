using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Services {
    public class SessionUser {
        private static Dictionary<string, string> _users = new Dictionary<string, string>();

        public void Add(string cookie, string userId) => _users[cookie] = userId;
        public void Remove(string cookie) => _users.Remove(cookie);
        public string Get(string cookie) => _users.TryGetValue(cookie, out var id) ? id : "";
    }
}
