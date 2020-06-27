using Common.Common;
using Common.Entity.Models.Keyboard;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class KeyboardBusiness
    {
        private KeyboardDAL _keyboardDAL;
        public KeyboardDAL KeyboardDAL
        {
            get
            {
                _keyboardDAL = new KeyboardDAL();
                return _keyboardDAL;
            }
        }
        public ReturnResult<Keyboard> GetAllKeyboardSearched(BaseCondition<Keyboard> condition)
        {
            KeyboardDAL keyboardDAL = new KeyboardDAL();
            var result = keyboardDAL.GetAllKeyboardSearched(condition);
            return result;
        }

        public ReturnResult<Keyboard> GetAll()
        {
            return KeyboardDAL.GetAll();
        }

        public ReturnResult<Keyboard> AddKeyboard(AddKeyboardViewModel keyboard)
        {
            return KeyboardDAL.Add(keyboard);
        }

        public ReturnResult<Keyboard> GetById(int Id)
        {
            return KeyboardDAL.GetById(Id);
        }

        public ReturnResult<Keyboard> Delete(KeyboardDeleteViewModel keyboard)
        {
            return KeyboardDAL.Delete(keyboard);
        }

        public ReturnResult<Keyboard> Edit(KeyboardEditViewModel keyboard)
        {
            return KeyboardDAL.Edit(keyboard);
        }

        public ReturnResult<Keyboard> EditStatus(KeyboardEditStatusViewModel keyboard)
        {
            return KeyboardDAL.EditStatus(keyboard);
        }
    }
}
