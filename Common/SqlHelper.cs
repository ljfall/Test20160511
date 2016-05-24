﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SqlHelper
{
    public static class SqlHelper
    {
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        //配置文件中
        //<connectionStrings>
        //	<add name="connStr" connectionString="server=.;database=test;uid=001;pwd=1;"/>
        //</connectionStrings>
        //或
        //<connectionStrings>
        //	<add name="connStr" connectionString="Data Source=steve-pc;Initial Catalog=itcast2014;Integrated Security=True"/>
        //</connectionStrings>

        /// <summary>
        /// 无返回值执行sql操作
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">存储过程</param>
        /// <param name="pms">SqlParameter</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 封装一个执行返回单个值的方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">存储过程</param>
        /// <param name="pms">SqlParameter</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 返回SqlDataReader对象的方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">存储过程</param>
        /// <param name="pms">SqlParameter</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(conStr);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception)
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }


        /// <summary>
        /// 封装一个返回DataTable的方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">存储过程</param>
        /// <param name="pms">SqlParameter</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }

            return dt;
        }
        
        /// <summary>
        /// 封装一个带事务的执行Sql语句的方法
        /// </summary>
        /// <param name="list"></param>
        public static void ExecuteNonQueryTran(List<SqlAndParameter> list)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        cmd.Transaction = trans;
                        try
                        {
                            foreach (var SqlObject in list)
                            {
                                cmd.CommandText = SqlObject.Sql;
                                if (SqlObject.Parameters != null)
                                {
                                    cmd.Parameters.AddRange(SqlObject.Parameters);
                                }
                                cmd.CommandType = SqlObject.CmdType;
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                            trans.Commit();
                        }
                        catch (Exception)
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
        }
    }

    public class SqlAndParameter
    {
        public string Sql
        {
            get;
            set;
        }

        public SqlParameter[] Parameters
        {
            get;
            set;
        }

        public CommandType CmdType
        {
            get;
            set;
        }
    }
}
