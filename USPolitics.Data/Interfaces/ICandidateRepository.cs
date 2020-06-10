using System;
using System.Collections.Generic;
using System.Text;
using USPolitics.Data.Models;

namespace USPolitics.Data.Interfaces
{
    public interface ICandidateRepository
    {
        void Add(Candidate candidate);
        void Delete(int id);
        void Update(Candidate candidate);
        Candidate GetById(int id);
        List<Candidate> GetAll();
    }
}
