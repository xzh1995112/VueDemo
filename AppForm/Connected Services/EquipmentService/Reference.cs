﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppForm.EquipmentService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EquipmentService.IEquipmentService")]
    public interface IEquipmentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/SynChangeScheduleStatusInfo", ReplyAction="http://tempuri.org/IEquipmentService/SynChangeScheduleStatusInfoResponse")]
        string SynChangeScheduleStatusInfo(string RBASId, string statuscode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/SynChangeScheduleStatusInfo", ReplyAction="http://tempuri.org/IEquipmentService/SynChangeScheduleStatusInfoResponse")]
        System.Threading.Tasks.Task<string> SynChangeScheduleStatusInfoAsync(string RBASId, string statuscode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/SynScheduleInfo", ReplyAction="http://tempuri.org/IEquipmentService/SynScheduleInfoResponse")]
        string SynScheduleInfo(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/SynScheduleInfo", ReplyAction="http://tempuri.org/IEquipmentService/SynScheduleInfoResponse")]
        System.Threading.Tasks.Task<string> SynScheduleInfoAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/HospitalInfo", ReplyAction="http://tempuri.org/IEquipmentService/HospitalInfoResponse")]
        string HospitalInfo(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/HospitalInfo", ReplyAction="http://tempuri.org/IEquipmentService/HospitalInfoResponse")]
        System.Threading.Tasks.Task<string> HospitalInfoAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DepartmentsInfo", ReplyAction="http://tempuri.org/IEquipmentService/DepartmentsInfoResponse")]
        string DepartmentsInfo(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DepartmentsInfo", ReplyAction="http://tempuri.org/IEquipmentService/DepartmentsInfoResponse")]
        System.Threading.Tasks.Task<string> DepartmentsInfoAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DoctorsInfo", ReplyAction="http://tempuri.org/IEquipmentService/DoctorsInfoResponse")]
        string DoctorsInfo(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DoctorsInfo", ReplyAction="http://tempuri.org/IEquipmentService/DoctorsInfoResponse")]
        System.Threading.Tasks.Task<string> DoctorsInfoAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DepartmentsParentInfo", ReplyAction="http://tempuri.org/IEquipmentService/DepartmentsParentInfoResponse")]
        string DepartmentsParentInfo(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DepartmentsParentInfo", ReplyAction="http://tempuri.org/IEquipmentService/DepartmentsParentInfoResponse")]
        System.Threading.Tasks.Task<string> DepartmentsParentInfoAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DepartmentsParentInfoNotWhere", ReplyAction="http://tempuri.org/IEquipmentService/DepartmentsParentInfoNotWhereResponse")]
        string DepartmentsParentInfoNotWhere();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/DepartmentsParentInfoNotWhere", ReplyAction="http://tempuri.org/IEquipmentService/DepartmentsParentInfoNotWhereResponse")]
        System.Threading.Tasks.Task<string> DepartmentsParentInfoNotWhereAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/QueryHYD", ReplyAction="http://tempuri.org/IEquipmentService/QueryHYDResponse")]
        string QueryHYD(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/QueryHYD", ReplyAction="http://tempuri.org/IEquipmentService/QueryHYDResponse")]
        System.Threading.Tasks.Task<string> QueryHYDAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/ReportPrint", ReplyAction="http://tempuri.org/IEquipmentService/ReportPrintResponse")]
        string ReportPrint(string SpecimenID, string RISRExamID, string PATPatientID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/ReportPrint", ReplyAction="http://tempuri.org/IEquipmentService/ReportPrintResponse")]
        System.Threading.Tasks.Task<string> ReportPrintAsync(string SpecimenID, string RISRExamID, string PATPatientID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_County", ReplyAction="http://tempuri.org/IEquipmentService/Get_CountyResponse")]
        string Get_County(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_County", ReplyAction="http://tempuri.org/IEquipmentService/Get_CountyResponse")]
        System.Threading.Tasks.Task<string> Get_CountyAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_Province", ReplyAction="http://tempuri.org/IEquipmentService/Get_ProvinceResponse")]
        string Get_Province();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_Province", ReplyAction="http://tempuri.org/IEquipmentService/Get_ProvinceResponse")]
        System.Threading.Tasks.Task<string> Get_ProvinceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_City", ReplyAction="http://tempuri.org/IEquipmentService/Get_CityResponse")]
        string Get_City(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_City", ReplyAction="http://tempuri.org/IEquipmentService/Get_CityResponse")]
        System.Threading.Tasks.Task<string> Get_CityAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_Nation", ReplyAction="http://tempuri.org/IEquipmentService/Get_NationResponse")]
        string Get_Nation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/Get_Nation", ReplyAction="http://tempuri.org/IEquipmentService/Get_NationResponse")]
        System.Threading.Tasks.Task<string> Get_NationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDocterList", ReplyAction="http://tempuri.org/IEquipmentService/GetDocterListResponse")]
        string GetDocterList(string DeptId, string sdate, string edate, string apm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDocterList", ReplyAction="http://tempuri.org/IEquipmentService/GetDocterListResponse")]
        System.Threading.Tasks.Task<string> GetDocterListAsync(string DeptId, string sdate, string edate, string apm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptList", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptListResponse")]
        string GetDeptList(string sdate, string edate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptList", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptListResponse")]
        System.Threading.Tasks.Task<string> GetDeptListAsync(string sdate, string edate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetScheduleList", ReplyAction="http://tempuri.org/IEquipmentService/GetScheduleListResponse")]
        string GetScheduleList(string ScheduleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetScheduleList", ReplyAction="http://tempuri.org/IEquipmentService/GetScheduleListResponse")]
        System.Threading.Tasks.Task<string> GetScheduleListAsync(string ScheduleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptInfo", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptInfoResponse")]
        string GetDeptInfo(string ScheduleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptInfo", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptInfoResponse")]
        System.Threading.Tasks.Task<string> GetDeptInfoAsync(string ScheduleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorListEx", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorListExResponse")]
        string GetDoctorListEx(string deptid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorListEx", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorListExResponse")]
        System.Threading.Tasks.Task<string> GetDoctorListExAsync(string deptid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorInfo", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorInfoResponse")]
        string GetDoctorInfo(string DoctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorInfo", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorInfoResponse")]
        System.Threading.Tasks.Task<string> GetDoctorInfoAsync(string DoctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptDoctors", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptDoctorsResponse")]
        string GetDeptDoctors(string DeptCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptDoctors", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptDoctorsResponse")]
        System.Threading.Tasks.Task<string> GetDeptDoctorsAsync(string DeptCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorReMarks", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorReMarksResponse")]
        string GetDoctorReMarks(string DoctorCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorReMarks", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorReMarksResponse")]
        System.Threading.Tasks.Task<string> GetDoctorReMarksAsync(string DoctorCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetSuperDeptFromDate", ReplyAction="http://tempuri.org/IEquipmentService/GetSuperDeptFromDateResponse")]
        string GetSuperDeptFromDate(string sdate, string edate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetSuperDeptFromDate", ReplyAction="http://tempuri.org/IEquipmentService/GetSuperDeptFromDateResponse")]
        System.Threading.Tasks.Task<string> GetSuperDeptFromDateAsync(string sdate, string edate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptListFromDate", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptListFromDateResponse")]
        string GetDeptListFromDate(string sdate, string edate, string apm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDeptListFromDate", ReplyAction="http://tempuri.org/IEquipmentService/GetDeptListFromDateResponse")]
        System.Threading.Tasks.Task<string> GetDeptListFromDateAsync(string sdate, string edate, string apm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorFromDate", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorFromDateResponse")]
        string GetDoctorFromDate(string DeptCode, string sdate, string edate, string apm, string btime, string etime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetDoctorFromDate", ReplyAction="http://tempuri.org/IEquipmentService/GetDoctorFromDateResponse")]
        System.Threading.Tasks.Task<string> GetDoctorFromDateAsync(string DeptCode, string sdate, string edate, string apm, string btime, string etime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetSingleDoctorSchedule", ReplyAction="http://tempuri.org/IEquipmentService/GetSingleDoctorScheduleResponse")]
        string GetSingleDoctorSchedule(string RBASid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/GetSingleDoctorSchedule", ReplyAction="http://tempuri.org/IEquipmentService/GetSingleDoctorScheduleResponse")]
        System.Threading.Tasks.Task<string> GetSingleDoctorScheduleAsync(string RBASid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/QueryHYDFromPatientID", ReplyAction="http://tempuri.org/IEquipmentService/QueryHYDFromPatientIDResponse")]
        string QueryHYDFromPatientID(string PATPatientID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquipmentService/QueryHYDFromPatientID", ReplyAction="http://tempuri.org/IEquipmentService/QueryHYDFromPatientIDResponse")]
        System.Threading.Tasks.Task<string> QueryHYDFromPatientIDAsync(string PATPatientID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEquipmentServiceChannel : AppForm.EquipmentService.IEquipmentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EquipmentServiceClient : System.ServiceModel.ClientBase<AppForm.EquipmentService.IEquipmentService>, AppForm.EquipmentService.IEquipmentService {
        
        public EquipmentServiceClient() {
        }
        
        public EquipmentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EquipmentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EquipmentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EquipmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SynChangeScheduleStatusInfo(string RBASId, string statuscode) {
            return base.Channel.SynChangeScheduleStatusInfo(RBASId, statuscode);
        }
        
        public System.Threading.Tasks.Task<string> SynChangeScheduleStatusInfoAsync(string RBASId, string statuscode) {
            return base.Channel.SynChangeScheduleStatusInfoAsync(RBASId, statuscode);
        }
        
        public string SynScheduleInfo(string composite) {
            return base.Channel.SynScheduleInfo(composite);
        }
        
        public System.Threading.Tasks.Task<string> SynScheduleInfoAsync(string composite) {
            return base.Channel.SynScheduleInfoAsync(composite);
        }
        
        public string HospitalInfo(string composite) {
            return base.Channel.HospitalInfo(composite);
        }
        
        public System.Threading.Tasks.Task<string> HospitalInfoAsync(string composite) {
            return base.Channel.HospitalInfoAsync(composite);
        }
        
        public string DepartmentsInfo(string composite) {
            return base.Channel.DepartmentsInfo(composite);
        }
        
        public System.Threading.Tasks.Task<string> DepartmentsInfoAsync(string composite) {
            return base.Channel.DepartmentsInfoAsync(composite);
        }
        
        public string DoctorsInfo(string composite) {
            return base.Channel.DoctorsInfo(composite);
        }
        
        public System.Threading.Tasks.Task<string> DoctorsInfoAsync(string composite) {
            return base.Channel.DoctorsInfoAsync(composite);
        }
        
        public string DepartmentsParentInfo(string composite) {
            return base.Channel.DepartmentsParentInfo(composite);
        }
        
        public System.Threading.Tasks.Task<string> DepartmentsParentInfoAsync(string composite) {
            return base.Channel.DepartmentsParentInfoAsync(composite);
        }
        
        public string DepartmentsParentInfoNotWhere() {
            return base.Channel.DepartmentsParentInfoNotWhere();
        }
        
        public System.Threading.Tasks.Task<string> DepartmentsParentInfoNotWhereAsync() {
            return base.Channel.DepartmentsParentInfoNotWhereAsync();
        }
        
        public string QueryHYD(string composite) {
            return base.Channel.QueryHYD(composite);
        }
        
        public System.Threading.Tasks.Task<string> QueryHYDAsync(string composite) {
            return base.Channel.QueryHYDAsync(composite);
        }
        
        public string ReportPrint(string SpecimenID, string RISRExamID, string PATPatientID) {
            return base.Channel.ReportPrint(SpecimenID, RISRExamID, PATPatientID);
        }
        
        public System.Threading.Tasks.Task<string> ReportPrintAsync(string SpecimenID, string RISRExamID, string PATPatientID) {
            return base.Channel.ReportPrintAsync(SpecimenID, RISRExamID, PATPatientID);
        }
        
        public string Get_County(string composite) {
            return base.Channel.Get_County(composite);
        }
        
        public System.Threading.Tasks.Task<string> Get_CountyAsync(string composite) {
            return base.Channel.Get_CountyAsync(composite);
        }
        
        public string Get_Province() {
            return base.Channel.Get_Province();
        }
        
        public System.Threading.Tasks.Task<string> Get_ProvinceAsync() {
            return base.Channel.Get_ProvinceAsync();
        }
        
        public string Get_City(string composite) {
            return base.Channel.Get_City(composite);
        }
        
        public System.Threading.Tasks.Task<string> Get_CityAsync(string composite) {
            return base.Channel.Get_CityAsync(composite);
        }
        
        public string Get_Nation() {
            return base.Channel.Get_Nation();
        }
        
        public System.Threading.Tasks.Task<string> Get_NationAsync() {
            return base.Channel.Get_NationAsync();
        }
        
        public string GetDocterList(string DeptId, string sdate, string edate, string apm) {
            return base.Channel.GetDocterList(DeptId, sdate, edate, apm);
        }
        
        public System.Threading.Tasks.Task<string> GetDocterListAsync(string DeptId, string sdate, string edate, string apm) {
            return base.Channel.GetDocterListAsync(DeptId, sdate, edate, apm);
        }
        
        public string GetDeptList(string sdate, string edate) {
            return base.Channel.GetDeptList(sdate, edate);
        }
        
        public System.Threading.Tasks.Task<string> GetDeptListAsync(string sdate, string edate) {
            return base.Channel.GetDeptListAsync(sdate, edate);
        }
        
        public string GetScheduleList(string ScheduleId) {
            return base.Channel.GetScheduleList(ScheduleId);
        }
        
        public System.Threading.Tasks.Task<string> GetScheduleListAsync(string ScheduleId) {
            return base.Channel.GetScheduleListAsync(ScheduleId);
        }
        
        public string GetDeptInfo(string ScheduleId) {
            return base.Channel.GetDeptInfo(ScheduleId);
        }
        
        public System.Threading.Tasks.Task<string> GetDeptInfoAsync(string ScheduleId) {
            return base.Channel.GetDeptInfoAsync(ScheduleId);
        }
        
        public string GetDoctorListEx(string deptid) {
            return base.Channel.GetDoctorListEx(deptid);
        }
        
        public System.Threading.Tasks.Task<string> GetDoctorListExAsync(string deptid) {
            return base.Channel.GetDoctorListExAsync(deptid);
        }
        
        public string GetDoctorInfo(string DoctorId) {
            return base.Channel.GetDoctorInfo(DoctorId);
        }
        
        public System.Threading.Tasks.Task<string> GetDoctorInfoAsync(string DoctorId) {
            return base.Channel.GetDoctorInfoAsync(DoctorId);
        }
        
        public string GetDeptDoctors(string DeptCode) {
            return base.Channel.GetDeptDoctors(DeptCode);
        }
        
        public System.Threading.Tasks.Task<string> GetDeptDoctorsAsync(string DeptCode) {
            return base.Channel.GetDeptDoctorsAsync(DeptCode);
        }
        
        public string GetDoctorReMarks(string DoctorCode) {
            return base.Channel.GetDoctorReMarks(DoctorCode);
        }
        
        public System.Threading.Tasks.Task<string> GetDoctorReMarksAsync(string DoctorCode) {
            return base.Channel.GetDoctorReMarksAsync(DoctorCode);
        }
        
        public string GetSuperDeptFromDate(string sdate, string edate) {
            return base.Channel.GetSuperDeptFromDate(sdate, edate);
        }
        
        public System.Threading.Tasks.Task<string> GetSuperDeptFromDateAsync(string sdate, string edate) {
            return base.Channel.GetSuperDeptFromDateAsync(sdate, edate);
        }
        
        public string GetDeptListFromDate(string sdate, string edate, string apm) {
            return base.Channel.GetDeptListFromDate(sdate, edate, apm);
        }
        
        public System.Threading.Tasks.Task<string> GetDeptListFromDateAsync(string sdate, string edate, string apm) {
            return base.Channel.GetDeptListFromDateAsync(sdate, edate, apm);
        }
        
        public string GetDoctorFromDate(string DeptCode, string sdate, string edate, string apm, string btime, string etime) {
            return base.Channel.GetDoctorFromDate(DeptCode, sdate, edate, apm, btime, etime);
        }
        
        public System.Threading.Tasks.Task<string> GetDoctorFromDateAsync(string DeptCode, string sdate, string edate, string apm, string btime, string etime) {
            return base.Channel.GetDoctorFromDateAsync(DeptCode, sdate, edate, apm, btime, etime);
        }
        
        public string GetSingleDoctorSchedule(string RBASid) {
            return base.Channel.GetSingleDoctorSchedule(RBASid);
        }
        
        public System.Threading.Tasks.Task<string> GetSingleDoctorScheduleAsync(string RBASid) {
            return base.Channel.GetSingleDoctorScheduleAsync(RBASid);
        }
        
        public string QueryHYDFromPatientID(string PATPatientID) {
            return base.Channel.QueryHYDFromPatientID(PATPatientID);
        }
        
        public System.Threading.Tasks.Task<string> QueryHYDFromPatientIDAsync(string PATPatientID) {
            return base.Channel.QueryHYDFromPatientIDAsync(PATPatientID);
        }
    }
}
