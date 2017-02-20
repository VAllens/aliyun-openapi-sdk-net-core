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
using Aliyun.Acs.Iot.Model.V20160530;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class QueryDeviceByNameResponseUnmarshaller
    {
        public static QueryDeviceByNameResponse Unmarshall(UnmarshallerContext context)
        {
            QueryDeviceByNameResponse queryDeviceByNameResponse = new QueryDeviceByNameResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryDeviceByName.RequestId"),
                Success = context.BooleanValue("QueryDeviceByName.Success"),
                ErrorMessage = context.StringValue("QueryDeviceByName.ErrorMessage")
            };
            QueryDeviceByNameResponse.DeviceInfo_ deviceInfo = new QueryDeviceByNameResponse.DeviceInfo_()
            {
                DeviceId = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceId"),
                DeviceSecret = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceSecret"),
                ProductKey = context.StringValue("QueryDeviceByName.DeviceInfo.ProductKey"),
                DeviceStatus = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceStatus"),
                DeviceName = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceName"),
                GmtCreate = context.StringValue("QueryDeviceByName.DeviceInfo.GmtCreate"),
                GmtModified = context.StringValue("QueryDeviceByName.DeviceInfo.GmtModified")
            };
            queryDeviceByNameResponse.DeviceInfo = deviceInfo;
        
			return queryDeviceByNameResponse;
        }
    }
}