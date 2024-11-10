using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{
    public class WorkersManage
    {
       public Dictionary<string, string> workers = new Dictionary<string, string>();

public Dictionary<string, string> InputData(){

string v;
WriteLine("enter a value of the workers: ");
v = ReadLine();
int value = int.Parse(v);
        string login;
        string password;



               for (int i = 0; i < value; i++){
                Write("Login{0} --> ", i);
                WriteLine("enter a login of the worker: ");
                login = ReadLine();


                WriteLine("enter a password of the worker: ");
                password = ReadLine();
                workers.Add(login, password);
                Clear();
            }
            return workers;

}

public void DeleteLogin(){
       string login;
       WriteLine("enter a login to delete: ");
                login = ReadLine();
            workers.Remove(login);
            if (!workers.ContainsKey(login))
        {
            WriteLine("login " + login + " is not found.");
        }
}

public void ChangeLogin(){
     string login;
     WriteLine("enter a login to update: ");
     login = ReadLine();
     string newLogin;
     WriteLine("enter a new login to update: ");
     newLogin = ReadLine();
          
          if (workers.ContainsKey(login))
        {
            string value  = workers[login];
            workers.Remove(login);
            workers.Add(newLogin, value);
            WriteLine("login " + login + " successully updated to " + newLogin);
        }
        else{
              WriteLine("login " + login + " is not found.");
        }
}


public void ChangePassword(){
     string password;
     WriteLine("enter a password to update: ");
     password = ReadLine();
     string newPass;
     WriteLine("enter a new login to update: ");
     newPass = ReadLine();
          
          if (workers.ContainsKey(password))
        {
            string value  = workers[password];
            workers.Remove(password);
            workers.Add(newPass, value);
            WriteLine("password " + password + " successully updated to " + newPass);
        }
        else{
              WriteLine("password " + password + " is not found");
        }
}

public void GetPasswordByLogin(string login)
{
    string password;
    if (workers.TryGetValue(login, out password))
    {
         WriteLine("Password for login {0}: {1}", login, password);
    }
    else
    {
          WriteLine("Login {0} not found.", login);
    }
}


    }
}