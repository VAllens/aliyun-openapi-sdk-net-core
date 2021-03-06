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
    public class TestRequest : RpcAcsRequest<TestResponse>
    {
        public TestRequest()
            : base("Push", "2015-08-27", "Test")
        {
        }

		private long? _appKey;

		private string _target;

		private string _targetValue;

		private string _myName;

		private long? _myAge;

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

		public string Target
		{
			get
			{
				return _target;
			}
			set	
			{
				_target = value;
				DictionaryUtil.Add(QueryParameters, "Target", value);
			}
		}

		public string TargetValue
		{
			get
			{
				return _targetValue;
			}
			set	
			{
				_targetValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetValue", value);
			}
		}

		public string MyName
		{
			get
			{
				return _myName;
			}
			set	
			{
				_myName = value;
				DictionaryUtil.Add(QueryParameters, "my_name", value);
			}
		}

		public long? MyAge
		{
			get
			{
				return _myAge;
			}
			set	
			{
				_myAge = value;
				DictionaryUtil.Add(QueryParameters, "my_age", value.ToString());
			}
		}

        public override TestResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return TestResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}