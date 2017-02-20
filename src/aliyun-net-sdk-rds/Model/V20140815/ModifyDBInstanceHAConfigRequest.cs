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
    public class ModifyDBInstanceHaConfigRequest : RpcAcsRequest<ModifyDBInstanceHaConfigResponse>
    {
        public ModifyDBInstanceHaConfigRequest()
            : base("Rds", "2014-08-15", "ModifyDBInstanceHAConfig")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _syncMode;

		private string _hAMode;

		private string _dbInstanceId;

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

		public string SyncMode
		{
			get
			{
				return _syncMode;
			}
			set	
			{
				_syncMode = value;
				DictionaryUtil.Add(QueryParameters, "SyncMode", value);
			}
		}

		public string HaMode
		{
			get
			{
				return _hAMode;
			}
			set	
			{
				_hAMode = value;
				DictionaryUtil.Add(QueryParameters, "HAMode", value);
			}
		}

		public string DbInstanceId
		{
			get
			{
				return _dbInstanceId;
			}
			set	
			{
				_dbInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DbInstanceId", value);
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

        public override ModifyDBInstanceHaConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBInstanceHaConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}