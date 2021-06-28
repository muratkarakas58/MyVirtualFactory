using MyFactoryServer.DataAccess;
using MyFactoryServer.Models;
using MyFactoryServerWin.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryServer.Business
{
    public class ServerProcessService
    {

        public Result<string> ServerModelProcess(string inputData)
        {
            Result<string> outputData = new Result<string>(false, "Başarısız", "");
            string JsonString = JsonConvert.SerializeObject(outputData);
            try
            {

                switch (inputData.Substring(0, 4))
                {
                    case "M001":

                        var resultCheckM001Model = CheckM001Model(inputData);
                        if (!resultCheckM001Model.Success)
                        {
                            return new Result<string>(false, $"Başarısız", JsonString);
                        }

                        break;
                    case "M003":

                        var resultCheckM003Model = CheckM003Model(inputData);
                        if (!resultCheckM003Model.Success)
                        {
                            return new Result<string>(false, $"Başarısız", JsonString);
                        }

                        break;
                    case "M004":

                        var resultCheckM004Model = CheckM004Model(inputData);
                        if (!resultCheckM004Model.Success)
                        {
                            return new Result<string>(false, $"Başarısız", JsonString);
                        }

                        break;
                    case "M005":

                        var resultCheckM005Model = CheckM005Model(inputData);
                        if (!resultCheckM005Model.Success)
                        {
                            return new Result<string>(false, $"Başarısız", JsonString);
                        }

                        outputData.Data = resultCheckM005Model.Data.Replace("\r", "").Replace("\n", ""); 

                        break;
                    case "M006":

                        var resultCheckM006Model = CheckM006Model(inputData);
                        if (!resultCheckM006Model.Success)
                        {
                            return new Result<string>(false, $"Başarısız", JsonString);
                        }

                        outputData.Data = resultCheckM006Model.Data.Replace("\r","").Replace("\n","");

                        break;
                    case "M007":

                        var resultCheckM007Model = CheckM007Model(inputData);
                        if (!resultCheckM007Model.Success)
                        {
                            return new Result<string>(false, $"Başarısız", JsonString);
                        }

                        outputData.Data = resultCheckM007Model.Data.Replace("\r", "").Replace("\n", "");

                        break;
                    default:
                        return new Result<string>(false, $"Başarısız", JsonString);
                }

                outputData.Success = true;
                outputData.Message="Başarılı";                
                JsonString = JsonConvert.SerializeObject(outputData).Replace("\\","");
                 //JObject jObjectData = JObject.Parse(JsonString);

                return new Result<string>(true, $"Başarılı", JsonString);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", JsonString);
            }
        }

        public Result<string> CheckModel(string inputData)
        {
            try
            {

                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }


        public Result<string> CheckM001Model(string inputData)
        {
            try
            {
                string modelString = inputData.Substring(4, (inputData.Length - 4));

                M001 m001 = JsonConvert.DeserializeObject<M001>(modelString);

                var result = ServerProcessDal.UpsertMachineInfos(m001);

                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        public Result<string> CheckM003Model(string inputData)
        {
            try
            {
                string modelString = inputData.Substring(4, (inputData.Length - 4));

                M003 m003 = JsonConvert.DeserializeObject<M003>(modelString); 

                var resultGetDatatableCheckUserInfo = ServerProcessDal.GetDatatableCheckUserInfo(m003);

                if (!resultGetDatatableCheckUserInfo.Success||resultGetDatatableCheckUserInfo.Data.Rows.Count<=0)
                {
                    return new Result<string>(false, $"{resultGetDatatableCheckUserInfo.Message}", null);
                }
                                


                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        public Result<string> CheckM004Model(string inputData)
        {
            try
            {
                string modelString = inputData.Substring(4, (inputData.Length - 4));

                M004 m004 = JsonConvert.DeserializeObject<M004>(modelString);

                var resultInsertWorks = ServerProcessDal.InsertWorks(m004); 

                

                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        public Result<string> CheckM005Model(string inputData)
        {
            try
            { 
               
                var resultGetDatatableMachineInfos = ServerProcessDal.GetDatatableMachineInfos();

                if (!resultGetDatatableMachineInfos.Success || resultGetDatatableMachineInfos.Data.Rows.Count <= 0)
                {
                    return new Result<string>(false, $"{resultGetDatatableMachineInfos.Message}", null);
                }


                string json = JsonConvert.SerializeObject(resultGetDatatableMachineInfos.Data, Formatting.Indented);


                return new Result<string>(true, $"Başarılı", json);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        public Result<string> CheckM006Model(string inputData)
        {
            try
            {
                string modelString = inputData.Substring(4, (inputData.Length - 4));

                M006 m006 = JsonConvert.DeserializeObject<M006>(modelString);

                var resultGetDatatableMachineInfos = ServerProcessDal.GetDatatableMachineStatusAndWorksList(m006);

                if (!resultGetDatatableMachineInfos.Success || resultGetDatatableMachineInfos.Data.Rows.Count <= 0)
                {
                    return new Result<string>(false, $"{resultGetDatatableMachineInfos.Message}", null);
                }


                string json = JsonConvert.SerializeObject(resultGetDatatableMachineInfos.Data, Formatting.Indented);
                string temp = json.Replace("\n", "").Replace("\r","");

                return new Result<string>(true, $"Başarılı", json);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        public Result<string> CheckM007Model(string inputData)
        {
            try
            {
                //string modelString = inputData.Substring(4, (inputData.Length - 4));

                //M007 m007 = JsonConvert.DeserializeObject<M007>(modelString);

                var resultGetDatatable = ServerProcessDal.GetDatatableWaitingWorksList();

                if (!resultGetDatatable.Success || resultGetDatatable.Data.Rows.Count <= 0)
                {
                    return new Result<string>(false, $"{resultGetDatatable.Message}", null);
                }


                string json = JsonConvert.SerializeObject(resultGetDatatable.Data, Formatting.Indented);
                string temp = json.Replace("\n", "").Replace("\r", "");

                return new Result<string>(true, $"Başarılı", json);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

    }
}
