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
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyRouterInterfaceAttributeRequest : RpcAcsRequest<ModifyRouterInterfaceAttributeResponse>
    {
        public ModifyRouterInterfaceAttributeRequest()
            : base("Ecs", "2014-05-26", "ModifyRouterInterfaceAttribute")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _routerInterfaceId;

		private string _name;

		private string _description;

		private string _oppositeInterfaceId;

		private string _oppositeRouterId;

		private string _oppositeRouterType;

		private string _oppositeInterfaceOwnerId;

		private string _healthCheckSourceIp;

		private string _healthCheckTargetIp;

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

		public string RouterInterfaceId
		{
			get
			{
				return _routerInterfaceId;
			}
			set	
			{
				_routerInterfaceId = value;
				DictionaryUtil.Add(QueryParameters, "RouterInterfaceId", value);
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set	
			{
				_name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string OppositeInterfaceId
		{
			get
			{
				return _oppositeInterfaceId;
			}
			set	
			{
				_oppositeInterfaceId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeInterfaceId", value);
			}
		}

		public string OppositeRouterId
		{
			get
			{
				return _oppositeRouterId;
			}
			set	
			{
				_oppositeRouterId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeRouterId", value);
			}
		}

		public string OppositeRouterType
		{
			get
			{
				return _oppositeRouterType;
			}
			set	
			{
				_oppositeRouterType = value;
				DictionaryUtil.Add(QueryParameters, "OppositeRouterType", value);
			}
		}

		public string OppositeInterfaceOwnerId
		{
			get
			{
				return _oppositeInterfaceOwnerId;
			}
			set	
			{
				_oppositeInterfaceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeInterfaceOwnerId", value);
			}
		}

		public string HealthCheckSourceIp
		{
			get
			{
				return _healthCheckSourceIp;
			}
			set	
			{
				_healthCheckSourceIp = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckSourceIp", value);
			}
		}

		public string HealthCheckTargetIp
		{
			get
			{
				return _healthCheckTargetIp;
			}
			set	
			{
				_healthCheckTargetIp = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckTargetIp", value);
			}
		}

        public override ModifyRouterInterfaceAttributeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyRouterInterfaceAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}