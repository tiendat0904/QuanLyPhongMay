using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Common
{
    public class StoredProcedureConfigs<T>
    {
        private const string _insert_single_stored_procedure = "_insert_single_stored_procedure";
        private const string _insert_list_stored_procedure = "_insert_list_stored_procedure";
        private const string _update_single_stored_procedure = "_update_single_stored_procedure";
        private const string _update_list_stored_procedure = "_update_list_stored_procedure";
        private const string _update_status_stored_procedure = "_update_status_stored_procedure";
        private const string _delete_single_stored_procedure = "_delete_single_stored_procedure";
        private const string _delete_list_stored_procedure = "_delete_list_stored_procedure";
        private const string _get_single_stored_procedure = "_get_single_stored_procedure";
        private const string _get_paging_stored_procedure = "_get_paging_stored_procedure";
        private const string _get_all_stored_procedure = "_get_all_stored_procedure";


        public string _INSERT_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _insert_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _INSERT_LIST_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _insert_list_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _UPDATE_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _update_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _UPDATE_STATUS_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _update_status_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _UPDATE_LIST_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _update_list_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _DELETE_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _delete_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _DELETE_LIST_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _delete_list_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _GET_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _get_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _GET_PAGING_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _get_paging_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _GET_ALL_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _get_all_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        #region INSERT
        private string _insert_single_stored_procedure_StudySchedule
        {
            get
            {
                return "[dbo].[STUDY_SCHEDULE_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_Employee
        {
            get
            {
                return "[dbo].[EMPLOYEE_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_Teacher
        {
            get
            {
                return "[dbo].[TEACHER_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_Subject
        {
            get
            {
                return "[dbo].[SUBJECT_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_Shift
        {
            get
            {
                return "[dbo].[SHIFT_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_Class
        {
            get
            {
                return "[dbo].[CLASS_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_Province
        {
            get
            {
                return "[dbo].[PROVINCE_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_Computer
        {
            get
            {
                return "[dbo].[COMPUTER_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_ComputerRoom
        {
            get
            {
                return "[dbo].[COMPUTER_ROOM_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_OpticalDisc
        {
            get
            {
                return "[dbo].[OPTICAL_DISC_INSERT]";
            }
        }

        private string _insert_single_stored_procedure_StorageCapacity
        {
            get
            {
                return "[dbo].[STORAGE_CAPACITY_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_StorageDevice
        {
            get
            {
                return "[dbo].[STORAGE_DEVICE_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_INSERT]";
            }
        }

        private string _insert_single_stored_procedure_Keyboard
        {
            get
            {
                return "[dbo].[KEYBOARD_INSERT]";
            }
        }

        private string _insert_single_stored_procedure_CPU
        {
            get
            {
                return "[dbo].[CPU_INSERT]";
            }
        }

        private string _insert_single_stored_procedure_Monitor
        {
            get
            {
                return "[dbo].[MONITOR_INSERT]";
            }
        }
        private string _insert_single_stored_procedure_MonitorSize
        {
            get
            {
                return "[dbo].[MONITOR_SIZE_INSERT]";
            }
        }

        private string _insert_single_stored_procedure_Speed
        {
            get
            {
                return "[dbo].[SPEED_INSERT]";
            }
        }

        private string _insert_single_stored_procedure_Mouse
        {
            get
            {
                return "[dbo].[MOUSE_INSERT]";
            }
        }
        #endregion

        #region UPDATE
        private string _update_single_stored_procedure_StudySchedule
        {
            get
            {
                return "[dbo].[STUDY_SCHEDULE_EDIT]";
            }
        }
        private string _update_single_stored_procedure_Employee
        {
            get
            {
                return "[dbo].[EMPLOYEE_EDIT]";
            }
        }
        private string _update_single_stored_procedure_Teacher
        {
            get
            {
                return "[dbo].[TEACHER_EDIT]";
            }
        }
        private string _update_single_stored_procedure_Subject
        {
            get
            {
                return "[dbo].[SUBJECT_EDIT]";
            }
        }
        private string _update_single_stored_procedure_Shift
        {
            get
            {
                return "[dbo].[SHIFT_EDIT]";
            }
        }
        private string _update_single_stored_procedure_Class
        {
            get
            {
                return "[dbo].[CLASS_EDIT]";
            }
        }
        private string _update_single_stored_procedure_Province
        {
            get
            {
                return "[dbo].[PROVINCE_EDIT]";
            }
        }
        private string _update_single_stored_procedure_Computer
        {
            get
            {
                return "[dbo].[COMPUTER_EDIT]";
            }
        }
        private string _update_single_stored_procedure_OpticalDisc
        {
            get
            {
                return "[dbo].[OPTICAL_DISC_EDIT]";
            }
        }
        private string _update_single_stored_procedure_StorageCapacity
        {
            get
            {
                return "[dbo].[STORAGE_CAPACITY_EDIT]";
            }
        }
        private string _update_single_stored_procedure_StorageDevice
        {
            get
            {
                return "[dbo].[STORAGE_DEVICE_EDIT]";
            }
        }
        private string _update_single_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_EDIT]";
            }
        }

        private string _update_single_stored_procedure_Keyboard
        {
            get
            {
                return "[dbo].[KEYBOARD_EDIT]";
            }
        }

        private string _update_single_stored_procedure_Mouse
        {
            get
            {
                return "[dbo].[MOUSE_EDIT]";
            }
        }

        private string _update_single_stored_procedure_CPU
        {
            get
            {
                return "[dbo].[CPU_EDIT]";
            }
        }

        private string _update_single_stored_procedure_Monitor
        {
            get
            {
                return "[dbo].[MONITOR_EDIT]";
            }
        }

        private string _update_single_stored_procedure_MonitorSize
        {
            get
            {
                return "[dbo].[MoNITOR_SIZE_EDIT]";
            }
        }

        private string _update_single_stored_procedure_Speed
        {
            get
            {
                return "[dbo].[SPEED_EDIT]";
            }
        }
        #endregion

        #region DELETE
        private string _delete_single_stored_procedure_StudySchedule
        {
            get
            {
                return "[dbo].[STUDY_SCHEDULE_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_Employee
        {
            get
            {
                return "[dbo].[EMPLOYEE_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_Teacher
        {
            get
            {
                return "[dbo].[TEACHER_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_Subject
        {
            get
            {
                return "[dbo].[SUBJECT_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_Class
        {
            get
            {
                return "[dbo].[CLASS_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_Province
        {
            get
            {
                return "[dbo].[PROVINCE_ROOM_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_ComputerRoom
        {
            get
            {
                return "[dbo].[COMPUTER_ROOM_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_OpticalDisc
        {
            get
            {
                return "[dbo].[OPTICAL_DISC_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_StorageCapacity
        {
            get
            {
                return "[dbo].[STORAGE_CAPACITY_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_StorageDevice
        {
            get
            {
                return "[dbo].[STORAGE_DEVICE_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_DELETE]";
            }
        }

        private string _delete_single_stored_procedure_Keyboard
        {
            get
            {
                return "[dbo].[KEYBOARD_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_Mouse
        {
            get
            {
                return "[dbo].[MOUSE_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_CPU
        {
            get
            {
                return "[dbo].[CPU_DELETE]";
            }
        }
        private string _delete_single_stored_procedure_Monitor
        {
            get
            {
                return "[dbo].[MONITOR_DELETE]";
            }
        }

        private string _delete_single_stored_procedure_MonitorSize
        {
            get
            {
                return "[dbo].[MONITOR_SIZE_DELETE]";
            }
        }

        private string _delete_single_stored_procedure_Speed
        {
            get
            {
                return "[dbo].[SPEED_DELETE]";
            }
        }
        #endregion

        #region GETPAGING
        private string _get_paging_stored_procedure_StudySchedule
        {
            get
            {
                return "[dbo].[STUDY_SCHEDULE_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_Employee
        {
            get
            {
                return "[dbo].[EMPLOYEE_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_Teacher
        {
            get
            {
                return "[dbo].[TEACHER_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_Subject
        {
            get
            {
                return "[dbo].[SUBJECT_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_Shift
        {
            get
            {
                return "[dbo].[SHIFT_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_Class
        {
            get
            {
                return "[dbo].[CLASS_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_Province
        {
            get
            {
                return "[dbo].[PROVINCE_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_ComputerRoom
        {
            get
            {
                return "[dbo].[COMPUTER_ROOM_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_OpticalDisc
        {
            get
            {
                return "[dbo].[OPTICAL_DISC_GET_PAGING]";
            }
        }

        private string _get_paging_stored_procedure_StorageCapacity
        {
            get
            {
                return "[dbo].[STORAGE_CAPACITY_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_StorageDevice
        {
            get
            {
                return "[dbo].[STORAGE_DEVICE_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_GET_PAGING]";
            }
        }

        private string _get_paging_stored_procedure_Keyboard
        {
            get
            {
                return "[dbo].[KEYBOARD_GET_PAGING]";
            }
        }

        private string _get_paging_stored_procedure_Mouse
        {
            get
            {
                return "[dbo].[MOUSE_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_CPU
        {
            get
            {
                return "[dbo].[CPU_GET_PAGING]";
            }
        }
        private string _get_paging_stored_procedure_Monitor
        {
            get
            {
                return "[dbo].[MONITOR_GET_PAGING]";
            }
        }

        private string _get_paging_stored_procedure_MonitorSize
        {
            get
            {
                return "[dbo].[MONITOR_SIZE_GET_PAGING]";
            }
        }

        private string _get_paging_stored_procedure_Speed
        {
            get
            {
                return "[dbo].[SPEED_GET_PAGING]";
            }
        }
        #endregion

        #region GETSINGLE
        private string _get_single_stored_procedure_StudySchedule
        {
            get
            {
                return "[dbo].[STUDY_SCHEDULE_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Employee
        {
            get
            {
                return "[dbo].[EMPLOYEE_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Teacher
        {
            get
            {
                return "[dbo].[TEACHER_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Subject
        {
            get
            {
                return "[dbo].[SUBJECT_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Shift
        {
            get
            {
                return "[dbo].[SHIFT_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Class
        {
            get
            {
                return "[dbo].[CLASS_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Province
        {
            get
            {
                return "[dbo].[PROVINCE_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Computer
        {
            get
            {
                return "[dbo].[COMPUTER_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_OpticalDisc
        {
            get
            {
                return "[dbo].[OPTICAL_DISC_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_StorageCapacity
        {
            get
            {
                return "[dbo].[STORAGE_CAPACITY_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_StorageDevice
        {
            get
            {
                return "[dbo].[STORAGE_DEVICE_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_CPU
        {
            get
            {
                return "[dbo].[CPU_GET_BY_ID]";
            }
        }

        private string _get_single_stored_procedure_Keyboard
        {
            get
            {
                return "[dbo].[KEYBOARD_GET_BY_ID]";
            }
        }

        private string _get_single_stored_procedure_Mouse
        {
            get
            {
                return "[dbo].[MOUSE_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_GET_BY_ID]";
            }
        }

        private string _get_single_stored_procedure_MonitorSize
        {
            get
            {
                return "[dbo].[MONITOR_SIZE_GET_BY_ID]";
            }
        }
        private string _get_single_stored_procedure_Monitor
        {
            get
            {
                return "[dbo].[MONITOR_GET_BY_ID]";
            }
        }

        private string _get_single_stored_procedure_Speed
        {
            get
            {
                return "[dbo].[SPEED_GET_BY_ID]";
            }
        }
        #endregion

        #region GETALL
        private string _get_all_stored_procedure_Class
        {
            get
            {
                return "[dbo].[CLASS_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Teacher
        {
            get
            {
                return "[dbo].[TEACHER_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Study_Schdule
        {
            get
            {
                return "[dbo].[STUDY_SCHEDULE_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_ComputerRoom
        {
            get
            {
                return "[dbo].[COMPUTER_ROOM_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Employee
        {
            get
            {
                return "[dbo].[EMPLOYEE_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Subject
        {
            get
            {
                return "[dbo].[SUBJECT_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Shift
        {
            get
            {
                return "[dbo].[SHIFT_GET_ALL]";
            }
        }
        
        private string _get_all_stored_procedure_Province
        {
            get
            {
                return "[dbo].[PROVINCE_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_CPU
        {
            get
            {
                return "[dbo].[CPU_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Keyboard
        {
            get
            {
                return "[dbo].[KEYBOARD_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Mouse
        {
            get
            {
                return "[dbo].[MOUSE_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Monitor
        {
            get
            {
                return "[dbo].[MONITOR_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_MonitorSize
        {
            get
            {
                return "[dbo].[MONITOR_SIZE_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_Speed
        {
            get
            {
                return "[dbo].[SPEED_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_OpticalDisc
        {
            get
            {
                return "[dbo].[OPTICAL_DISC_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_StorageCapacity
        {
            get
            {
                return "[dbo].[STORAGE_CAPACITY_GET_ALL]";
            }
        }
        private string _get_all_stored_procedure_StorageDevice
        {
            get
            {
                return "[dbo].[STORAGE_DEVICE_GET_ALL]";
            }
        }

        #endregion

        #region UPDATESTATUS
        private string _update_status_stored_procedure_StudySchedule
        {
            get
            {
                return "[dbo].[STUDY_SCHEDULE_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_Employee
        {
            get
            {
                return "[dbo].[EMPLOYEE_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_Teacher
        { 
            get
            {
                return "[dbo].[TEACHER_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_Subject
        {
            get
            {
                return "[dbo].[SUBJECT_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_Shift
        {
            get
            {
                return "[dbo].[SHIFT_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_Class
        {
            get
            {
                return "[dbo].[CLASS_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_Province
        {
            get
            {
                return "[dbo].[PROVINCE_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_ComputerRoom
        {
            get
            {
                return "[dbo].[COMPUTER_ROOM_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_OpticalDisc
        {
            get
            {
                return "[dbo].[OPTICAL_DISC_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_StorageCapacity
        {
            get
            {
                return "[dbo].[STORAGE_CAPACITY_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_StorageDevice
        {
            get
            {
                return "[dbo].[STORAGE_DEVICE_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_Keyboard
        {
            get
            {
                return "[dbo].[KEYBOARD_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_CPU
        {
            get
            {
                return "[dbo].[CPU_UPDATE_STATUS]";
            }
        }
        private string _update_status_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_UPDATE_STATUS]";
            }
        }

        private string _update_status_stored_procedure_Mouse
        {
            get
            {
                return "[dbo].[MOUSE_UPDATE_STATUS]";
            }
        }

        private string _update_status_stored_procedure_Monitor
        {
            get
            {
                return "[dbo].[MONITOR_UPDATE_STATUS]";
            }
        }

        private string _update_status_stored_procedure_MonitorSize
        {
            get
            {
                return "[dbo].[MONITOR_SIZE_UPDATE_STATUS]";
            }
        }

        private string _update_status_stored_procedure_Speed
        {
            get
            {
                return "[dbo].[SPEED_UPDATE_STATUS]";
            }
        }
        #endregion

    }
}
