using System;
using System.Collections.Generic;
using System.Text;
using USPolitics.Data.Interfaces;
using USPolitics.Data.Models;
using USPolitics.Service.DTOs;
using USPolitics.Service.Interfaces;

namespace USPolitics.Service.Concretes
{
    public class CandidateManager : ICandidateManager
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateManager(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public void Add(CandidateDTO candidateDto)
        {
            var candidate = new Candidate();
            candidate.Name = candidateDto.Name;
            candidate.Image = candidateDto.Image;
            _candidateRepository.Add(candidate);
        }

        public void Delete(int id)
        {
            _candidateRepository.Delete(id);
        }

        public void Update(CandidateDTO candidateDto)
        {
            var candidate = new Candidate();
            candidate.Name = candidateDto.Name;
            candidate.Image = candidateDto.Image;
            _candidateRepository.Update(candidate);
        }

        public List<CandidateDTO> GetAll()
        {
            var candidatesDto = new List<CandidateDTO>();
            var candidates = _candidateRepository.GetAll();

            foreach(var candidate in candidates)
            {
                var candidateDto = new CandidateDTO();
                candidateDto.Id = candidate.Id;
                candidateDto.Name = candidate.Name;
                candidateDto.Image = candidate.Image;
                candidatesDto.Add(candidateDto);
            }

            return candidatesDto;
        }

        public CandidateDTO GetById(int id)
        {
            var candidate = _candidateRepository.GetById(id);
            var candidateDto = new CandidateDTO();
            candidateDto.Id = candidate.Id;
            candidateDto.Name = candidate.Name;
            candidateDto.Image = candidate.Image;

            return candidateDto;
        }
    }
}
