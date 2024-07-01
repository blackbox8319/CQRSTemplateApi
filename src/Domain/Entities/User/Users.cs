using Domain.Common;
using Google.Protobuf.WellKnownTypes;
using System;

namespace Domain.Entities.User

{
    public class Users
    {
        public int id { get; set; }
        public int org_id { get; set; }
        public int user_role_id { get; set; }
        public int emp_number { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public int deleted { get; set; }
        public int status { get; set; }
        public DateTime date_entered { get; set; }
        public DateTime date_modified { get; set; }
        public int modified_user_id { get; set; }
        public int created_by { get; set; }

        //public int id { get; set; }
        //public string user_name { get; set; }
        //public string user_password { get; set; }
        public string cal_color { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string reports_to_id { get; set; }
        public string is_admin { get; set; }
        public int currency_id { get; set; }
        public string description { get; set; }
        //public DateTime date_entered { get; set; }
        //public DateTime date_modified { get; set; }
        public string v_modified_user_id { get; set; }
        public string title { get; set; }
        public string department { get; set; }
        public string phone_home { get; set; }
        public string phone_mobile { get; set; }
        public string phone_work { get; set; }
        public string phone_other { get; set; }
        public string phone_fax { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string secondaryemail { get; set; }
        public string v_status { get; set; }
        public string signature { get; set; }
        public string address_street { get; set; }
        public string address_city { get; set; }
        public string address_state { get; set; }
        public string address_country { get; set; }
        public string address_postalcode { get; set; }
        public string user_preferences { get; set; }
        public string tz { get; set; }
        public string holidays { get; set; }
        public string namedays { get; set; }
        public string workdays { get; set; }
        public int weekstart { get; set; }
        public string date_format { get; set; }
        public string hour_format { get; set; }
        public string start_hour { get; set; }
        public string end_hour { get; set; }
        public string is_owner { get; set; }
        public string activity_view { get; set; }
        public string lead_view { get; set; }
        public string imagename { get; set; }
        //public int deleted { get; set; }
        public string confirm_password { get; set; }
        public string internal_mailer { get; set; }
        public string reminder_interval { get; set; }
        public string reminder_next_time { get; set; }
        public string crypt_type { get; set; }
        public string accesskey { get; set; }
        public string theme { get; set; }
        public string language { get; set; }
        public string time_zone { get; set; }
        public string currency_grouping_pattern { get; set; }
        public string currency_decimal_separator { get; set; }
        public string currency_grouping_separator { get; set; }
        public string currency_symbol_placement { get; set; }
        public string userlabel { get; set; }
        public string defaultlandingpage { get; set; }
        public string phone_crm_extension { get; set; }
        public string no_of_currency_decimals { get; set; }
        public string truncate_trailing_zeros { get; set; }
        public string dayoftheweek { get; set; }
        public string callduration { get; set; }
        public string othereventduration { get; set; }
        public string calendarsharedtype { get; set; }
        public string default_record_view { get; set; }
        public string leftpanelhide { get; set; }
        public string rowheight { get; set; }
        public string defaulteventstatus { get; set; }
        public string defaultactivitytype { get; set; }
        public int hidecompletedevents { get; set; }
        public string defaultcalendarview { get; set; }
    }

}
