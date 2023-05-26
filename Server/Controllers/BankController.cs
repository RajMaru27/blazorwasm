using BlazorWASMPractice.Server.Context;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWASMPractice.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public BankController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public IActionResult AddUpdate(Bank bank)
        {
            var Status = new Status();
            if (!ModelState.IsValid)
            {
                Status.StatusCode = false;
                Status.Message = "Please input valid data";
            }
            try
            {
                if (bank.Id == 0)
                {
                    _dataContext.banks.Add(bank);
                }
                else
                {
                    _dataContext.banks.Update(bank);
                }
                _dataContext.SaveChanges();
                Status.StatusCode = true;
                Status.Message = "Data saved successfully";
            }
            catch (Exception ex)
            {
                Status.StatusCode = false;
                Status.Message = ex.Message;
            }
            return Ok(Status);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Status = new Status();
            try
            {
                var data = _dataContext.banks.Find(id);
                if (data is not null)
                {
                    _dataContext.banks.Remove(data);
                }
                else
                {
                    Status.StatusCode = false;
                    Status.Message = "Data not found";
                    return RedirectToAction("GetAll");
                }
                _dataContext.SaveChanges();
                Status.StatusCode = true;
                Status.Message = "Data deleted successfully";
            }
            catch (Exception ex)
            {
                Status.StatusCode = false;
                Status.Message = ex.Message;
            }
            return Ok(Status);
        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            Bank bank = new Bank();
            if (id > 0)
            {
                var Status = new Status();
                try
                {
                    var data = _dataContext.banks.Find(id);
                    if (data is not null)
                    {
                        return Ok(data);
                    }
                    else
                    {
                        Status.StatusCode = false;
                        Status.Message = "Could not find data";
                    }
                }
                catch (Exception ex)
                {
                    Status.StatusCode = false;
                    Status.Message = ex.Message;
                }
                return Ok(Status);
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetAll(string sTerm = "")
        {
            sTerm = sTerm.ToLower();
            var Status = new Status();
            try
            {
                var list = (from B in _dataContext.banks
                            where sTerm == null || B.Name.ToLower().StartsWith(sTerm)
                            select new Bank
                            {
                                Id = B.Id,
                                Name = B.Name,
                                AccountNumber = B.AccountNumber,
                                AccountType = B.AccountType,
                                Branch = B.Branch,
                                IfscCode = B.IfscCode
                            }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                Status.StatusCode = false;
                Status.Message = ex.Message;
            }
            return BadRequest();
        }
    }
}
