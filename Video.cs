using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jinritemai.Video
{
    public class Extra
    {
        /// <summary>
        /// 
        /// </summary>
        public long now { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string log_id { get; set; }
    }

    public class List
    {
        /// <summary>
        /// 
        /// </summary>
        public string videoId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string preview_pic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string content_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime date_create { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string play_times { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int interact_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_high { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GPM_low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GPM_high { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string promotion_sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comment_sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string like_sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reshare_sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool with_product { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool can_visit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int live_sale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GPM { get; set; }
        /// <summary>
        /// 它既是一个汤锅，也是一个蒸锅，太划算了，不锈钢材质，29.9还包邮，赶紧囤#汤锅 #蒸锅 #厨房好物 #好东西一起分享给大家 #使用一次你就喜欢上它
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GPM_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string recommend_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string recommend_rate { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List> list { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public int st { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Extra extra { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
    }

}
