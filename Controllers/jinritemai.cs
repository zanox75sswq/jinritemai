using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jinritemai.Controllers
{
    [Route("api/jinritemai")]
    [ApiController]
    public class jinritemai : ControllerBase
    {
        /// <summary>
        /// 获取作者
        /// </summary>
        /// <returns></returns>
        [HttpGet("getAuthor")]
        public async Task<string> getAuthor()
        {
            for (int i= 0; i < 100; i++){
                try
                {
                   var json = await GetUrls_async(string.Format("https://buyin.jinritemai.com/api/authorStatData/seekAuthor?type=2&page={0}&refresh=false&req_source=0&query=&search_id=&search_source=1&act_id=&msToken=n3yP44xjvvMrAUR2OaxPzQcKsQjDrrG4DpH79snZTEKXzNVRNJ-L9Q1SzFNsWkj2BUDJni07iK3A6dXHsTO-Lpnf3_4gHzKR6HvXnwAi8SRtgIAM6dGOK9k4YnUZRS8=&X-Bogus=DFSzswVu/dtANn/xSgneTRXAIQRs&_signature=_02B4Z6wo00001M.E05AAAIDBrM4T-33rhiDPxNcAAFAOfXjISYKc0ecu2DUxLRJrSns6IX4203yLU7TSiXXI0xyET1xKxiI7IILTZARl97drbqUSN9kkIlZMzdyjXwgUbIrsuACv2fkmbFT463", i), "");

                    Author.Root rt = JsonConvert.DeserializeObject<Author.Root>(json);
                   //获取播放量
                    foreach(var k in rt.data.list)
                    {
                        var video_json = await GetUrls_async(string.Format("https://buyin.jinritemai.com/api/authorStatData/authorVideoDetailList?uid={0}&page=1&with_product=true&msToken=R6qCXtkJvuO3ARWy12SindWoho9VE4FNTNDCs5N7oRPYqNKBcBuTrTXF2bBweV4QxVbodX8VJUJH__WpaxlcDMhoTBn7FRJXLht6XGUia_KbJyFaloVddw==&X-Bogus=DFSzswVu9khANn/xSgJ83YXAIQ-M&_signature=_02B4Z6wo00001wikMCgAAIDCa67wQLh664sIpDSAAKHbY4FMpZbWu2qakRxjlNRfbqK8DNwagzhUcj-3mfzBTmWmnjhkweS5yWsTtypNCPLtwkJsptmPhnZ.W2CF6OXhVIkF8j44WGkkc-D039", k.author_base.uid), "");
                        Video.Root video_rt = JsonConvert.DeserializeObject<Video.Root>(video_json);
                        
                        
                        //分页total 条数+1   
                    }

                }
                catch(Exception ex)
                {

                }
            }
            return null;
        }

        private async Task<string> GetUrls_async(string url, string us_agent)
        {
            try
            {
                //GetUrl_index("https://www.toutiao.com/", us_agent);
                if (string.IsNullOrEmpty(url))
                {
                    throw new ArgumentNullException("url");
                }
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "GET";
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.Headers.Add("accept-language", "zh-CN,zh;q=0.9,en;q=0.8");
                request.Headers.Add("sec-fetch-dest", "document");
                request.Headers.Add("sec-fetch-mode", "navigate");
                request.Headers.Add("sec-fetch-site", "same-origin");
                request.Headers.Add("Sec-Fetch-User", "?1");
                request.Headers.Add("Upgrade-Insecure-Requests", "1");
                request.Headers.Add("cookie", "passport_csrf_token=1f7cd92b6474faae16e415a05759fba8; passport_csrf_token_default=1f7cd92b6474faae16e415a05759fba8; d_ticket=9183f019b5079f7dd1c99a9f56bc9c99c1759; n_mh=fwyKeZAWbOEum3husuQqS3lcbjxOf5xwvxBtYHaX7AY; sso_auth_status=5ca09f1b8aa850f6d64c5dbca6fd76b2; sso_auth_status_ss=5ca09f1b8aa850f6d64c5dbca6fd76b2; store-region=cn-gd; store-region-src=uid; s_v_web_id=verify_lei8x138_JeZXYZJJ_U8jo_4BYX_8IkW_hWEoM8Vmn5m2; ttwid=1%7C4xdn1mI9XGvp3c9nqfEjP33yMtY_pT1mfGivPPWJ0B4%7C1677225784%7Ced870e49c6a374e06bc97d0cad87b0d4c4b5cad6cd9b6a607f0cb244ae7cd8da; sso_uid_tt=24164b7dd826b2a53d9cd5acc62bdead; sso_uid_tt_ss=24164b7dd826b2a53d9cd5acc62bdead; toutiao_sso_user=25e0a96f4dd8d111da21b69a512e343a; toutiao_sso_user_ss=25e0a96f4dd8d111da21b69a512e343a; sid_ucp_sso_v1=1.0.0-KGFkZWY4M2QwZTE3NzBlMWRlZTY4OGVhMjIxNGJmNDg2MTNiYWQxZDYKHgjNpLC8yI29BBC53uGfBhiwISAMMJHyoZYGOAhAJhoCbGYiIDI1ZTBhOTZmNGRkOGQxMTFkYTIxYjY5YTUxMmUzNDNh; ssid_ucp_sso_v1=1.0.0-KGFkZWY4M2QwZTE3NzBlMWRlZTY4OGVhMjIxNGJmNDg2MTNiYWQxZDYKHgjNpLC8yI29BBC53uGfBhiwISAMMJHyoZYGOAhAJhoCbGYiIDI1ZTBhOTZmNGRkOGQxMTFkYTIxYjY5YTUxMmUzNDNh; passport_auth_status=f740b4ec5960146da9a346579cfc2009%2C34ba9e0a027891adcd9efb62861255df; passport_auth_status_ss=f740b4ec5960146da9a346579cfc2009%2C34ba9e0a027891adcd9efb62861255df; uid_tt=fd147b017366904d5f995119714d00da; uid_tt_ss=fd147b017366904d5f995119714d00da; sid_tt=eb603d3d176222fca603b0c5f82e50c5; sessionid=eb603d3d176222fca603b0c5f82e50c5; sessionid_ss=eb603d3d176222fca603b0c5f82e50c5; odin_tt=7d17f20ac1eb6beb21b532b8ce3c000f08c1812df47a32645b1d9f5c9f896f03f294ec5cc43d0cd257d10384660343a1c7f2ebe5b81db324c4c7dd0402cc41bd; ucas_sso_c0=CkEKBTEuMC4wELeIk5LI5pv8YxjmJiDrq5Ds-YyzByiwITDNpLC8yI29BEC83uGfBki8kp6iBlCAvKKes5TfvGNYcBIU3RhZhRtKfd3biKiRqESEKMUW9jc; ucas_sso_c0_ss=CkEKBTEuMC4wELeIk5LI5pv8YxjmJiDrq5Ds-YyzByiwITDNpLC8yI29BEC83uGfBki8kp6iBlCAvKKes5TfvGNYcBIU3RhZhRtKfd3biKiRqESEKMUW9jc; ucas_c0=CkEKBTEuMC4wEKKIgpCX5pv8YxjmJiDrq5Ds-YyzByiwITDNpLC8yI29BEC83uGfBki8kp6iBlCAvKKes5TfvGNYcBIUkrcet7zutjPuLo39AEvW7CAr4QA; ucas_c0_ss=CkEKBTEuMC4wEKKIgpCX5pv8YxjmJiDrq5Ds-YyzByiwITDNpLC8yI29BEC83uGfBki8kp6iBlCAvKKes5TfvGNYcBIUkrcet7zutjPuLo39AEvW7CAr4QA; sid_guard=eb603d3d176222fca603b0c5f82e50c5%7C1677225788%7C5184000%7CTue%2C+25-Apr-2023+08%3A03%3A08+GMT; sid_ucp_v1=1.0.0-KDQxY2FmMTMxMThhNjYzMzc3NTQxNjgxYzU4ODczZDNlZjc0NzU2OTUKGAjNpLC8yI29BBC83uGfBhimDCAMOAhAJhoCbHEiIGViNjAzZDNkMTc2MjIyZmNhNjAzYjBjNWY4MmU1MGM1; ssid_ucp_v1=1.0.0-KDQxY2FmMTMxMThhNjYzMzc3NTQxNjgxYzU4ODczZDNlZjc0NzU2OTUKGAjNpLC8yI29BBC83uGfBhimDCAMOAhAJhoCbHEiIGViNjAzZDNkMTc2MjIyZmNhNjAzYjBjNWY4MmU1MGM1; PHPSESSID=87aabcfe52f36275eaaaa60a45f27bdf; PHPSESSID_SS=87aabcfe52f36275eaaaa60a45f27bdf; SASID=SID2_3601814961552276217; BUYIN_SASID=SID2_3601814961552276217; buyin_app_id=13; buyin_shop_type=11; ttcid=4785c82186bc469ca266dc5fd17bf27c34; _tea_utm_cache_2018=undefined; msToken=qkHcqxO168dQmSNjV6acYiSQuKS6vdwWr23ga6R5JZgW2sW0RHrXUWccGg_JCNZ3ai6yqU2KD899K6c19nDR9SJ5Kdo_kvivbI_3wIJfpcS7nHQ3WWpwIA==; msToken=9goz0yv7rI5O5F8KgvY1Z47K21sWymJt7oWnzmU-B79yg8AIkf5Y6tjGSVgQmgBvTbaV3BlPcGe-iCE1gHPVNELybLpvxufRI5OkbIV605xV84LWjrGtUHdvZ9iVq9w=; tt_scid=gavPGXqY9QHDQ0BvW1m0TXxjuvw4uIflId9ekSJsdR3-D3idqb4yDvuP2wvH75B-fe58");
                request.ContentLength = 0;
                request.KeepAlive = false;

                // request.Headers.Add("cookie", "tt_webid=6823616452479370760; WEATHER_CITY=%E5%8C%97%E4%BA%AC; tt_webid=6823616452479370760; csrftoken=f630d0f4076994d6fd3e7e5517de1ca9; SLARDAR_WEB_ID=6275282d-3f8e-4333-83f2-0eba87f12f28; s_v_web_id=verify_ka0oey8q_FkR71kMd_aN0R_4UtG_AAU3_0DG1NGpk42c3; __tasessionId=8v22tq0nw1589092114838; __ac_nonce=05eb7a5ee0077ec8d43c0; __ac_signature=vv1.OAAgEBB4qsa1z-WsLr78fiAAOBY8uBs8yZaqmDQZfcMPqIVk3EuWnkGDoy6VzLyen0Rc-NRxHHQElniZwAwH.T4-mc4JfCCRu0r8er3UnSDXhPC.ZTWWLfyIxYte4j9; tt_scid=RERcdoZMvjTTbe4sDrgFu73u8Btd5h03gjNOnBGaru6Grhxd2oZjhwHN221nkVn15a77");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream stream = response.GetResponseStream();

                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();

                    sr.Close();
                }

                return result;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
