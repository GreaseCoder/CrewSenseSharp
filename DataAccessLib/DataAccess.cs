using CrewSenseNet.Authentication;
using DataAccessLib.Models.Schedule;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class DataAccess
    {
        private readonly ICrewSenseClient client;

        public DataAccess(ICrewSenseClient client) => this.client = client;

        public async Task<Schedule> GetSchedule(DateTime start, DateTime end)
        {
            var uri = new Uri("https://api.crewsense.com/v1/schedule");

            var data = new Dictionary<string, string>
            {
                { "start", start.ToString("yyyy-MM-dd hh:mm:ss") },
                { "end", end.ToString("yyyy-MM-dd hh:mm:ss") }
            };

            var response = await client.DoGet(uri, data);
            var contents = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Schedule>(contents);
        }

    }
}
