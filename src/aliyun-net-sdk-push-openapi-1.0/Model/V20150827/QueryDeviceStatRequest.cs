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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform.V20150827;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class QueryDeviceStatRequest : RpcAcsRequest<QueryDeviceStatResponse>
    {
        public QueryDeviceStatRequest()
            : base("Push", "2015-08-27", "QueryDeviceStat")
        {
        }

		private long? _appKey;

		private string _startTime;

		private string _endTime;

		private string _deviceType;

		private string _queryType;

		public long? AppKey
		{
			get
			{
				return _appKey;
			}
			set	
			{
				_appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string StartTime
		{
			get
			{
				return _startTime;
			}
			set	
			{
				_startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string EndTime
		{
			get
			{
				return _endTime;
			}
			set	
			{
				_endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string DeviceType
		{
			get
			{
				return _deviceType;
			}
			set	
			{
				_deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value);
			}
		}

		public string QueryType
		{
			get
			{
				return _queryType;
			}
			set	
			{
				_queryType = value;
				DictionaryUtil.Add(QueryParameters, "QueryType", value);
			}
		}

        public override QueryDeviceStatResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryDeviceStatResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}