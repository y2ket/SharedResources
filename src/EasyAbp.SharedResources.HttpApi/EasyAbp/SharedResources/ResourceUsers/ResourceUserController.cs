using System;
using System.Threading.Tasks;
using EasyAbp.SharedResources.ResourceUsers.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.SharedResources.ResourceUsers
{
    [RemoteService(Name = "EasyAbpSharedResources")]
    [Route("/api/sharedResources/resourceUser")]
    public class ResourceUserController : SharedResourcesController, IResourceUserAppService
    {
        private readonly IResourceUserAppService _service;

        public ResourceUserController(IResourceUserAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<ResourceUserDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<ResourceUserDto>> GetListAsync(GetResourceUserListDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<ResourceUserDto> CreateAsync(CreateUpdateResourceUserDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<ResourceUserDto> UpdateAsync(Guid id, CreateUpdateResourceUserDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
    }
}