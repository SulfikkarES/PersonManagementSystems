#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : PersonDBConnection.cs
// Purpose         : To define the connection properties and methods
// Creation Date   : 12-10-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright EazyLearn

#region Included namespaces
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion Included namespaces

namespace EazyLern.PersonManagementSystemSulfikkar.Components
{
    class PersonDBConnection
    {
        #region Public Static Properties
        /// <summary>
        /// Gets or Sets the connection string
        /// </summary>
        public static string perConnectionString
        {
            get;
            set;
        }
        #endregion Public Static Properties

        #region Public Static Methods
        /// <summary>
        /// Method to initialise and returns the connection object
        /// </summary>
        /// <returns> Sql connection object </returns>
        
        #region Getconnection
        public static SqlConnection GetConnetction()
        {
            SqlConnection Conobj;
            perConnectionString = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            Conobj = new SqlConnection(perConnectionString);

            return Conobj;
        
//internal static SqlConnection GetConnetction()
        {
            throw new NotImplementedException();
        }
    }
        #endregion Getconnection
        #endregion Public Static Methods
    }
}
