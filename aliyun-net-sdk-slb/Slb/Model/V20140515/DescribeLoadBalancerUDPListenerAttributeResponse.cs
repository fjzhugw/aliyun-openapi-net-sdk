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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeLoadBalancerUDPListenerAttributeResponse : AcsResponse
	{

		private string requestId;

		private int? listenerPort;

		private int? backendServerPort;

		private string status;

		private int? bandwidth;

		private string scheduler;

		private int? persistenceTimeout;

		private string healthCheck;

		private int? healthyThreshold;

		private int? unhealthyThreshold;

		private int? healthCheckConnectTimeout;

		private int? healthCheckConnectPort;

		private int? healthCheckInterval;

		private string healthCheckReq;

		private string healthCheckExp;

		private int? maxConnection;

		private string vServerGroupId;

		private string masterSlaveServerGroupId;

		private string aclId;

		private string aclType;

		private string aclStatus;

		private string vpcIds;

		private string description;

		private string connectionDrain;

		private int? connectionDrainTimeout;

		private List<DescribeLoadBalancerUDPListenerAttribute_PortRange> portRanges;

		private List<string> aclIds;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
			}
		}

		public int? BackendServerPort
		{
			get
			{
				return backendServerPort;
			}
			set	
			{
				backendServerPort = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
			}
		}

		public string Scheduler
		{
			get
			{
				return scheduler;
			}
			set	
			{
				scheduler = value;
			}
		}

		public int? PersistenceTimeout
		{
			get
			{
				return persistenceTimeout;
			}
			set	
			{
				persistenceTimeout = value;
			}
		}

		public string HealthCheck
		{
			get
			{
				return healthCheck;
			}
			set	
			{
				healthCheck = value;
			}
		}

		public int? HealthyThreshold
		{
			get
			{
				return healthyThreshold;
			}
			set	
			{
				healthyThreshold = value;
			}
		}

		public int? UnhealthyThreshold
		{
			get
			{
				return unhealthyThreshold;
			}
			set	
			{
				unhealthyThreshold = value;
			}
		}

		public int? HealthCheckConnectTimeout
		{
			get
			{
				return healthCheckConnectTimeout;
			}
			set	
			{
				healthCheckConnectTimeout = value;
			}
		}

		public int? HealthCheckConnectPort
		{
			get
			{
				return healthCheckConnectPort;
			}
			set	
			{
				healthCheckConnectPort = value;
			}
		}

		public int? HealthCheckInterval
		{
			get
			{
				return healthCheckInterval;
			}
			set	
			{
				healthCheckInterval = value;
			}
		}

		public string HealthCheckReq
		{
			get
			{
				return healthCheckReq;
			}
			set	
			{
				healthCheckReq = value;
			}
		}

		public string HealthCheckExp
		{
			get
			{
				return healthCheckExp;
			}
			set	
			{
				healthCheckExp = value;
			}
		}

		public int? MaxConnection
		{
			get
			{
				return maxConnection;
			}
			set	
			{
				maxConnection = value;
			}
		}

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
			}
		}

		public string MasterSlaveServerGroupId
		{
			get
			{
				return masterSlaveServerGroupId;
			}
			set	
			{
				masterSlaveServerGroupId = value;
			}
		}

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
			}
		}

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
			}
		}

		public string VpcIds
		{
			get
			{
				return vpcIds;
			}
			set	
			{
				vpcIds = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string ConnectionDrain
		{
			get
			{
				return connectionDrain;
			}
			set	
			{
				connectionDrain = value;
			}
		}

		public int? ConnectionDrainTimeout
		{
			get
			{
				return connectionDrainTimeout;
			}
			set	
			{
				connectionDrainTimeout = value;
			}
		}

		public List<DescribeLoadBalancerUDPListenerAttribute_PortRange> PortRanges
		{
			get
			{
				return portRanges;
			}
			set	
			{
				portRanges = value;
			}
		}

		public List<string> AclIds
		{
			get
			{
				return aclIds;
			}
			set	
			{
				aclIds = value;
			}
		}

		public class DescribeLoadBalancerUDPListenerAttribute_PortRange
		{

			private int? startPort;

			private int? endPort;

			public int? StartPort
			{
				get
				{
					return startPort;
				}
				set	
				{
					startPort = value;
				}
			}

			public int? EndPort
			{
				get
				{
					return endPort;
				}
				set	
				{
					endPort = value;
				}
			}
		}
	}
}
