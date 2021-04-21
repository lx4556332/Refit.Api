using Refit.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Refit.Server.interfaceApi
{
    public interface IPersonsApi
    {
        [Get("/api/persons")]
        [Headers("User-Agent: Dms-Parts", "Content-Type: application/json")]
        Task<List<Person>> GetPersonsAsync();

        [Get("/api/persons/{id}")]
        [Headers("User-Agent: Dms-Parts", "Content-Type: application/json")]
        Task<Person> GetPersonAsync([AliasAs("id")] int personId);

        [Post("/api/persons")]
        [Headers("User-Agent: Dms-Parts", "Content-Type: application/json")]
        Task<Person> AddPersonAsync([Body] Person person);

        [Put("/api/persons")]
        [Headers("User-Agent: Dms-Parts", "Content-Type: application/json")]
        Task<string> EditPersonAsync([Body] int id);

        [Delete("/api/persons/{id}")]
        [Headers("User-Agent: Dms-Parts", "Content-Type: application/json")]
        Task<string> DeletePersonAsync(int id);
    }
}
