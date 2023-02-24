using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jinritemai.Author
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

    public class Author_base
    {
        /// <summary>
        /// 
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 小小种草
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fans_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int gender { get; set; }
        /// <summary>
        /// 山东·烟台
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int author_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar_big { get; set; }
    }

    public class Author_tag
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> main_cate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dark_horse { get; set; }
        /// <summary>
        /// 可在达人主页查看联系方式
        /// </summary>
        public string contact_icon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string high_reply { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int invitation_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int invite_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int satisfy_requirement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool already_cooperated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool is_star { get; set; }
    }

    public class Author_contact
    {
        /// <summary>
        /// 
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wechat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string douyin { get; set; }
    }

    public class Author_live
    {
        /// <summary>
        /// 
        /// </summary>
        public int watching_number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_status { get; set; }
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
        public int GPM_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GPM_low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GPM_high { get; set; }
    }

    public class Author_video
    {
        /// <summary>
        /// 
        /// </summary>
        public int play_median { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GPM_status { get; set; }
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
        public int video_sale_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int video_sale_low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int video_sale_high { get; set; }
    }

    public class Sale_requirement
    {
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int price_type { get; set; }
    }

    public class Author_conf
    {
        /// <summary>
        /// 
        /// </summary>
        public Sale_requirement sale_requirement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int effective_invite_num { get; set; }
    }

    public class Expr_score
    {
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int percentage { get; set; }
    }

    public class Product_score
    {
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int percentage { get; set; }
    }

    public class Logistics_score
    {
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int percentage { get; set; }
    }

    public class Service_score
    {
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int percentage { get; set; }
    }

    public class Author_score
    {
        /// <summary>
        /// 
        /// </summary>
        public Expr_score expr_score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Product_score product_score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Logistics_score logistics_score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Service_score service_score { get; set; }
    }

    public class Author_sale
    {
        /// <summary>
        /// 
        /// </summary>
        public int sale_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_d30_low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_d30_high { get; set; }
        /// <summary>
        /// 纯短视频
        /// </summary>
        public string main_sale_type { get; set; }
    }

    public class List
    {
        /// <summary>
        /// 
        /// </summary>
        public Author_base author_base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author_tag author_tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author_contact author_contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author_live author_live { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author_video author_video { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author_conf author_conf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author_score author_score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author_sale author_sale { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public bool has_more { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int res_source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List> list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string event_track_log_id { get; set; }
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
