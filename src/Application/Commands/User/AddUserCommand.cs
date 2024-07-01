using MediatR;
using Application.Response;
using System;

namespace Application.Commands.User

{
    public class AddUserCommand:IRequest<GenericPairResponse>
    {
        public int Id { get; set; }
        public int Orgid { get; set; }
        public int UserRoleId { get; set; }
        public int EmpNumber { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int Deleted { get; set; }
        public int Status { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedUserId { get; set; }
        public int CreatedBy { get; set; }

        //public int id { get; set; }
        //public string user_name { get; set; }
        //public string user_password { get; set; }
        public string CalColor { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string ReportsToId { get; set; }
        public string IsAdmin { get; set; }
        public int CurrencyId { get; set; }
        public string Description { get; set; }
        //public DateTime date_entered { get; set; }
        //public DateTime date_modified { get; set; }
        public string V_ModifiedUserId { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneFax { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Secondaryemail { get; set; }
        public string V_Status { get; set; }
        public string Signature { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostalcode { get; set; }
        public string UserPreferences { get; set; }
        public string Tz { get; set; }
        public string Holidays { get; set; }
        public string Namedays { get; set; }
        public string Workdays { get; set; }
        public int Weekstart { get; set; }
        public string DateFormat { get; set; }
        public string HourFormat { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public string IsOwner { get; set; }
        public string ActivityView { get; set; }
        public string lead_view { get; set; }
        public string Imagename { get; set; }
        //public int deleted { get; set; }
        public string ConfirmPassword { get; set; }
        public string InternalMailer { get; set; }
        public string ReminderInterval { get; set; }
        public string ReminderNextTime { get; set; }
        public string CryptType { get; set; }
        public string Accesskey { get; set; }
        public string Theme { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
        public string CurrencyGroupingPattern { get; set; }
        public string CurrencyDecimalSeparator { get; set; }
        public string CurrencyGroupingSeparator { get; set; }
        public string CurrencySymbolPlacement { get; set; }
        public string UserLabel { get; set; }
        public string DefaultLandingPage { get; set; }
        public string PhoneCrmExtension { get; set; }
        public string NoOfCurrencyDecimals { get; set; }
        public string TruncateTrailingZeros { get; set; }
        public string DayOfTheWeek { get; set; }
        public string CallDuration { get; set; }
        public string OthereVentDuration { get; set; }
        public string CalendarSharedType { get; set; }
        public string DefaultRecordView { get; set; }
        public string LeftPanelHide { get; set; }
        public string RowHeight { get; set; }
        public string DefaultEventStatus { get; set; }
        public string DefaultActivityType { get; set; }
        public int HideCompletedEvents { get; set; }
        public string DefaultCalendarView { get; set; }
    }
}
