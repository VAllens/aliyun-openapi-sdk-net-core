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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ActivateMediaWorkflowResponseUnmarshaller
    {
        public static ActivateMediaWorkflowResponse Unmarshall(UnmarshallerContext context)
        {
            ActivateMediaWorkflowResponse activateMediaWorkflowResponse = new ActivateMediaWorkflowResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ActivateMediaWorkflow.RequestId")
            };
            ActivateMediaWorkflowResponse.MediaWorkflow_ mediaWorkflow = new ActivateMediaWorkflowResponse.MediaWorkflow_()
            {
                MediaWorkflowId = context.StringValue("ActivateMediaWorkflow.MediaWorkflow.MediaWorkflowId"),
                Name = context.StringValue("ActivateMediaWorkflow.MediaWorkflow.Name"),
                Topology = context.StringValue("ActivateMediaWorkflow.MediaWorkflow.Topology"),
                State = context.StringValue("ActivateMediaWorkflow.MediaWorkflow.State"),
                CreationTime = context.StringValue("ActivateMediaWorkflow.MediaWorkflow.CreationTime")
            };
            activateMediaWorkflowResponse.MediaWorkflow = mediaWorkflow;
        
			return activateMediaWorkflowResponse;
        }
    }
}