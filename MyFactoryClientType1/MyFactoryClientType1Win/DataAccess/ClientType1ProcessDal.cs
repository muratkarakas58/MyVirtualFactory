using Dapper;
using MyFactoryClientType1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryClientType1.DataAccess
{
    public class ClientType1ProcessDal
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

        public static Result<string> UpsertAtNowMachineStatuses(int machineId, int machineStatusId)
        {

            try
            {
                int numResults;
                using (var connection = new SqlConnection(LocalDb))
                {
                    string query = @"
                                    SELECT [AtNowMachineStatusId]
                                    	,[MachineId]
                                    	,[MachineStatusId]
                                    FROM [Deneme].[MVF].[AtNowMachineStatuses] WITH (NOLOCK)
                                    WHERE 1 = 1
                                    	AND [MachineId] = @MachineId
                                    
                                    IF (@@ROWCOUNT > 0)
                                    BEGIN
                                    	UPDATE [Deneme].[MVF].[AtNowMachineStatuses]
                                    	SET [MachineStatusId] = @MachineStatusId
                                    	WHERE 1 = 1
                                    		AND [MachineId] = @MachineId
                                    END
                                    ELSE
                                    BEGIN
                                    	INSERT INTO [MVF].[AtNowMachineStatuses] (
                                    		[AtNowMachineStatusId]
                                    		,[MachineId]
                                    		,[MachineStatusId]
                                    		)
                                    	VALUES (
                                    		NEWID()
                                    		,@MachineId
                                    		,@MachineStatusId
                                    		)
                                    END
                                    ";
                    numResults = connection.Execute(query, param: new { @MachineId = machineId, @MachineStatusId = machineStatusId });
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

    }
}
