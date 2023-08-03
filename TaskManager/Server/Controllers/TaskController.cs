using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Server.Data;
using TaskManager.Shared.Models;

namespace TaskManager.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public TaskController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddUpdate(Activity activity){
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Please pass valid data";
                return Ok(status);
            }
            try
            {
                if(activity.Id == 0)
                {
                    _context.Activities.Add(activity);
                }
                else
                {
                    _context.Activities.Update(activity);
                }
                _context.SaveChanges();
                status.StatusCode = 1;
                status.Message = "Saved Successfully";
            }
            catch (Exception e)
            {
                status.StatusCode = 0;
                status.Message = "Save failed";
            }
            return Ok(status);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Status status = new Status();
        }
    }
}
