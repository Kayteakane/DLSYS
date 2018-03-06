using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DLSYS.Controllers
{
    //[RoutePrefix("api/functions")]
    public class ViewFunctionsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage getWeek(String date)
        {
            int week_num = 0;
            try
            {

                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                DateTime date1 = Convert.ToDateTime(date);
                Calendar cal = dfi.Calendar;

                /**Console.WriteLine("{0:d}: Week {1} ({2})", date1,
                                  cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                                    dfi.FirstDayOfWeek),
                                  cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1));*/
                week_num = cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
            }
            catch (Exception e)
            {
                //  e.
            }
            return Request.CreateResponse<string>(HttpStatusCode.OK, week_num.ToString("00"));
        }

        [HttpGet]
        public HttpResponseMessage getDateNow()
        {
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

            // foreach (var cultureName in cultureNames)
            // {
            var culture = new CultureInfo("en-GB");


           // return localDate.ToString(culture);
            return Request.CreateResponse<string>(HttpStatusCode.OK, localDate.ToString(culture));
            /** Console.WriteLine("{0}: {1}", cultureName,
                               localDate.ToString(culture));*/
            // }
        }

        /**[HttpGet]
        public HttpResponseMessage GetDeliveryItemsTwo()
        {
            return Request.CreateResponse<string>(HttpStatusCode.OK,"Hello");
        }*/
    }
}
