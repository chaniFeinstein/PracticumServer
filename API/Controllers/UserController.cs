using Common.DTO_s;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDTO> _user;

        public UserController(IService<UserDTO> user)
        {
            _user = user;
        }

        // GET: api/<Get>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _user.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _user.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel postModel)
        {
            UserDTO newOne = new UserDTO();
            newOne.FirstName = postModel.FirstName;
            newOne.LastName = postModel.LastName;
            newOne.TZ = postModel.TZ;
            newOne.BornDate = postModel.BornDate;
            newOne.Gender = postModel.Gender;
            newOne.FamilyId = postModel.FamilyId;
            newOne.Status = postModel.Status;
            newOne.HMO=postModel.HMO;
            newOne.GetTz = postModel.GetTz;
            return await _user.Add(newOne);
        }

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
