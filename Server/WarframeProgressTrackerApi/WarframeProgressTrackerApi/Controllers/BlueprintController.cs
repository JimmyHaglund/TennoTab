using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    public class ResourceStack {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }

    [Route("[controller]/[action]")]
    [ApiController]
    [EnableCors]
    public class BlueprintController : ControllerBase {
        private WarframeProgressTrackerContext _context;
        public BlueprintController(WarframeProgressTrackerContext context) {
            _context = context;
        }

        [HttpPut]
        public IEnumerable<BlueprintResource> Components([FromBody]BlueprintResource result) {
            return _context.BlueprintResources
                .Where(blueprint => blueprint.ResultName == result.ResultName);
        }

        [HttpPut]
        public IEnumerable<ResourceStack> TotalResourceCost([FromBody] BlueprintResource result) {
            return GetResourceCost(result.ResultName);
        }

        private IEnumerable<ResourceStack> GetResourceCost(string resultName, int resultCount = 1) {
            var components = GetComponents(resultName);
            if (components.Count == 0) {
                return _context.Resources
                    .Where(resource => resource.Name == resultName)
                    .Select(resource => new ResourceStack() { 
                        Id = resource.Id,
                        Name = resource.Name, 
                        Amount = resultCount });
            }
            var result = new List<ResourceStack>();
            foreach(var component in components) {
                var componentCost = GetResourceCost(component.ComponentName, component.ComponentCount);
                result.AddRange(componentCost);
                /*
                foreach (var stack in componentCost) {
                    
                }/**/
            }
            return result;
        }

        private ICollection<BlueprintResource> GetComponents(string resultName) {
            return _context.BlueprintResources
                .Where(blueprint => blueprint.ResultName == resultName)
                .ToList();
        }
    }
}
