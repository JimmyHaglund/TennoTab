using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    
    [ApiController]
    [EnableCors]
    public class BlueprintController : ControllerBase {
        #region Endpoints
        [HttpGet, Route("[controller]/[action]/{resultName}")]
        public Blueprint Get(string resultName) {
            var blueprint = new Blueprint() { ResultName = resultName };
            blueprint.Components = Components(resultName);
            return blueprint;
        }

        [HttpGet, Route("[controller]/[action]/{resultName}")]
        public IEnumerable<ComponentStack> TotalResourceCost(string resultName) {
            return GetTotalForgingResourceCost(resultName);
        }
#endregion

#region Body
        private WarframeProgressTrackerContext _context;
        public BlueprintController(WarframeProgressTrackerContext context) {
            _context = context;
        }
        /// <summary>
        /// Recursive function for getting total resource cost for an item.
        /// Will go down through any forgeable components until only non-forgeable items remain, and return those.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="itemAmount"></param>
        /// <returns></returns>
        private List<ComponentStack> GetTotalForgingResourceCost(string itemName, int itemAmount = 1) {
            if (!IsForgeable(itemName)) {
                return new List<ComponentStack>() {
                    new ComponentStack() {
                        ComponentName = itemName,
                        ComponentCount = itemAmount
                    }
                };
            }

            var result = new List<ComponentStack>();
            var componentStacks = Components(itemName);
            foreach (var componentStack in componentStacks) {
                var name = componentStack.ComponentName;
                var amount = componentStack.ComponentCount;
                var resources = GetTotalForgingResourceCost(name, amount);
                AddComponentStacksToList(result, resources);
            }
            return result;
        }

        private void AddComponentStacksToList(List<ComponentStack> stackList, IEnumerable<ComponentStack> components) {
            foreach(var componentStack in components) {
                var componentsInList = stackList
                    .Where(stack => stack.ComponentName == componentStack.ComponentName)
                    .FirstOrDefault();
                if (componentsInList == default) {
                    stackList.Add(componentStack);
                    continue;
                }
                componentsInList.ComponentCount += componentStack.ComponentCount;
            }
        }

        private bool IsForgeable(string itemName) => Components(itemName).Count() > 0;
        
        private IEnumerable<ComponentStack> Components(string resultName) {
            return from blueprintResource in _context.BlueprintResources
                   where blueprintResource.ItemName == resultName
                   select new ComponentStack() {
                       ComponentName = blueprintResource.ComponentName,
                       ComponentCount = blueprintResource.ComponentAmount
                   };
        }

        #endregion
    }
}
