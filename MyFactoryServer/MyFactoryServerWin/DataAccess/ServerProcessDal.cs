using Dapper;
using MyFactoryServer.Models;
using MyFactoryServerWin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryServer.DataAccess
{
    public static class ServerProcessDal
    {
        public static readonly string LocalDb = @"Server=(localdb)\MSSQLLocalDB; Database=Deneme; Trusted_Connection=true";


        public static Result<DataTable> GetDatatableReturnInvoice()
        {
            try
            {
                DataTable resultDataTable = new DataTable();
                using (var connection = new SqlConnection(LocalDb))
                {
                    connection.Open();
                    string query = "";
                    var reader = connection.ExecuteReader(sql: query, commandTimeout: 1000);
                    resultDataTable.Load(reader);
                    connection.Close();
                }

                return new Result<DataTable>(true, string.Format("{0}", Messages.Successful), resultDataTable);
            }
            catch (Exception ex)
            {
                return new Result<DataTable>(false, string.Format("{0} {1}", Messages.DatabaseQueryError, ex.Message), null);
            }
        }

        public static Result<string> Update(Guid pId)
        {

            try
            {
                int numResults;
                using (var connection = new SqlConnection(LocalDb))
                {
                    string query = "";
                    numResults = connection.Execute(query, param: new { @Id = pId });
                }
                if (numResults > 0)
                {
                    return new Result<string>(true, Messages.Modified, "");
                }
                else
                {
                    return new Result<string>(false, Messages.NotModified, "");
                }

            }
            catch (Exception ex)
            {
                return new Result<string>(false, string.Format("{0} {1}", Messages.ModifiedFail, ex.Message), null);
            }
        }


        public static Result<string> UpsertMachineInfos(M001 m001)
        {

            try
            {
                int numResults;
                using (var connection = new SqlConnection(LocalDb))
                {
                    string query = @"
                                    SELECT [MachineInfoId]
                                    	,[MachineId]
                                    	,[MachineName]
                                    	,[MachineType]
                                    	,[ProductionSpeeedOfMachine]
                                    	,[ProductionUnitType]
                                    	,[MachineStatus]
                                    FROM [Deneme].[MVF].[MachineInfos] WITH (NOLOCK)
                                    WHERE 1 = 1
                                    	AND [MachineId] = @MachineId
                                    
                                    IF (@@ROWCOUNT > 0)
                                    BEGIN
                                    	UPDATE [Deneme].[MVF].[MachineInfos]
                                    	SET [MachineName] = @MachineName
                                    		,[MachineType] = @MachineType
                                    		,[ProductionSpeeedOfMachine] = @ProductionSpeeedOfMachine
                                    		,[ProductionUnitType] = @ProductionUnitType
                                    		,[MachineStatus] = @MachineStatus
                                            ,[MachineIP] = @MachineIP
                                            ,[MachinePort] = @MachinePort
                                    	WHERE 1 = 1
                                    		AND [MachineId] = @MachineId
                                    END
                                    ELSE
                                    BEGIN
                                    	INSERT INTO [Deneme].[MVF].[MachineInfos] (
                                    		 [MachineInfoId]
                                    		,[MachineId]
                                    		,[MachineName]
                                    		,[MachineType]
                                    		,[ProductionSpeeedOfMachine]
                                    		,[ProductionUnitType]
                                    		,[MachineStatus]
                                            ,[MachineIP] 
                                            ,[MachinePort]
                                    		)
                                    	VALUES (
                                    		NEWID()
                                    		,@MachineId
                                    		,@MachineName
                                    		,@MachineType
                                    		,@ProductionSpeeedOfMachine
                                    		,@ProductionUnitType
                                    		,@MachineStatus
                                            ,@MachineIP
                                            ,@MachinePort
                                    		)
                                    END
                                    ";
                    numResults = connection.Execute(query, param: new
                    {
                        @MachineId = m001.MachineId,
                        @MachineName = m001.MachineName,
                        @MachineType = (int)m001.MachineType,
                        @ProductionSpeeedOfMachine = m001.ProductionSpeeedOfMachine,
                        @ProductionUnitType = (int)m001.ProductionUnitType,
                        @MachineStatus = m001.MachineStatus,
                        @MachineIP = m001.MyIPAdress,
                        @MachinePort = m001.MyPort
                    });
                }
                if (numResults > 0)
                {
                    return new Result<string>(true, Messages.Modified, "");
                }
                else
                {
                    return new Result<string>(false, Messages.NotModified, "");
                }

            }
            catch (Exception ex)
            {
                return new Result<string>(false, string.Format("{0} {1}", Messages.ModifiedFail, ex.Message), null);
            }
        }

        public static Result<DataTable> GetDatatableCheckUserInfo(M003 m003) 
        {
            try
            {
                DataTable resultDataTable = new DataTable();
                using (var connection = new SqlConnection(LocalDb))
                {
                    connection.Open();
                    string query = @"
                                SELECT [UserInfoId]
                                      ,[UserName]
                                      ,[Password]
                                      ,[IsOnline]
                                  FROM [Deneme].[MVF].[UserInfos] WITH(NOLOCK)
                                  WHERE 1=1
                                  AND [UserName]=@UserName
                                  and [Password]=@Password
                                ";
                    var reader = connection.ExecuteReader(sql: query, param: new { @UserName=m003.UserName , @Password=m003.Password }, commandTimeout: 1000);
                    resultDataTable.Load(reader);
                    connection.Close();
                }

                return new Result<DataTable>(true, string.Format("{0}", Messages.Successful), resultDataTable);
            }
            catch (Exception ex)
            {
                return new Result<DataTable>(false, string.Format("{0} {1}", Messages.DatabaseQueryError, ex.Message), null);
            }
        }


        public static Result<string> InsertWorks(M004 m004)
        {

            try
            {
                int numResults;
                using (var connection = new SqlConnection(LocalDb))
                {
                    string query = @"
                                    INSERT INTO [MVF].[Works]
                                           ([WorkId]
                                           ,[UserName]
                                           ,[MachineType]
                                           ,[QuantityToBeProduced]
                                           ,[ProductionUnitType]
                                           ,[CreatedDate]
                                           ,[StartDate]
                                           ,[FinishDate]
                                           ,[MachineId]
                                           ,[WorkStatus]
                                            )
                                     VALUES
                                           (
                                		   NEWID()
                                           ,@UserName
                                           ,@MachineType
                                           ,@QuantityToBeProduced
                                           ,@ProductionUnitType
                                           ,GETDATE()
                                           ,NULL
                                           ,NULL
                                           ,NULL
                                           ,0
                                		   )                                    
                                    ";
                    numResults = connection.Execute(query, param: new
                    {
                        @UserName=m004.UserName,                        
                        @MachineType = (int)m004.MachineType,
                        @QuantityToBeProduced = m004.QuantityToBeProduced,
                        @ProductionUnitType = (int)m004.ProductionUnitType                        
                    });
                }
                if (numResults > 0)
                {
                    return new Result<string>(true, Messages.Modified, "");
                }
                else
                {
                    return new Result<string>(false, Messages.NotModified, "");
                }

            }
            catch (Exception ex)
            {
                return new Result<string>(false, string.Format("{0} {1}", Messages.ModifiedFail, ex.Message), null);
            }
        }

        public static Result<DataTable> GetDatatableMachineInfos()
        {
            try
            {
                DataTable resultDataTable = new DataTable();
                using (var connection = new SqlConnection(LocalDb))
                {
                    connection.Open();
                    string query = @"
                                SELECT [MachineInfoId]
                                    ,[MachineId]
                                    ,[MachineName]
                                    ,[MachineType]
                                    ,[ProductionSpeeedOfMachine]
                                    ,[ProductionUnitType]
                                    ,[MachineStatus]
                                    ,[MachineIP]
                                    ,[MachinePort]
                                FROM [Deneme].[MVF].[MachineInfos] WITH(NOLOCK)
                                ";
                    var reader = connection.ExecuteReader(sql: query, commandTimeout: 1000);
                    resultDataTable.Load(reader);
                    connection.Close();
                }

                return new Result<DataTable>(true, string.Format("{0}", Messages.Successful), resultDataTable);
            }
            catch (Exception ex)
            {
                return new Result<DataTable>(false, string.Format("{0} {1}", Messages.DatabaseQueryError, ex.Message), null);
            }
        }

        public static Result<DataTable> GetDatatableMachineStatusAndWorksList(M006 m006)
        {
            try
            {
                DataTable resultDataTable = new DataTable();
                using (var connection = new SqlConnection(LocalDb))
                {
                    connection.Open();
                    string query = @"
                                SELECT
                                    W.[WorkId]
                                   ,W.[UserName]
                                   ,W.[MachineType]
                                   ,W.[QuantityToBeProduced]
                                   ,W.[ProductionUnitType]
                                   ,W.[CreatedDate]
                                   ,W.[StartDate]
                                   ,W.[FinishDate]      
                                   ,W.[WorkStatus]	                               
                                   ,MI.[MachineId]
                                   ,MI.[MachineName]                                   
                                   ,MI.[MachineStatus]                                   
                                FROM [Deneme].[MVF].[Works] AS W WITH(NOLOCK)
                                INNER JOIN [Deneme].[MVF].[MachineInfos] AS MI WITH(NOLOCK)
                                ON W.MachineId=MI.MachineId
                                WHERE 1=1
                                AND MI.MachineId=@MachineId
                                ";
                    var reader = connection.ExecuteReader(sql: query,param:new { @MachineId=m006.MachineId }, commandTimeout: 1000);
                    resultDataTable.Load(reader);
                    connection.Close();
                }

                return new Result<DataTable>(true, string.Format("{0}", Messages.Successful), resultDataTable);
            }
            catch (Exception ex)
            {
                return new Result<DataTable>(false, string.Format("{0} {1}", Messages.DatabaseQueryError, ex.Message), null);
            }
        }

        public static Result<DataTable> GetDatatableWaitingWorksList()
        {
            try
            {
                DataTable resultDataTable = new DataTable();
                using (var connection = new SqlConnection(LocalDb))
                {
                    connection.Open();
                    string query = @"
                                SELECT
                                    *                                   
                                FROM [Deneme].[MVF].[Works] AS W WITH(NOLOCK) 
                                WHERE 1=1
                                AND W.WorkStatus=0
                                ";
                    var reader = connection.ExecuteReader(sql: query, commandTimeout: 1000);
                    resultDataTable.Load(reader);
                    connection.Close();
                }

                return new Result<DataTable>(true, string.Format("{0}", Messages.Successful), resultDataTable);
            }
            catch (Exception ex)
            {
                return new Result<DataTable>(false, string.Format("{0} {1}", Messages.DatabaseQueryError, ex.Message), null);
            }
        }

    }




}
