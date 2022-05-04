using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#pragma warning disable CS1998

namespace SurePrepAPI
{
    public partial class TaxCaddyV5Client
    {
        protected override async System.Threading.Tasks.Task ProcessResponseAsync(System.Net.Http.HttpClient httpClient, System.Net.Http.HttpResponseMessage response, System.Threading.CancellationToken cancellationToken)
        {
            if (response.RequestMessage.RequestUri.LocalPath.EndsWith("V5.0/TaxCaddy/EditBinder") ||
                response.RequestMessage.RequestUri.LocalPath.EndsWith("V5.0/TaxCaddy/Update7216Consent"))
            {
                if (response.Content.Headers.ContentLength.HasValue && response.Content.Headers.ContentLength.Value == 0)
                {
                    response.Content = new System.Net.Http.StringContent("\"\"");
                }
            }
            return;
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<int> DRLRequestAsync_2(DRLRequest sender)
        {
            return DRLRequestAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual int DRLRequest_2(DRLRequest sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await DRLRequestAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<int> DRLRequestAsync_2(DRLRequest sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.DRLRequestAsync(sender, cancellationToken).ConfigureAwait(false);
            if (result is long)
            {
                return (int)(long)result;
            }
            else if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BulkDRLError>> BulkDRLRequestAsync_2(System.Collections.Generic.IEnumerable<BulkDRLRequest> sender)
        {
            return BulkDRLRequestAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Collections.Generic.ICollection<BulkDRLError> BulkDRLRequest_2(System.Collections.Generic.IEnumerable<BulkDRLRequest> sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await BulkDRLRequestAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        public class BulkDRLError
        {
            public int DRLRequestID { get; set; }
            public int ClientDetailId { get; set; }
            public string ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BulkDRLError>> BulkDRLRequestAsync_2(System.Collections.Generic.IEnumerable<BulkDRLRequest> sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.BulkDRLRequestAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JArray)
            {
                var resultJArray = result as Newtonsoft.Json.Linq.JArray;

                var resultSuccess = resultJArray.ToObject<List<BulkDRLError>>();

                return resultSuccess;
            }
            else if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<int> TSFRequestAsync_2(DRLRequest sender)
        {
            return TSFRequestAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual int TSFRequest_2(DRLRequest sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await TSFRequestAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<int> TSFRequestAsync_2(DRLRequest sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.TSFRequestAsync(sender, cancellationToken).ConfigureAwait(false);
            if (result is long)
            {
                return (int)(long)result;
            }
            else if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<FileResponse> GetSWPBFXAsync_2(SWPBFXRequest sender)
        {
            return GetSWPBFXAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual FileResponse GetSWPBFX_2(SWPBFXRequest sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetSWPBFXAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<FileResponse> GetSWPBFXAsync_2(SWPBFXRequest sender, System.Threading.CancellationToken cancellationToken)
        {
            var fileResponse_ = await GetSWPBFXAsync(sender, cancellationToken);

            if (fileResponse_.Headers.TryGetValue("Content-Type", out var contentType))
            {
                var valContentType = contentType.FirstOrDefault();
                if (valContentType != null && valContentType.Equals("application/octet-stream", StringComparison.OrdinalIgnoreCase))
                {
                    return fileResponse_;
                }
            }

            if (fileResponse_.Stream != System.IO.Stream.Null)
            {
                using (StreamReader sr = new StreamReader(fileResponse_.Stream))
                {
                    string stringResult = await sr.ReadToEndAsync();

                    if (string.IsNullOrEmpty(stringResult))
                    {
                        throw new ApiException<SPError>("file is not found", 404, String.Empty, null, new SPError { }, null);
                    }

                    var spError = Newtonsoft.Json.JsonConvert.DeserializeObject<SPError>(stringResult);
                    throw new ApiException<SPError>("Service call returned error", 200, stringResult, null, spError, null);
                }
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, String.Empty, null, new SPError { }, null);
        }

        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<TCBinderStatusResponse>> GetBinderStatusAsync_2(ListTCBinderStatus sender)
        {
            return GetBinderStatusAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Collections.Generic.ICollection<TCBinderStatusResponse> GetBinderStatus_2(ListTCBinderStatus sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetBinderStatusAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        public class TCBinderStatusResponse
        {
            public int StatusID { get; set; }
            public string StatusName { get; set; }
            public string TaxPayerUniqueID { get; set; }
            public string EngagementType { get; set; }
            public int TaxYear { get; set; }

            public int? TCDocumentIDCount { get; set; }

        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<TCBinderStatusResponse>> GetBinderStatusAsync_2(ListTCBinderStatus sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.GetBinderStatusAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JArray)
            {
                var resultJArray = result as Newtonsoft.Json.Linq.JArray;

                var resultSuccess = resultJArray.ToObject<List<TCBinderStatusResponse>>();

                return resultSuccess;
            }
            else if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<SubmittedDocumentId>> GetSubmittedDocumentIdsAsync_2(SubmittedDocsRequest sender)
        {
            return GetSubmittedDocumentIdsAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Collections.Generic.ICollection<SubmittedDocumentId> GetSubmittedDocumentIds_2(SubmittedDocsRequest sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetSubmittedDocumentIdsAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        public class SubmittedDocumentId
        {
            public int DocumentId { get; set; }

            public DateTime? AddedtoBinderDate { get; set; }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<SubmittedDocumentId>> GetSubmittedDocumentIdsAsync_2(SubmittedDocsRequest sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.GetSubmittedDocumentIdsAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JArray)
            {
                var resultJArray = result as Newtonsoft.Json.Linq.JArray;

                var resultSuccess = resultJArray.ToObject<List<SubmittedDocumentId>>();

                return resultSuccess;
            }
            else if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AssignMembersResponse>> AddAssignMembersAsync_2(AddAssignMembers sender)
        {
            return AddAssignMembersAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Collections.Generic.ICollection<AssignMembersResponse> AddAssignMembers_2(AddAssignMembers sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await AddAssignMembersAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        public class AssignMembersResponse
        {
            public string UserKey { get; set; }
            public string ErrorCode { get; set; }
            public string Reason { get; set; }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AssignMembersResponse>> AddAssignMembersAsync_2(AddAssignMembers sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.AddAssignMembersAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JArray)
            {
                var resultJArray = result as Newtonsoft.Json.Linq.JArray;

                var resultSuccess = resultJArray.ToObject<List<AssignMembersResponse>>();

                return resultSuccess;
            }
            else if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }
            else if (result is string)
            {
                string stringResult = result as string;
                if (stringResult != null && stringResult.Equals("Success"))
                {
                    return new List<AssignMembersResponse>();
                }
                throw new ApiException<SPError>("Service call returned error", 500, stringResult, null, new SPError { }, null);
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<string> DeleteAssignMembersAsync_2(AddAssignMembers sender)
        {
            return DeleteAssignMembersAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual string DeleteAssignMembers_2(AddAssignMembers sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await DeleteAssignMembersAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<string> DeleteAssignMembersAsync_2(AddAssignMembers sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.DeleteAssignMembersAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }
            else if (result is string)
            {
                return result as string;
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<string> TransferOwnerAsync_2(TransferOwner sender)
        {
            return TransferOwnerAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual string TransferOwner_2(TransferOwner sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await TransferOwnerAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<string> TransferOwnerAsync_2(TransferOwner sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.TransferOwnerAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }
            else if (result is string)
            {
                return result as string;
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AssignMembersTaxCaddy>> GetBinderAssignMembersAsync_2(BinderMember sender)
        {
            return GetBinderAssignMembersAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Collections.Generic.ICollection<AssignMembersTaxCaddy> GetBinderAssignMembers_2(BinderMember sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetBinderAssignMembersAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AssignMembersTaxCaddy>> GetBinderAssignMembersAsync_2(BinderMember sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.GetBinderAssignMembersAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JArray)
            {
                var resultJArray = result as Newtonsoft.Json.Linq.JArray;

                var resultSuccess = resultJArray.ToObject<List<AssignMembersTaxCaddy>>();

                return resultSuccess;
            }
            else if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<ClientIDBySSNResponse> GetClientIDBySSNAsync_2(ClientIDBySSN sender)
        {
            return GetClientIDBySSNAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual ClientIDBySSNResponse GetClientIDBySSN_2(ClientIDBySSN sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetClientIDBySSNAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        public class Address
        {
            public string Apartment { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string ZipCode { get; set; }
            public string StreetAddress { get; set; }
        }

        public class ClientIDBySSNResponse
        {
            public string SSN { get; set; }
            public int TaxPayerUniqueID { get; set; }
            public string ClientID { get; set; }
            public Address address { get; set; }
            public string FirmKey { get; set; }
            public int TaxYear { get; set; }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<ClientIDBySSNResponse> GetClientIDBySSNAsync_2(ClientIDBySSN sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.GetClientIDBySSNAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                if (resultJObject.Properties().Any(p => p.Name == "ErrorCode" || p.Name == "ErrorDesc"))
                {
                    var spError = resultJObject.ToObject<SPError>();

                    throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
                }

                var clientIDBySSNResponse = resultJObject.ToObject<ClientIDBySSNResponse>();

                return clientIDBySSNResponse;
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<EmailExistsModelResponse> CheckEmailExistsAsync_2(EmailExistsModel sender)
        {
            return CheckEmailExistsAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual EmailExistsModelResponse CheckEmailExists_2(EmailExistsModel sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await CheckEmailExistsAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        public class EmailExistsModelResponse
        {
            public bool Status { get; set; }
            public string Message { get; set; }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<EmailExistsModelResponse> CheckEmailExistsAsync_2(EmailExistsModel sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.CheckEmailExistsAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                if (resultJObject.Properties().Any(p => p.Name == "ErrorCode" || p.Name == "ErrorDesc"))
                {
                    var spError = resultJObject.ToObject<SPError>();

                    throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
                }

                var clientIDBySSNResponse = resultJObject.ToObject<EmailExistsModelResponse>();

                return clientIDBySSNResponse;
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<object> RestrictBinderByOfficeAsync_2(RestrictBinderByOffice sender)
        {
            return RestrictBinderByOfficeAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual object RestrictBinderByOffice_2(RestrictBinderByOffice sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await RestrictBinderByOfficeAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<object> RestrictBinderByOfficeAsync_2(RestrictBinderByOffice sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.RestrictBinderByOfficeAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }
            else if (result is string)
            {
                string stringResult = result as string;

                if (string.IsNullOrEmpty(stringResult))
                {
                    return "Success";
                }

                return stringResult;
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<object> Update7216ConsentAsync_2(Update7216Consent sender)
        {
            return Update7216ConsentAsync_2(sender, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual object Update7216Consent_2(Update7216Consent sender)
        {
            return System.Threading.Tasks.Task.Run(async () => await Update7216ConsentAsync_2(sender, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<object> Update7216ConsentAsync_2(Update7216Consent sender, System.Threading.CancellationToken cancellationToken)
        {
            var result = await this.Update7216ConsentAsync(sender, cancellationToken).ConfigureAwait(false);

            if (result is Newtonsoft.Json.Linq.JObject)
            {
                var resultJObject = result as Newtonsoft.Json.Linq.JObject;

                var spError = resultJObject.ToObject<SPError>();

                throw new ApiException<SPError>("Service call returned error", 200, result.ToString(), null, spError, null);
            }
            else if (result is string)
            {
                string stringResult = result as string;

                if (string.IsNullOrEmpty(stringResult))
                {
                    return "Success";
                }

                return stringResult;
            }

            throw new ApiException<SPError>("Service call returned unexpected result format", 500, result.ToString(), null, new SPError { }, null);
        }
    }
}

#pragma warning restore CS1998