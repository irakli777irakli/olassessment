using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace olassessment
{
    public class Question1
    {


        
        private Dictionary<string,string> Credentials = 
                new Dictionary<string, string>(){{"ika","123"}};


        public Question1(){}

        
        public void EnterCredentials(){
            int chnances = 5;
            for(int i=0;i<chnances;i++){
                string name = FillField("name");
                string password = FillField("password");

                bool valid = CheckCredentials(name,password);
            
                if(valid) {
                    Console.WriteLine("Success");
                    break;
                }
                if(!valid && i == chnances-1){
                    Console.WriteLine("failed");
                }
                if(!valid){
                    continue;
                }

            }


        }

        private string FillField(string field){
            Console.WriteLine("Enter your {0}?",field);
            string? input = Console.ReadLine();

            if(!string.IsNullOrEmpty(input)) return input;

            return "";
        }

        private bool CheckCredentials(string name,string password){
            var value = Credentials.GetValueOrDefault(name);
            if(value != null){
                if(value.Equals(password)) return true;
            }
            return false;
        
        }

    }
}