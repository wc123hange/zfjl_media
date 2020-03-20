﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DTcms.Common
{
    /// <summary>
    /// <para>　</para>
    /// 　常用工具类——Web.Config操作类
    /// <para>　--------------------------------------------------------------</para>
    /// <para>　GetConfigString：得到AppSettings中的配置字符串信息</para>
    /// <para>　GetConnectionString：得到Connection中配置字符串信息</para>
    /// <para>　GetConfigBool：得到AppSettings中的配置Bool信息</para>
    /// <para>　GetConfigDecimal：得到AppSettings中的配置Decimal信息</para>
    /// <para>　GetConfigDecimal：得到AppSettings中的配置int信息</para>
    /// </summary>
    public class ConfigUtil
    {
        #region Asp.NET的Web.config

        #region 得到AppSettings中的配置字符串信息
        /// <summary>
        /// 得到AppSettings中的配置字符串信息
        /// </summary>
        /// <param name="key">AppSetting中关键字KEY</param>
        /// <returns>AppSettings中的配置字符串信息</returns>
        public static string GetConfigString(string key)
        {
            string AppStr = ConfigurationManager.AppSettings[key].ToString();
            return AppStr;
        }
        #endregion

        #region 得到Connection中配置字符串信息
        /// <summary>
        /// 得到Connection中配置字符串信息
        /// </summary>
        /// <param name="key">Connection中name的值</param>
        /// <returns>Connection中name的值</returns>
        public static string GetConnectionString(string key)
        {
            string ConnStr = ConfigurationManager.ConnectionStrings[key].ToString();
            return ConnStr;
        }
        /// <summary>
        /// 获取Connection中配置字符串信息列表
        /// </summary>
        /// <returns></returns>
        public static List<dynamic> GetConnectionStringList()
        {
            var connects = ConfigurationManager.ConnectionStrings;
            List<dynamic> connectList = new List<dynamic>();
            foreach (ConnectionStringSettings c in connects)
            {
                connectList.Add(new
                {
                    name = c.Name,
                    providerName = c.ProviderName
                });
            }
            return connectList;
        }
        #endregion

        #region 得到AppSettings中的配置Bool信息
        /// <summary>
        /// 得到AppSettings中的配置Bool信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetConfigBool(string key)
        {
            bool result = false;
            string cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
            {
                try
                {
                    result = bool.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            }
            return result;
        }
        #endregion

        #region 得到AppSettings中的配置Decimal信息
        /// <summary>
        /// 得到AppSettings中的配置Decimal信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static decimal GetConfigDecimal(string key)
        {
            decimal result = 0;
            string cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
            {
                try
                {
                    result = decimal.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            }

            return result;
        }
        #endregion
        #region 得到AppSettings中的配置Decimal信息
        /// <summary>
        /// 得到AppSettings中的配置Double信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static double GetConfigDouble(string key)
        {
            double result = 0;
            string cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
            {
                try
                {
                    result = double.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            }

            return result;
        }
        #endregion
        #region 得到AppSettings中的配置int信息
        /// <summary>
        /// 得到AppSettings中的配置int信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetConfigInt(string key)
        {
            int result = 0;
            string cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
            {
                try
                {
                    result = int.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            }

            return result;
        }
        #endregion

        #endregion
    }
}
