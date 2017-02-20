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
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class AddCdnDomainRequest : RpcAcsRequest<AddCdnDomainResponse>
    {
        public AddCdnDomainRequest()
            : base("Cdn", "2014-11-11", "AddCdnDomain")
        {
        }

		private long? _ownerId;

		private string _ownerAccount;

		private string _securityToken;

		private string _domainName;

		private string _cdnType;

		private string _sourceType;

		private string _sources;

		private int? _sourcePort;

		private string _serverCertificate;

		private string _privateKey;

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

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string CdnType
		{
			get
			{
				return _cdnType;
			}
			set	
			{
				_cdnType = value;
				DictionaryUtil.Add(QueryParameters, "CdnType", value);
			}
		}

		public string SourceType
		{
			get
			{
				return _sourceType;
			}
			set	
			{
				_sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string Sources
		{
			get
			{
				return _sources;
			}
			set	
			{
				_sources = value;
				DictionaryUtil.Add(QueryParameters, "Sources", value);
			}
		}

		public int? SourcePort
		{
			get
			{
				return _sourcePort;
			}
			set	
			{
				_sourcePort = value;
				DictionaryUtil.Add(QueryParameters, "SourcePort", value.ToString());
			}
		}

		public string ServerCertificate
		{
			get
			{
				return _serverCertificate;
			}
			set	
			{
				_serverCertificate = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificate", value);
			}
		}

		public string PrivateKey
		{
			get
			{
				return _privateKey;
			}
			set	
			{
				_privateKey = value;
				DictionaryUtil.Add(QueryParameters, "PrivateKey", value);
			}
		}

        public override AddCdnDomainResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddCdnDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}