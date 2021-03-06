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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectImageLogosResponseUnmarshaller
    {
        public static DetectImageLogosResponse Unmarshall(UnmarshallerContext context)
        {
			DetectImageLogosResponse detectImageLogosResponse = new DetectImageLogosResponse();

			detectImageLogosResponse.HttpResponse = context.HttpResponse;
			detectImageLogosResponse.RequestId = context.StringValue("DetectImageLogos.RequestId");
			detectImageLogosResponse.ImageUri = context.StringValue("DetectImageLogos.ImageUri");

			List<DetectImageLogosResponse.DetectImageLogos_LogosItem> detectImageLogosResponse_logos = new List<DetectImageLogosResponse.DetectImageLogos_LogosItem>();
			for (int i = 0; i < context.Length("DetectImageLogos.Logos.Length"); i++) {
				DetectImageLogosResponse.DetectImageLogos_LogosItem logosItem = new DetectImageLogosResponse.DetectImageLogos_LogosItem();
				logosItem.LogoName = context.StringValue("DetectImageLogos.Logos["+ i +"].LogoName");
				logosItem.LogoConfidence = context.FloatValue("DetectImageLogos.Logos["+ i +"].LogoConfidence");

				DetectImageLogosResponse.DetectImageLogos_LogosItem.DetectImageLogos_LogoBoundary logoBoundary = new DetectImageLogosResponse.DetectImageLogos_LogosItem.DetectImageLogos_LogoBoundary();
				logoBoundary.Width = context.IntegerValue("DetectImageLogos.Logos["+ i +"].LogoBoundary.Width");
				logoBoundary.Height = context.IntegerValue("DetectImageLogos.Logos["+ i +"].LogoBoundary.Height");
				logoBoundary.Top = context.IntegerValue("DetectImageLogos.Logos["+ i +"].LogoBoundary.Top");
				logoBoundary.Left = context.IntegerValue("DetectImageLogos.Logos["+ i +"].LogoBoundary.Left");
				logosItem.LogoBoundary = logoBoundary;

				detectImageLogosResponse_logos.Add(logosItem);
			}
			detectImageLogosResponse.Logos = detectImageLogosResponse_logos;
        
			return detectImageLogosResponse;
        }
    }
}
