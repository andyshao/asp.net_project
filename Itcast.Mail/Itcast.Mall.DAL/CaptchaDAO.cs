using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Itcast.Mall.Model;
using System.Data.SqlClient;
using Itcast.Mall.Utility;


namespace Itcast.Mall.DAL
{
    public class CaptchaDAO
    {
        public IEnumerable<Captcha> GetList() {
            #region MyRegion  
            //    using (SqlConnection conn = new SqlConnection(""))
            //    {
            //        using (SqlCommand cmd = conn.CreateCommand())
            //        {
            //            cmd.CommandText = "select * from Captcha";
            //                conn.Open();
            //                using (SqlDataReader reader = cmd.ExecuteReader())
            //                {
            //                    if (reader.HasRows)
            //                    {
            //                        IList<Captcha> list = new List<Captcha>();
            //                        while (reader.Read())
            //                        {
            //                            Captcha model = new Captcha
            //                            {
            //                                Id = Convert.ToInt32(reader.GetValue(0)),
            //                                UserId = Convert.ToInt32(reader.GetValue(1)),
            //                                Token = Convert.ToString(reader.GetValue(2)),
            //                                Actived = Convert.ToBoolean(reader.GetValue(3)),
            //                                Expired = Convert.ToDateTime(reader.GetValue(4))
            //                            };
            //                            list.Add(model);
            //                        }
            //                        return list;
            //                    }
            //                }
            //          }
            //    }
            //    return null; 
            #endregion

            #region MyRegion
            //using(var reader = SqlHelper.ExecuteReader(""))
            //{
            //    if(reader.HasRows)
            //    {
            //        IList<Captcha> list = new List<Captcha>();
            //        while (reader.Read())
            //        {
            //            list.Add(SqlHelper.MapEntity<Captcha>(reader));
            //        }
            //        return list;
            //    }
            //}
            //return null; 
            #endregion
            using (var reader = SqlHelper.ExecuteReader(""))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<Captcha>(reader);
                    }
                }
            }
        }
    }
}
