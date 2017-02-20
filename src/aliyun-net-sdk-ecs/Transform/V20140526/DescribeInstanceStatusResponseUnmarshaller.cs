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
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceStatusResponseUnmarshaller
    {
        public static DescribeInstanceStatusResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeInstanceStatusResponse describeInstanceStatusResponse = new DescribeInstanceStatusResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeInstanceStatus.RequestId"),
                TotalCount = context.IntegerValue("DescribeInstanceStatus.TotalCount"),
                PageNumber = context.IntegerValue("DescribeInstanceStatus.PageNumber"),
                PageSize = context.IntegerValue("DescribeInstanceStatus.PageSize")
            };
            List<DescribeInstanceStatusResponse.InstanceStatus> instanceStatuses = new List<DescribeInstanceStatusResponse.InstanceStatus>();
			for (int i = 0; i < context.Length("DescribeInstanceStatus.InstanceStatuses.Length"); i++) {
                DescribeInstanceStatusResponse.InstanceStatus instanceStatus = new DescribeInstanceStatusResponse.InstanceStatus()
                {
                    InstanceId = context.StringValue($"DescribeInstanceStatus.InstanceStatuses[{i}].InstanceId"),
                    Status = context.EnumValue<DescribeInstanceStatusResponse.InstanceStatus.StatusEnum>($"DescribeInstanceStatus.InstanceStatuses[{i}].Status")
                };
                instanceStatuses.Add(instanceStatus);
			}
			describeInstanceStatusResponse.InstanceStatuses = instanceStatuses;
        
			return describeInstanceStatusResponse;
        }
    }
}