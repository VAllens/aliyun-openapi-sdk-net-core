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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeApiTrafficControlsResponseUnmarshaller
    {
        public static DescribeApiTrafficControlsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeApiTrafficControlsResponse describeApiTrafficControlsResponse = new DescribeApiTrafficControlsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeApiTrafficControls.RequestId"),
                TotalCount = context.IntegerValue("DescribeApiTrafficControls.TotalCount"),
                PageSize = context.IntegerValue("DescribeApiTrafficControls.PageSize"),
                PageNumber = context.IntegerValue("DescribeApiTrafficControls.PageNumber")
            };
            List<DescribeApiTrafficControlsResponse.ApiTrafficControlItem> apiTrafficControls = new List<DescribeApiTrafficControlsResponse.ApiTrafficControlItem>();
			for (int i = 0; i < context.Length("DescribeApiTrafficControls.ApiTrafficControls.Length"); i++) {
                DescribeApiTrafficControlsResponse.ApiTrafficControlItem apiTrafficControlItem = new DescribeApiTrafficControlsResponse.ApiTrafficControlItem()
                {
                    ApiId = context.StringValue($"DescribeApiTrafficControls.ApiTrafficControls[{i}].ApiId"),
                    ApiName = context.StringValue($"DescribeApiTrafficControls.ApiTrafficControls[{i}].ApiName"),
                    TrafficControlId = context.StringValue($"DescribeApiTrafficControls.ApiTrafficControls[{i}].TrafficControlId"),
                    TrafficControlName = context.StringValue($"DescribeApiTrafficControls.ApiTrafficControls[{i}].TrafficControlName"),
                    BoundTime = context.StringValue($"DescribeApiTrafficControls.ApiTrafficControls[{i}].BoundTime")
                };
                apiTrafficControls.Add(apiTrafficControlItem);
			}
			describeApiTrafficControlsResponse.ApiTrafficControls = apiTrafficControls;
        
			return describeApiTrafficControlsResponse;
        }
    }
}