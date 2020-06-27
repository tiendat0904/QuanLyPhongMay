using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Keyboard;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KeyboardController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Keyboard> condition)
        {
            KeyboardBusiness keyboardBusiness = new KeyboardBusiness();
            var result = keyboardBusiness.GetAllKeyboardSearched(condition);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            KeyboardBusiness keyboardBusiness = new KeyboardBusiness();
            var result = keyboardBusiness.GetAll();
            return Ok(result);
        }
        public IActionResult Add(AddKeyboardViewModel keyboard)
        {
            KeyboardBusiness keyboardBusiness = new KeyboardBusiness();
            var result = keyboardBusiness.AddKeyboard(keyboard);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            KeyboardBusiness keyboardBusiness = new KeyboardBusiness();
            var result = keyboardBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(KeyboardDeleteViewModel keyboard)
        {
            KeyboardBusiness keyboardBusiness = new KeyboardBusiness();
            var result = keyboardBusiness.Delete(keyboard);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(KeyboardEditViewModel keyboard)
        {
            KeyboardBusiness keyboardBusiness = new KeyboardBusiness();
            var result = keyboardBusiness.Edit(keyboard);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(KeyboardEditStatusViewModel keyboard)
        {
            KeyboardBusiness keyboardBusiness = new KeyboardBusiness();
            var result = keyboardBusiness.EditStatus(keyboard);
            return Ok(result);
        }
    }
}