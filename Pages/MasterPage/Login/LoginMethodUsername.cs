﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpecflowTask.Pages.MasterPage.Login
{
    public class LoginMethodUsername
    {
        public string userUsername(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\MarsSpecflow\SpecflowTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);

            return user.Username;
        }
        
    }
}
