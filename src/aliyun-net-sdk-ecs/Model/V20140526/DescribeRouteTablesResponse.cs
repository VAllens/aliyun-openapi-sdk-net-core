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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeRouteTablesResponse : AcsResponse
	{
	    public int? TotalCount { get; set; }

	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public List<RouteTable> RouteTables { get; set; }

	    public class RouteTable{
	        public string VRouterId { get; set; }

	        public string RouteTableId { get; set; }

	        public string RouteTableType { get; set; }

	        public string CreationTime { get; set; }

	        public List<RouteEntry> RouteEntrys { get; set; }

	        public class RouteEntry{
	            public string RouteTableId { get; set; }

	            public string DestinationCidrBlock { get; set; }

	            public string Type { get; set; }

	            public string Status { get; set; }

	            public string InstanceId { get; set; }

	            public string NextHopType { get; set; }

	            public List<NextHop> NextHops { get; set; }

	            public class NextHop{
	                public string NextHopType { get; set; }

	                public string NextHopId { get; set; }
	            }
			}
		}
	}
}