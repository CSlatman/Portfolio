using JSONdotNETtestApp;
using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Json.Net;


namespace JSONdotNETtestapp
{
    internal class Program
    {
        private void JSONSerilaize()
        {
            // Serializaion
            Employee empObj = new Employee();
            empObj.ID = 1;
            empObj.Name = "Manas";
            empObj.Address = "India";

            // Convert Employee object to JOSN string format
            string jsonData = JsonConvert.SerializeObject(empObj);

            Response.Write(jsonData);
        }

    }
}