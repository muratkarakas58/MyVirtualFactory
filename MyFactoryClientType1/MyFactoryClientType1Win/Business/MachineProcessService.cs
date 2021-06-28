using MyFactoryClientType1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFactoryClientType1.Business
{
    public class MachineProcessService
    {

        public Result<string> MachinerModelProcess(string inputData)
        {
            Result<string> outputData = new Result<string>(false, "Başarısız", "");
            string JsonString = JsonConvert.SerializeObject(outputData);
            try
            {

                switch (inputData.Substring(0, 4))
                {
                    case "M002":

                        var resultCheckM002Model = CheckM002Model(inputData);
                        if (!resultCheckM002Model.Success)
                        {
                            outputData.Success = false;
                            outputData.Message = resultCheckM002Model.Message;
                            JsonString = JsonConvert.SerializeObject(outputData).Replace("\\", "");
                            return new Result<string>(false, $"{resultCheckM002Model.Message}", JsonString);
                        }
                                               
                    
                        break;
                    default:
                        return new Result<string>(false, $"Başarısız", JsonString);
                }

                outputData.Success = true;
                outputData.Message = "Başarılı";
                JsonString = JsonConvert.SerializeObject(outputData).Replace("\\", "");
                //JObject jObjectData = JObject.Parse(JsonString);

                return new Result<string>(true, $"Başarılı", JsonString);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", JsonString);
            }
        }

        public Result<string> CheckM002Model(string inputData)
        {
            try
            {
                TextBox textBoxMachineStatus = Application.OpenForms["FormMyFactoryClientType1"].Controls["textBoxMachineStatus"] as TextBox;


                int machineStatus = int.Parse(textBoxMachineStatus.Text.Trim());
                if (machineStatus==0)
                {
                    return new Result<string>(false, $"Makina meşgul", null);
                }

                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

    }
}
