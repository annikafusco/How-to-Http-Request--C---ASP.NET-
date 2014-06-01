using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// for http requests
using System.Net.Http;
using System.Threading.Tasks;


namespace SimpleHttpRequest
{
    public partial class _Default : Page
    {
        // set up consts (change these on your local machine!)
        public const string request_url = "http://requestb.in/1e6g51z1";
        public const string output_file = "C:\\Users\\t-empak\\Desktop\\output_project.txt"; // "..\\output_project.txt"; 
        
        // instance variables
        protected System.Web.UI.WebControls.TextBox emailInput;
        protected System.Web.UI.WebControls.TextBox nameInput;

        protected void myButton_Click(object sender, EventArgs e)
        {
            String name = nameInput.Text.ToString();
            String email = emailInput.Text.ToString(); 

            httpRequest(name, email);
        }

        protected void httpRequest(string name, string email)
        {
            // send request
            var task = MakeRequest(name, email);
            task.Wait(); // wait for request to return

            var response = task.Result;
            var body = response.Content.ReadAsStringAsync().Result;

            // write response from request to file
            System.IO.File.WriteAllText(@output_file, body);
        }

        private static async Task<HttpResponseMessage> MakeRequest(string name, string email)
        {
            // set up Key value pairs with data 
            // as per Evan Mulawski's method 3 at http://stackoverflow.com/questions/4015324/ 
            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("name", name));
            data.Add(new KeyValuePair<string, string>("email", email));
            var content = new FormUrlEncodedContent(data);

            var httpClient = new HttpClient();
            return await httpClient.PostAsync((new Uri(request_url)), content);
        }
    }
}