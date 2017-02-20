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
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateReadOnlyDBInstanceRequest : RpcAcsRequest<CreateReadOnlyDBInstanceResponse>
    {
        public CreateReadOnlyDBInstanceRequest()
            : base("Rds", "2014-08-15", "CreateReadOnlyDBInstance")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _clientToken;

		private string _zoneId;

		private string _dBInstanceId;

		private string _dBInstanceClass;

		private int? _dBInstanceStorage;

		private string _engineVersion;

		private string _payType;

		private string _dBInstanceDescription;

		private string _instanceNetworkType;

		private string _vPcId;

		private string _vSwitchId;

		private string _privateIpAddress;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return _clientToken;
			}
			set	
			{
				_clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return _zoneId;
			}
			set	
			{
				_zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return _dBInstanceId;
			}
			set	
			{
				_dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string DBInstanceClass
		{
			get
			{
				return _dBInstanceClass;
			}
			set	
			{
				_dBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
			}
		}

		public int? DBInstanceStorage
		{
			get
			{
				return _dBInstanceStorage;
			}
			set	
			{
				_dBInstanceStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorage", value.ToString());
			}
		}

		public string EngineVersion
		{
			get
			{
				return _engineVersion;
			}
			set	
			{
				_engineVersion = value;
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		public string PayType
		{
			get
			{
				return _payType;
			}
			set	
			{
				_payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

		public string DBInstanceDescription
		{
			get
			{
				return _dBInstanceDescription;
			}
			set	
			{
				_dBInstanceDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceDescription", value);
			}
		}

		public string InstanceNetworkType
		{
			get
			{
				return _instanceNetworkType;
			}
			set	
			{
				_instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

		public string VpcId
		{
			get
			{
				return _vPcId;
			}
			set	
			{
				_vPcId = value;
				DictionaryUtil.Add(QueryParameters, "VPCId", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return _vSwitchId;
			}
			set	
			{
				_vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string PrivateIpAddress
		{
			get
			{
				return _privateIpAddress;
			}
			set	
			{
				_privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override CreateReadOnlyDBInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateReadOnlyDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}