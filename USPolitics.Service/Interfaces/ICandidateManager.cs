using System;
using System.Collections.Generic;
using System.Text;
using USPolitics.Service.DTOs;

namespace USPolitics.Service.Interfaces
{
    public interface ICandidateManager
    {
        void Add(CandidateDTO candidateDto);
        void Delete(int id);
        void Update(CandidateDTO candidateDto);
        CandidateDTO GetById(int id);
        List<CandidateDTO> GetAll();
    }
}
