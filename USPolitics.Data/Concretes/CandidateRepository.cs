using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using USPolitics.Data.Interfaces;
using USPolitics.Data.Models;

namespace USPolitics.Data.Concretes
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly USPoliticsContext _context;

        public CandidateRepository(USPoliticsContext context)
        {
            _context = context;
        }

        public void Add(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var candidate = _context.Candidates.Find(id);

            if(candidate != null)
            {
                _context.Candidates.Remove(candidate);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Candidate not found");
            }
        }

        public void Update(Candidate candidateInput)
        {
            var candidate = _context.Candidates.Find(candidateInput.Id);

            if (candidate != null)
            {
                candidate.Image = candidateInput.Image;
                candidate.Name = candidateInput.Name;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Candidate not found");
            }
        }

        public Candidate GetById(int id)
        {
            var candidate = _context.Candidates.Find(id);

            if (candidate != null)
            {
                return candidate;
            }
            else
            {
                throw new Exception("Candidate not found");
            }
        }

        public List<Candidate> GetAll()
        {
            return _context.Candidates.ToList();
        }
    }
}
