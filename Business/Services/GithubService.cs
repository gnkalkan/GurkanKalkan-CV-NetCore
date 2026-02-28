using AutoMapper;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Data;
using Octokit;
using Utilities.Constants;
using Utilities.Results;

namespace Business.Services
{
    public class GithubService(IMapper mapper) : IGithubService
    {
        public async Task<IDataResult<IEnumerable<GithubRepoListDTO>>> GetRepositoriesAsync()
        {
            //Veritabanına herhangi bir ekleme, güncelleme veya silme işlemi yapılmayacağı için, Data katmanına erişim sağlanmaz. Bu nedenle kodu Repositorye taşımadım. GitHub API'si üzerinden doğrudan veriyi çekip, DTO'ya mapleyip döndürüyorum. 
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("GurkanKalkanPortfolio"));
                var repos = await client.Repository.GetAllForUser("gnkalkan");
                var githubRepoDTO = mapper.Map<IEnumerable<GithubRepoListDTO>>(repos);
                return new SuccessDataResult<IEnumerable<GithubRepoListDTO>>(githubRepoDTO, "Github Repositories" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<GithubRepoListDTO>>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }
    }
}
