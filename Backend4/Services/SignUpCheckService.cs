using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Backend4.Services
{
    public class SignUpCheckService : ISignUpCheckService
    {
        private readonly ILogger logger;
        private readonly List<Entry> Accounts = new List<Entry>();
        public SignUpCheckService(ILogger<ISignUpCheckService> logger)
        {
            this.logger = logger;
        }
        public bool Registrate(String firstname, String lastname, Int32 day, Int32 month, Int32 year, String gender)
        {
            lock (this.Accounts)
            {

                if (this.Accounts.Any(x => x.Firstname == firstname && x.Lastname == lastname && x.Day == day && x.Month == month && x.Year == year && x.Gender == gender))
                {
                    this.Accounts.Add(new Entry(firstname, lastname, day, month, year, gender));
                    this.logger.LogInformation($"Registrating remembered account with fisrtname:{firstname}, lastname:{lastname}, birthday:{day} {month} {year}, gender:{gender}");
                    return true;
                }
                else
                {
                    this.Accounts.Add(new Entry(firstname, lastname, day, month, year, gender));
                    this.logger.LogInformation($"Registrating new account with fisrtname:{firstname}, lastname:{lastname}, birthday:{day} {month} {year}, gender:{gender}");
                    return false;
                }
            }
        }
        private sealed class Entry
        {
            public Entry(String firstname, String lastname, Int32 day, Int32 month, Int32 year, String gender)
            {
                this.Firstname = firstname;
                this.Lastname = lastname;
                this.Day = day;
                this.Month = month;
                this.Year = year;
                this.Gender = gender;
            }
            public String Firstname { get; }

            public String Lastname { get; }

            public Int32 Day { get; }

            public Int32 Month { get; }

            public Int32 Year { get; }

            public String Gender { get; }

        }

    }
}
