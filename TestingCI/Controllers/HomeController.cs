using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestingCI.Models;


namespace TestingCI.Controllers
{
    public class HomeController : ApiController
    {
        [AllowAnonymous]
        //[AllowAnonymous]//jangan lupa diganti Authorize
        [HttpPost]
        [Route("promo/list_promo_by_id")]
        public IHttpActionResult list_promo_by_id(bodyParameter body)
        {
            string tag = "list_promo_by_id";
            coreMyPoin.Service svc = new coreMyPoin.Service();

            try
            {
                string[] result = svc.promo_list_by_id(body.json);
                
                if (result[0] == "0")
                {
                    clsSendListPromoById response = new clsSendListPromoById();
                    response.tag = tag;
                    response.success = "1";
                    response.error = "0";
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<ArrayList>(result[1]); //bisa pake object json atau harus arraylist? -20190927
                    response.data = data;
                    return Json(response);
                }
                else
                {
                    cResponseGagal responseError = new cResponseGagal();
                    responseError.tag = tag;
                    responseError.success = "-9";
                    responseError.error = "1";
                    responseError.error_msg = result[1];
                  
                    return Json(responseError);
                }

            }
            catch (Exception ex)
            {
                cResponseGagal responseError = new cResponseGagal();
                responseError.tag = tag;
                responseError.success = "-9";
                responseError.error = "1";
                responseError.error_msg = "Technical problem, please contact Dev team";
             
                return Json(responseError);
            }

            //string[] result = svc.list_hadiah()
        }

    }
}
