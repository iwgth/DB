using Newtonsoft.Json;
using System;
using System.IO;

namespace winf
{
    class DBank
    {
        public static void SerializeUsers(LinkedList<User> UserList)
        {
            string path = "UserBank.json";
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (User user in UserList)
                {
                    string User = JsonConvert.SerializeObject(user);
                    sw.WriteLine(User);
                }
            }
        }

        public static LinkedList<User>  DeserializeUsers()
        {
            string path = "UserBank.json";
            if (File.Exists(path))
            {
                LinkedList<User> UsersList = new LinkedList<User>();

                var lines = File.ReadLines("UserBank.json");
                foreach (var line in lines)
                {
                    UsersList.Push(JsonConvert.DeserializeObject<User>(line));
                }

                return UsersList;
            }
            else
            {
                throw new InvalidOperationException("There is no such file");
            }
        }
    }
}
