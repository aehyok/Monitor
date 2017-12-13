using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Web;

namespace aehyok.Monitor.Models
{
    public class ServicesHelper
    {
        private string strPath;
        private ManagementClass managementClass;

        public  void startService()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            if (remoteConnectValidate("47.94.131.190", "administrator", "Aehyok918Teemo"))
            {
                win32ServiceManager("47.94.131.190", "administrator", "Aehyok918Teemo");
                string[,] services = getServiceList();
                for (int i = 0; i < services.GetLength(0); i++)
                {
                    dictionary.Add(i + "0", services[i, 3]);
                    dictionary.Add(i + "0", services[i, 3]);
                    dictionary.Add(i + "0", services[i, 3]);
                    dictionary.Add(i + "0", services[i, 3]);
                }
                string serviceName = "IISADMIN";
                ManagementObject mo = managementClass.CreateInstance();
                mo.Path = new ManagementPath(this.strPath + ".Name=\"" + serviceName + "\"");
                //StartService 启动服务,PauseService 暂停服务,ResumeService 恢复服务,StopService 停止服务    
                mo.InvokeMethod("StartService", null);
            }
        }
        /// <summary>    
        /// 验证是否能连接到远程计算机      
        /// </summary>    
        /// <param name="host">主机名或ip</param>    
        /// <param name="userName">用户名</param>    
        /// <param name="password">密码</param>    
        /// <returns></returns>    
        public static bool remoteConnectValidate(string host, string userName, string password)
        {
            ConnectionOptions connectionOptions = new ConnectionOptions();
            connectionOptions.Username = userName;
            connectionOptions.Password = password;
            connectionOptions.Impersonation = ImpersonationLevel.Impersonate;
            ManagementScope managementScope = new ManagementScope("\\\\" + host + "\\root\\cimv2", connectionOptions);
            try
            {
                managementScope.Connect();
            }
            catch(Exception exception)
            {
                ServiceController sc = new ServiceController("Server");
            }
            return managementScope.IsConnected;
        }
        /// <summary>    
        /// 获取所连接的计算机的所有服务数据    
        /// </summary>    
        /// <returns></returns>    
        public string[,] getServiceList()
        {
            string[,] services = new string[this.managementClass.GetInstances().Count, 4];
            int i = 0;
            foreach (ManagementObject mo in this.managementClass.GetInstances())
            {
                services[i, 0] = (string)mo["Name"];
                services[i, 1] = (string)mo["DisplayName"];
                services[i, 2] = (string)mo["State"];
                services[i, 3] = (string)mo["StartMode"];
                i++;
            }
            return services;
        }


        public void win32ServiceManager(string host, string userName, string password)
        {
            this.strPath = "\\\\" + host + "\\root\\cimv2:Win32_Service";
            this.managementClass = new ManagementClass(strPath);
            if (userName != null && userName.Length > 0)
            {
                ConnectionOptions connectionOptions = new ConnectionOptions();
                connectionOptions.Username = userName;
                connectionOptions.Password = password;
                ManagementScope managementScope = new ManagementScope("\\\\" + host + "\\root\\cimv2", connectionOptions);
                this.managementClass.Scope = managementScope;
            }
        }
    }
}