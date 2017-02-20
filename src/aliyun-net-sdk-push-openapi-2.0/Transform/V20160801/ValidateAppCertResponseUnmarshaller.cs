/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Push.Model.V20160801;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class ValidateAppCertResponseUnmarshaller
    {
        public static ValidateAppCertResponse Unmarshall(UnmarshallerContext context)
        {
            ValidateAppCertResponse validateAppCertResponse = new ValidateAppCertResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ValidateAppCert.RequestId")
            };
            ValidateAppCertResponse.AppCertInfo_ appCertInfo = new ValidateAppCertResponse.AppCertInfo_()
            {
                AppName = context.StringValue("ValidateAppCert.AppCertInfo.AppName"),
                CertType = context.StringValue("ValidateAppCert.AppCertInfo.CertType"),
                DevCert = context.BooleanValue("ValidateAppCert.AppCertInfo.DevCert"),
                ExpirationDate = context.LongValue("ValidateAppCert.AppCertInfo.ExpirationDate"),
                GenerateDate = context.LongValue("ValidateAppCert.AppCertInfo.GenerateDate")
            };
            validateAppCertResponse.AppCertInfo = appCertInfo;
        
			return validateAppCertResponse;
        }
    }
}