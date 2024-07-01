namespace Infrastructure.Common.Db
{
    public static class DbStoreProcs
    {
        internal static string UserByName = "uspUserByName";
        internal static string GetAllCountries = "getallcountries";

        internal static string GetAllNationalities = "getAllNationalities";
        internal static string GetDropdownOptions = "getdropdownoptions";

        internal static string GetAllCurrencies = "getAllCurrencies";
        internal static string GetAllCustomersByTenantId = "getAllCustomersByTenantId";

        internal static string GetAllCompaniesByTenantId = "getallcompaniesbytenantid";
        internal static string GetAllLocationsByTenantId = "getalllocationsbytenantid";
        internal static string GetAllCompaniesByCustomerId = "getAllCompaniesByCustomerId";
       
        internal static string DeleteCustomerById = "DeleteCustomerById";

        internal static string SaveCustomer = "SaveCustomer";
      
        internal static string GetCustomerById = "GetCustomerById";

        internal static string SaveCompany = "SaveCompany";
        internal static string DeleteCompanyById = "DeleteCompanyById";
        internal static string GetCompanyById = "GetCompanyById";

        
        /*Location*/

        internal static string GetLocationById = "GetLocationById";
        internal static string LocationByComapnyId = "GetAllLocationsByCompanyId";
        internal static string LocationByCustomerId = "GetAllLocationsByCustomerId";
        internal static string SaveLocation = "SaveLocation";
        internal static string UpdateGeoLocation = "UpdateGeoLocation";
        internal static string DeleteLocationById = "DeleteLocationById";

        /*Employee*/
        internal static string SaveEmployeePersonalDetails = "SaveEmployeePersonalDetails";
        internal static string SaveEmployeeEmergencyContactDetails = "SaveEmployeeEmergencyContactDetails";
        internal static string SaveEmployeeContactDetails = "SaveEmployeeContactDetails";
        internal static string GetEmployeeContactDetailsByEmployeeId = "GetEmployeeContactDetailsByEmployeeId";
        internal static string GetEmployeeEmergencyContactsByUserId = "GetEmployeeEmergencyContactsByUserId";
        internal static string GetEmployeePersonalDetailsByUserId = "GetEmployeePersonalDetailsByUserId";
        internal static string GetEmployeePersonalDetailsByUserIdAndTenantId = "GetEmployeePersonalDetailsByUserIdAndTenantId";
        internal static string DeleteEmployeeSubordinateById = "DeleteEmployeeSubordinateById";
        internal static string SaveEmployeeSubordinate = "SaveEmployeeSubordinate";
        internal static string GetEmployeeSubordinateById = "GetEmployeeSubordinateById";
        internal static string SaveEmployeeSupervisor = "SaveEmployeeSupervisor";
        internal static string GetEmployeeSupervisorById = "GetEmployeeSupervisorById";
        internal static string DeleteEmployeeSupervisorById = "DeleteEmployeeSupervisorById";
        internal static string GetEmployeeSubordinatesByUserId = "GetEmployeeSubordinatesByUserId";
        internal static string GetEmployeeSupervisorsByUserId = "GetEmployeeSupervisorsByUserId";
        internal static string SaveEmployeeWorkExperience = "SaveEmployeeWorkExperience";
        internal static string DeleteEmployeeWorkExperienceById = "DeleteEmployeeWorkExperienceById";
        internal static string GetEmployeeWorkExperienceById = "GetEmployeeWorkExperienceById";
        internal static string GetEmployeeWorkExperiencesByUserId = "GetEmployeeWorkExperiencesByUserId";
        internal static string SaveEmployeeTermination = "SaveEmployeeTermination";
        internal static string GetEmployeeEmergencyContactById = "GetEmployeeEmergencyContactById";
        internal static string GetEmployeeJobDetailsByUserId = "GetEmployeeJobDetailsByUserId";
        internal static string GetEmployeeDependentById = "GetEmployeeDependentById";
        internal static string GetEmployeeDependentsByUserId = "GetEmployeeDependentsByUserId";
        internal static string GetEmployeeImmigrationDetailsByUserId = "GetEmployeeImmigrationDetailsByUserId";
        internal static string GetEmployeeImmigrationDetailById = "GetEmployeeImmigrationDetailById";
        internal static string GetEmployeeFileAttachmentsByEmployeeId = "GetEmployeeFileAttachmentsByEmployeeId";
        internal static string GetEmployeeSalaryComponentsByUserId = "GetEmployeeSalaryComponentsByUserId";
        internal static string SaveEmployeeDependent = "SaveEmployeeDependent";
        internal static string SaveEmployeeEducation = "SaveEmployeeEducation";
        internal static string SaveEmployeeFileAttachment = "SaveEmployeeFileAttachment";
        internal static string SaveEmployeeImmigrationDetails = "SaveEmployeeImmigrationDetails";
        internal static string SaveEmployeeJobDetails = "SaveEmployeeJobDetails";
        internal static string SaveEmployeeSkill = "SaveEmployeeSkill";
        internal static string SaveEmployeeSalaryComponent = "SaveEmployeeSalaryComponent";
        internal static string DeleteEmployeeDependentById = "DeleteEmployeeDependentById";
        internal static string DeleteEmployeeEducationById = "DeleteEmployeeEducationById";
        internal static string DeleteEmployeeEmergencyContactById = "DeleteEmployeeEmergencyContactById";
        internal static string DeleteEmployeeSalaryComponentById = "DeleteEmployeeSalaryComponentById";
        internal static string DeleteEmployeeSkillById = "DeleteEmployeeSkillById";
        internal static string DeleteEmployeeImmigrationDetailsById = "DeleteEmployeeImmigrationDetailsById";
        internal static string DeleteEmploymentStatusById = "DeleteEmploymentStatusById";
        internal static string DeleteEmplyeeFileAttachmentById = "DeleteEmplyeeFileAttachmentById";
        internal static string DeleteEmployeeContactDetailsById = "DeleteEmployeeContactDetailsById ";
       
       
        internal static string DeleteTerminationReasonById = "DeleteTerminationReasonById";
        internal static string GetEmployeeSalaryComponentById = "GetEmployeeSalaryComponentById";
        internal static string GetEmployeeEducationById = "GetEmployeeEducationById";
        internal static string GetEmployeeEducationsByUserId = "GetEmployeeEducationsByUserId";
        internal static string GetEmployeeFileAttachmentById = "GetEmployeeFileAttachmentById";
        internal static string GetEmployeeSkillById = "GetEmployeeSkillById";
        internal static string GetEmployeeSkillsByUserId = "GetEmployeeSkillsByUserId";

        /* JobCategory */
        internal static string GetJobCategoriesByTenantId = "GetJobCategoriesByTenantId";
        internal static string GetJobCategoryById = "GetJobCategoryById";
        internal static string DeleteJobCategoryById = "DeleteJobCategoryById";
        internal static string SaveJobCategory = "SaveJobCategory";


        /* JobTitle */
        internal static string SaveJobTitle = "SaveJobTitle";
        internal static string UpdateJobTitle = "SaveJobTitle";
        internal static string DeleteJobTitle = "DeleteJobTitleById";
        internal static string GetJobTitleById = "GetJobTitleById";
        internal static string GetJobTitlesByTenantId = "GetJobTitlesByTenantId";

        /* PayGrade */
        internal static string GetAllPayGradesByTenantId = "GetAllPayGradesByTenantId";
        internal static string SavePayGrade = "SavePayGrade";
        internal static string GetPayGradeById = "GetPayGradeById";
        internal static string GetPayGradeCurrenciesByPayGradeId = "GetPayGradeCurrenciesByPayGradeId";
        internal static string SavePayGradeCurrency = "SavePayGradeCurrency";
        internal static string DeletePayGradeCurrencyById = "DeletePayGradeCurrencyById";
        internal static string DeletePayGradeById = "DeletePayGradeById";
        internal static string DeleteUserLoginByLoginId = "DeleteUserLoginByLoginId";

        /* WorkShift */
        internal static string GetWorkShiftsByTenant = "GetWorkshiftsByTenantId";
        internal static string GetWorkshiftById = "GetWorkshiftById";
        internal static string SaveWorkshift = "SaveWorkshift";
        internal static string DeleteWorkshiftById = "DeleteWorkshiftById";
        internal static string GetEmployeeWorkshiftsByEmployeeId = "ZTM_GetEmployeeWorkshiftsByEmployeeId";

    }

}
