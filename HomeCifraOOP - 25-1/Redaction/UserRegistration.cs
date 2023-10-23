using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace Redaction
{
    internal static class UserRegistration
    {
        static private List<User> _users;
        static public void RegisterUser(User newUser)
        {
            string jsonData;
            
            using (StreamReader streamReader = new StreamReader(Form1.fileData))
            {
                jsonData = streamReader.ReadToEnd();
            };
            //string jsonData = File.ReadAllText(Form1.fileData);
            if (jsonData == string.Empty)
            {
                _users = new List<User>();
            }
            else
            {
                _users = JsonSerializer.Deserialize<List<User>>(jsonData);
            }

            foreach (var user in _users)
            {
                if (user.Username == newUser.Username)
                {
                    MessageBox.Show("Такой пользоватль уже существует");
                    return;
                }
                else if (user.Email == newUser.Email)
                {
                    MessageBox.Show("Такой Email уже существует");
                    return;
                }
            }
            newUser.Id = _users.Count + 1;
            newUser.RegistrationDate = DateTime.Now;
            _users.Add(newUser);
            SerilizeUsersToJson(_users, Form1.fileData);

        }
        static public void SerilizeUsersToJson(List<User> users, string fileName)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsonData = JsonSerializer.Serialize(_users, typeof(List<User>), options);
            StreamWriter fileWrite = File.CreateText(Form1.fileData);
            fileWrite.WriteLine(jsonData);
            fileWrite.Close();
        }
    }
}
